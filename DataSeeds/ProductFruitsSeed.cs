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
	public class ProductFruitsSeed
	{		
  
        public C_ProductFruits GetEntitySeed()
        {
            return new C_ProductFruits
                        {
                            ProductFruitsID=RandomData.GetRandomInt(1,100),
                            ProductID=RandomData.GetRandomInt(1,100),
                            FruitID=RandomData.GetRandomInt(1,100),
		
	                    };
        }
        public ProductFruitsDTO GetDTOSeed()
        {
            return new ProductFruitsDTO
                        {
                            ProductFruitsID=RandomData.GetRandomInt(1,100),
                            ProductID=RandomData.GetRandomInt(1,100),
                            FruitID=RandomData.GetRandomInt(1,100),
		
	                    };
        }
    }
}
