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
    
    public partial class T_Stockin
    {
        public int StockinID { get; set; }
        public string FruitID { get; set; }
        public decimal count { get; set; }
        public System.DateTime datecreate { get; set; }
        public string StorageID { get; set; }
        public int PlaceID { get; set; }
        public string DeliverAddress { get; set; }
        public System.DateTime dateStockin { get; set; }
        public string status { get; set; }
        public Nullable<int> SupplierID { get; set; }
    
        public virtual T_Fruits T_Fruits { get; set; }
    }
}
