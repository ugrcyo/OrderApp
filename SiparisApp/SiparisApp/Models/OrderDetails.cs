//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiparisApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetails
    {
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> CurrencyCode { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> UnitPriceID { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Items Items { get; set; }
        public virtual Items Items1 { get; set; }
        public virtual Order Order { get; set; }
    }
}
