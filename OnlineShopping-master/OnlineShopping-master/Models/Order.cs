//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public string Quantity { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual Login Login { get; set; }
        public virtual Product Product { get; set; }
    }
}