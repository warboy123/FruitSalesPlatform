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
	public class StorageSeed
	{		
  
        public T_Storage GetEntitySeed()
        {
            return new T_Storage
                        {
                            StorageID=RandomData.GetRandomInt(1,100),
                            PlaceID=RandomData.GetRandomInt(1,100),
                            Address="",
                            Enabled=true,
                            FruitID=RandomData.GetRandomInt(1,100),
		
	                    };
        }
        public StorageDTO GetDTOSeed()
        {
            return new StorageDTO
                        {
                            StorageID=RandomData.GetRandomInt(1,100),
                            PlaceID=RandomData.GetRandomInt(1,100),
                            Address="",
                            Enabled=true,
                            FruitID=RandomData.GetRandomInt(1,100),
		
	                    };
        }
    }
}
