//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataMould
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_ProductFruits
    {
        public int ProductFruitsID { get; set; }
        public int ProductID { get; set; }
        public int FruitID { get; set; }
    
        public virtual T_Products T_Products { get; set; }
        public virtual T_Fruits T_Fruits { get; set; }
    }
}
