﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Entities;
using DTO;
using Common;
namespace DataSeeds
{
	public class UserOrdersSeed
	{		
  
        public T_UserOrders GetEntitySeed()
        {
            return new T_UserOrders
                        {
                            UserOrdersID=RandomData.GetRandomInt(1,100),
                            DateCreate=RandomData.GetRadomTime(),
                            Amount=0,
                            SaleAmount=0,
                            OrderStatus=0,
                            LogisticsNum="",
                            DatePay=RandomData.GetRadomTime(),
                            DateConfirm=RandomData.GetRadomTime(),
                            UserID=RandomData.GetRandomInt(1,100),
                            Enabled=true,
                            postage=0,
		
	                    };
        }
        public UserOrdersDTO GetDTOSeed()
        {
            return new UserOrdersDTO
                        {
                            UserOrdersID=RandomData.GetRandomInt(1,100),
                            DateCreate=RandomData.GetRadomTime(),
                            Amount=0,
                            SaleAmount=0,
                            OrderStatus=0,
                            LogisticsNum="",
                            DatePay=RandomData.GetRadomTime(),
                            DateConfirm=RandomData.GetRadomTime(),
                            UserID=RandomData.GetRandomInt(1,100),
                            Enabled=true,
                            postage=0,
		
	                    };
        }
    }
}
