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
    
    public partial class T_ProductOrders
    {
        public int ProductOrdersID { get; set; }
        public int Count { get; set; }
        public int UserOrdersID { get; set; }
        public int ProductID { get; set; }
    
        public virtual T_UserOrders T_UserOrders { get; set; }
    }
}