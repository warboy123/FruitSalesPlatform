using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entities;
using System.Data.Objects;
using System.Data.Entity.ModelConfiguration.Conventions;
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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //throw new UnintentionalCodeFirstException();
        }

        public DbSet<T_User> T_User { get; set; }
        public DbSet<T_Products> T_Products { get; set; }
        public DbSet<T_Fruits> T_Fruits { get; set; }
        public DbSet<T_UserOrders> T_ProductOrder { get; set; }
        public DbSet<T_ProductOrders> T_ProductOrders { get; set; }
        public DbSet<T_Place> T_Place { get; set; }
        public DbSet<T_PostAddress> T_PostAddress { get; set; }
        public DbSet<C_ProductFruits> C_ProductFruitS { get; set; }
        public DbSet<T_Inventory> T_Inventory { get; set; }
        public DbSet<T_Stockin> T_Warehousing { get; set; }
        public DbSet<T_Storage> T_Storage { get; set; }
        public DbSet<T_Supplier> T_Supplier { get; set; }
        public DbSet<T_SupplierFruit> T_SupplierFruit { get; set; }
    }
}
