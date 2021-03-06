﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using IService;
using DTO;
using Entities;
using IDAL;
using Common;
namespace Service
{
	public class UserService: ServiceBase, IUserService
	{		
  
        private IBaseDao _dal;

        public UserService(IBaseDao dal)            
        {
            _dal = dal;
            

        }
        public UserDTO Add(UserDTO user)
        { 
           
            T_User FruitResult = _dal.Insert<T_User>(Mapper.Map<T_User>(user));            
            return Mapper.Map<UserDTO>(FruitResult);
        }
        public void Delete(int UserID)
        {
            _dal.Update<T_User>(new T_User { Enabled = false }, true);
        }
        public void Renew(UserDTO user)
        {
           
            _dal.Update<T_User>(Mapper.Map<T_User>(user),true);
        }
        public UserDTO Get(int UserID)
        {
           
            return Mapper.Map<UserDTO>(_dal.GetEntityByID<T_User>(UserID));
        }
        public IList<UserDTO> GetList()
        {
            
            return _dal.GetEntities<T_User>(m => 1 == 1, true).Select(CreateDataMapper.GetMappedSelector<T_User, UserDTO>()).ToList();  
        }
    }
}
