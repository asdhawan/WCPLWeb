//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCPLWebEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player_SpecialEvent
    {
        public int PlayerId { get; set; }
        public int SpecialEventId { get; set; }
        public bool PaidYN { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual SpecialEvent SpecialEvent { get; set; }
    }
}