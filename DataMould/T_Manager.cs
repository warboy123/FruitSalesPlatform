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
    
    public partial class T_Manager
    {
        public T_Manager()
        {
            this.Enabled = true;
            this.T_ManagerPermission = new HashSet<T_ManagerPermission>();
        }
    
        public int ManagerID { get; set; }
        public string LoginNum { get; set; }
        public string PassWord { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime DateCreate { get; set; }
    
        public virtual ICollection<T_ManagerPermission> T_ManagerPermission { get; set; }
    }
}
