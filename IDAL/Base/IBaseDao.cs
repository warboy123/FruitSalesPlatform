using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IBaseDao
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        
        
         #region 查询普通实现方案(基于Lambda表达式的Where查询)

        IQueryable<T> GetEntities<T>(Expression<Func<T, bool>> exp, bool useBaseContext) where T : class;
        
       
        int GetEntitiesCount<T>(Expression<Func<T, bool>> exp) where T : class;
 
        IQueryable<T> GetEntitiesForPaging<T>(int pageNumber, int pageSize, Expression<Func<T, string>> orderName, string sortOrder, Expression<Func<T, bool>> exp) where T : class;
 
      
        T GetEntity<T>(Expression<Func<T, bool>> exp) where T : class;
        T GetEntityByID<T>(object ID)where T : class;
         #endregion
 
        

        T Insert<T>(T entity) where T : class;
        T Insert<T>(T entity, bool isSubmit) where T : class;
        
        void Update<T>(T entity, bool isSubmit) where T : class;
        
        void Delete<T>(T entity, bool isSubmit) where T : class;
         
     }
}
