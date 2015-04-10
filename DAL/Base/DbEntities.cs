using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entities;
using System.Data.Objects;
namespace DAL
{
    public partial class DbEntities : DbContext
    {
        //默认的构造函数
        //public DbEntities()  : base("name=DbEntities")
        //{           
        //}

        /// <summary>
        /// 动态的构造函数
        /// </summary>
        public DbEntities()
            : base(nameOrConnectionString: ConnectionString())
        {
            
           
        }
         
        /// <summary>
        /// 通过代码方式，获取连接字符串的名称返回。
        /// </summary>
        /// <returns></returns>
        private static string ConnectionString()
        {
            //根据不同的数据库类型，构造相应的连接字符串名称

            string dbType = System.Configuration.ConfigurationManager.AppSettings["dbType"].ToString();
            if (string.IsNullOrEmpty(dbType))
            {
                dbType = "sqlserver";
            }

            return string.Format("name={0}", dbType.ToLower());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        
        public DbSet<T_User> T_User { get; set; }
    }
}
