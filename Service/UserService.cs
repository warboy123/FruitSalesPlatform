using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IDAL;
using IService;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DTO;
using Common;
namespace Service
{
   
    public class UserService :ServiceBase, IUserService
    {
      
        private IBaseDao _dal;
        
        public UserService(IBaseDao dal)            
        {
            _dal = dal;
            

        }
        public T_User Get(Expression<Func<T_User, bool>> exp)
        {
            return _dal.GetEntity<T_User>(exp);
        }


        public IEnumerable<UserDTO> GetList()
        {
            Mapper.CreateMap<T_User,UserDTO>();

            return _dal.GetEntities<T_User>(m =>1 == 1, true).Select( GetMappedSelector<T_User,UserDTO>()).ToList();                   
        }

       
        public IEnumerable<T_User> GetAll()
        {
           
                return from a in _dal.GetEntities<T_User>(m => 1 == 1,true)
                       
                       select a;
         }
        public bool Add(UserDTO user)
        {
            try
            {                
                _dal.BeginTransaction();
                T_User UserEntity = new T_User { Birthday = DateTime.Now, UserName = user.UserName };
                _dal.Insert<T_User>(UserEntity,false);

                _dal.CommitTransaction();
            }
            catch 
            {
                _dal.RollbackTransaction();

            }
            return true;
        }
        public void Update(UserDTO user)
        {
            try
            {
                _dal.BeginTransaction();
                T_User UserEntity = new T_User { Birthday = DateTime.Now, UserName = user.UserName,UserID=user.UserID };
                _dal.Update<T_User>(UserEntity, false);
                _dal.CommitTransaction();
            }
            catch
            {
                _dal.RollbackTransaction();

            }
            
        }
    }
}
