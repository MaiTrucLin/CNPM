//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XDPMQL_CuahangPKGaming.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class THANHTOAN
    {
        public THANHTOAN()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public string MaTToan { get; set; }
        public string MaPK { get; set; }
    
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual PHUKIEN PHUKIEN { get; set; }
    }
}