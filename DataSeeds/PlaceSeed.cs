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
	public class PlaceSeed
	{		
  
        public T_Place GetEntitySeed()
        {
            return new T_Place
                        {
                            PlaceID=RandomData.GetRandomInt(1,100),
                            PlaceName="",
                            PlaceType="",
                            PlaceFatherID=RandomData.GetRandomInt(1,100),
                            Enabled=true,
		
	                    };
        }
        public PlaceDTO GetDTOSeed()
        {
            return new PlaceDTO
                        {
                            PlaceID=RandomData.GetRandomInt(1,100),
                            PlaceName="",
                            PlaceType="",
                            PlaceFatherID=RandomData.GetRandomInt(1,100),
                            Enabled=true,
		
	                    };
        }
    }
}
