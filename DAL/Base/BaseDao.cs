using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Entities;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
namespace DAL
{
    public class BaseDao:IBaseDao
    {
        
        protected static DbEntities _dbEntities { get; set; }
        protected DbConnection _con { get; set; }
        protected DbTransaction _tran { get; set; }
        public BaseDao()
        {
            _dbEntities = new DbEntities();
        }
        public void BeginTransaction()
        {
            _con = ((IObjectContextAdapter)_dbEntities).ObjectContext.Connection;
            _con.Open();
            _tran=_con.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _tran.Commit();
            _con.Close();
        }
        public void RollbackTransaction()
        {
            
            _tran.Rollback();
            _con.Close();
            
        }
       
        #region 查询普通实现方案(基于Lambda表达式的Where查询)
       /// <summary>
       /// 根据条件获取数据实体集合
       /// </summary>
       /// <typeparam name="T">实体类型</typeparam>
       /// <param name="exp">条件表达式</param>
       /// <param name="useBaseContext">是否使用类基础的context，以达到延迟加载的目的</param>
       /// <returns></returns>
        public virtual IQueryable<T> GetEntities<T>(Expression<Func<T, bool>> exp, bool useBaseContext=false) where T : class
        {
            if (useBaseContext)
            {
                return _dbEntities.Set<T>().Where(exp);
            }
            using (DbEntities db = new DbEntities())
            {
                return db.Set<T>().Where(exp);
            }
        }
      
       
        public virtual int GetEntitiesCount<T>(Expression<Func<T, bool>> exp) where T : class
        {
            using (DbEntities db = new DbEntities())
            {
                return db.Set<T>().Where(exp).Count();

            }
        }
      
        public virtual IQueryable<T> GetEntitiesForPaging<T>(int pageNumber, int pageSize, Expression<Func<T, string>> orderName, string sortOrder, Expression<Func<T, bool>> exp) where T : class
        {
            using (DbEntities db = new DbEntities())
            {
                if (sortOrder == "asc") //升序排列
                {
                    return db.Set<T>().Where(exp).OrderBy(orderName).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }
                else
                {
                    return db.Set<T>().Where(exp).OrderByDescending(orderName).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                }
            }

        }
        
        public virtual T GetEntity<T>(Expression<Func<T, bool>> exp) where T : class
        {
            using (DbEntities db = new DbEntities())
            {
                return db.Set<T>().Where(exp).SingleOrDefault();
            }
            
           
        }
        public virtual T GetEntityByID<T>(object ID) where T : class
        {
            using (DbEntities db = new DbEntities())
            {
                return _dbEntities.Set<T>().Find(ID);
            }
        }
        #endregion
       
        #region 增改删实现
      
        public virtual T Insert<T>(T entity) where T : class
        {
            return Insert(entity, true);
        }
        public virtual T Insert<T>(T entity, bool isSubmit) where T : class
        {
            if (isSubmit && _dbEntities==null)
            {
                using (DbEntities db = new DbEntities())
                {
                    var obj = db.Set<T>();
                    T result=obj.Add(entity);
                    db.SaveChanges();
                    return result;
                }
            }
            else
            {
                _dbEntities.Entry(entity);                
                T result= _dbEntities.Set<T>().Add(entity);
                _dbEntities.SaveChanges();
                return result;
            }
        }
       
        public virtual void Update<T>(T entity, bool isSubmit) where T : class
        {
            if (isSubmit && _dbEntities == null)
            {
                using (DbEntities db = new DbEntities())
                {
                    var obj = db.Set<T>();
                   
                    obj.Attach(entity);
                    db.Entry(entity).State = System.Data.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            else
            {
                _dbEntities.Set<T>().Attach(entity);
                _dbEntities.Entry(entity).State = System.Data.EntityState.Modified;
                _dbEntities.SaveChanges();
            }

        }
       
        public virtual void Delete<T>(T entity, bool isSubmit) where T : class
        {
            if (isSubmit && _dbEntities==null)
            {
                using (DbEntities db = new DbEntities())
                {
                    var obj = db.Set<T>();
                    if (entity != null)
                    {
                        obj.Attach(entity);
                        db.Entry(entity).State = System.Data.EntityState.Deleted;
                        obj.Remove(entity);
                        db.SaveChanges();
                    }
                    
                }
            }
            else
            {
                _dbEntities.Set<T>().Attach(entity);
                _dbEntities.Entry(entity).State = System.Data.EntityState.Deleted;
                _dbEntities.Set<T>().Remove(entity);

                _dbEntities.SaveChanges();
                
            }
        }

        #endregion
    }
}


