﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Entities
{
    /// <summary>
    /// T_Place
    /// </summary>
	public class T_Place
	{
		public T_Place()
		{
			this.Enabled = true;
		}		
        /// <summary>
        /// 地点ID
        /// </summary>
        [Key]               
        [Required(ErrorMessage="值不能为空")]
		public int PlaceID { get; set; }
        /// <summary>
        /// 地点名称
        /// </summary>
    
        [MaxLength(200)]
        [Required(ErrorMessage="值不能为空")]
		public string PlaceName { get; set; }
        /// <summary>
        /// 地点类型
        /// </summary>
    
        [MaxLength()]
        [Required(ErrorMessage="值不能为空")]
		public string PlaceType { get; set; }
        /// <summary>
        /// 父节点ID
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public int PlaceFatherID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage="值不能为空")]
		public bool Enabled { get; set; }
		
	}
}
