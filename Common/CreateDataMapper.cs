﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Entities;
using DTO;
using AutoMapper;
using System.Linq.Expressions;
namespace Common
{
	public class CreateDataMapper
	{	
        public static void InitMapper()
        {
            Mapper.CreateMap<C_ProductFruits,ProductFruitsDTO>();
            Mapper.CreateMap<ProductFruitsDTO, C_ProductFruits>();      
        
            Mapper.CreateMap<T_Fruits,FruitsDTO>();
            Mapper.CreateMap<FruitsDTO, T_Fruits>();      
        
            Mapper.CreateMap<T_Inventory,InventoryDTO>();
            Mapper.CreateMap<InventoryDTO, T_Inventory>();      
        
            Mapper.CreateMap<T_Place,PlaceDTO>();
            Mapper.CreateMap<PlaceDTO, T_Place>();      
        
            Mapper.CreateMap<T_PostAddress,PostAddressDTO>();
            Mapper.CreateMap<PostAddressDTO, T_PostAddress>();      
        
            Mapper.CreateMap<T_ProductOrders,ProductOrdersDTO>();
            Mapper.CreateMap<ProductOrdersDTO, T_ProductOrders>();      
        
            Mapper.CreateMap<T_Products,ProductsDTO>();
            Mapper.CreateMap<ProductsDTO, T_Products>();      
        
            Mapper.CreateMap<T_Stockin,StockinDTO>();
            Mapper.CreateMap<StockinDTO, T_Stockin>();      
        
            Mapper.CreateMap<T_Storage,StorageDTO>();
            Mapper.CreateMap<StorageDTO, T_Storage>();      
        
            Mapper.CreateMap<T_Supplier,SupplierDTO>();
            Mapper.CreateMap<SupplierDTO, T_Supplier>();      
        
            Mapper.CreateMap<T_SupplierFruit,SupplierFruitDTO>();
            Mapper.CreateMap<SupplierFruitDTO, T_SupplierFruit>();      
        
            Mapper.CreateMap<T_User,UserDTO>();
            Mapper.CreateMap<UserDTO, T_User>();      
        
            Mapper.CreateMap<T_UserOrders,UserOrdersDTO>();
            Mapper.CreateMap<UserOrdersDTO, T_UserOrders>();      
        
	
        }
        public static Expression<Func<TSource, TResult>> GetMappedSelector<TSource, TResult>()
        {
            Expression<Func<TSource, TResult>> mapperExpression = AutoMapper.QueryableExtensions.Extensions.CreateMapExpression<TSource, TResult>(Mapper.Engine);
            //Expression<Func<UserDTO,T_User >> mappedSelector = selector.Compose(mapper);
            return mapperExpression;
        }
        public static Expression<Func<TEntity, bool>> GetMappedCondition<TEntity, TDTO>(Expression<Func<TDTO, bool>> condition)
        {
            Expression<Func<TEntity, TDTO>> mapper = AutoMapper.QueryableExtensions.Extensions.CreateMapExpression<TEntity, TDTO>(Mapper.Engine);
            Expression<Func<TEntity, bool>> mappedSelector = condition.Compose(mapper);
            return mappedSelector;
        }
    }
}

