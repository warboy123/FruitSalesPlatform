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
	public class SupplierFruitSeed
	{		
  
        public T_SupplierFruit GetEntitySeed()
        {
            return new T_SupplierFruit
                        {
                            SupplierFruitID=RandomData.GetRandomInt(1,100),
                            FruitID=RandomData.GetRandomInt(1,100),
                            Enabled=true,
		
	                    };
        }
        public SupplierFruitDTO GetDTOSeed()
        {
            return new SupplierFruitDTO
                        {
                            SupplierFruitID=RandomData.GetRandomInt(1,100),
                            FruitID=RandomData.GetRandomInt(1,100),
                            Enabled=true,
		
	                    };
        }
    }
}
