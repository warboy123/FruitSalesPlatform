﻿// <autogenerated>
//   This file was generated by T4 code generator EntitisBuild.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
namespace Entities
{
	public class T_Place
	{
		public T_Place()
		{
			this.Enabled = true;
		}		
		public int PlaceID { get; set; }
		public string PlaceName { get; set; }
		public string PlaceType { get; set; }
		public int PlaceFatherID { get; set; }
		public bool Enabled { get; set; }
		
	}
}