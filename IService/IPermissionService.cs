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
	public interface IPermissionService
	{		
        PermissionDTO Add(PermissionDTO permission);
        void Delete(int PermissionID);
        void Renew(PermissionDTO permission);
        PermissionDTO Get(int PermissionID);
        IList<PermissionDTO> GetList();
    }
}
