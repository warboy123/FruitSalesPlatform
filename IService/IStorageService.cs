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
	public interface IStorageService
	{		
        StorageDTO Add(StorageDTO storage);
        void Delete(int StorageID);
        void Renew(StorageDTO storage);
        StorageDTO Get(int StorageID);
        IList<StorageDTO> GetList();
    }
}
