//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CashOuts
    {
        public int Id { get; set; }
        public System.Guid UserId { get; set; }
        public double Value { get; set; }
        public System.DateTime WhenDate { get; set; }
        public string Sposob { get; set; }
        public Nullable<System.DateTime> WhenAdminEvent { get; set; }
        public int State { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }
        public int Type { get; set; }
        public string PaymentNumber { get; set; }
        public int Result { get; set; }
    }
}
