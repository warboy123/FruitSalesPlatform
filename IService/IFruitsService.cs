﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Entities;
namespace IService
{
	public interface IFruitsService
	{		
        FruitsDTO Add(FruitsDTO fruits);
        void Delete(int FruitsID);
        void Renew(FruitsDTO fruits);
        FruitsDTO Get(int FruitsID);
        IList<FruitsDTO> GetList();
    }
}
