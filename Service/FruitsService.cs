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
    public class FruitsService : ServiceBase, IFruitsService
    { 
        private IBaseDao _dal;

        public FruitsService(IBaseDao dal)            
        {
            _dal = dal;
            

        }
        public FruitsDTO Add(FruitsDTO fruit)
        { 
           
            
            T_Fruits FruitResult = _dal.Insert<T_Fruits>(Mapper.Map<T_Fruits>(fruit));
            return Mapper.Map<FruitsDTO>(FruitResult);
        }
        public void Delete(int FruitID)
        {
            
            _dal.Update<T_Fruits>(new T_Fruits { Enabled = false }, true);
        }
        public void Renew(FruitsDTO fruit)
        {

            _dal.Update<T_Fruits>(Mapper.Map<T_Fruits>(fruit), true);
        }
        public FruitsDTO Get(int FruitID)
        {
           
            return Mapper.Map<FruitsDTO>(_dal.GetEntityByID<T_Fruits>(FruitID));
        }
        public IList<FruitsDTO> GetList()
        {
            
            return _dal.GetEntities<T_Fruits>(m => 1 == 1, true).Select(CreateDataMapper.GetMappedSelector<T_Fruits, FruitsDTO>()).ToList();  
        }
    }
}
