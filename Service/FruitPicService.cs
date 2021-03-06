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
	public class FruitPicService: ServiceBase, IFruitPicService
	{		
  
        private IBaseDao _dal;

        public FruitPicService(IBaseDao dal)            
        {
            _dal = dal;
            

        }
        public FruitPicDTO Add(FruitPicDTO fruitpic)
        { 
           
            T_FruitPic FruitResult = _dal.Insert<T_FruitPic>(Mapper.Map<T_FruitPic>(fruitpic));            
            return Mapper.Map<FruitPicDTO>(FruitResult);
        }
        public void Delete(int FruitPicID)
        {
            _dal.Delete<T_FruitPic>(new T_FruitPic { FruitPicID = FruitPicID }, true);
        }
        public void Renew(FruitPicDTO fruitpic)
        {
           
            _dal.Update<T_FruitPic>(Mapper.Map<T_FruitPic>(fruitpic),true);
        }
        public FruitPicDTO Get(int FruitPicID)
        {
           
            return Mapper.Map<FruitPicDTO>(_dal.GetEntityByID<T_FruitPic>(FruitPicID));
        }
        public IList<FruitPicDTO> GetList()
        {
            
            return _dal.GetEntities<T_FruitPic>(m => 1 == 1, true).Select(CreateDataMapper.GetMappedSelector<T_FruitPic, FruitPicDTO>()).ToList();  
        }
    }
}
