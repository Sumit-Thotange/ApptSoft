//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApptSoft.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExpens
    {
        public int Id { get; set; }
        public string FlatNo { get; set; }
        public string Title { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public Nullable<decimal> PaidAmount { get; set; }
        public string PaidBy { get; set; }
        public string PaymentMode { get; set; }
        public string TransactionNo { get; set; }
        public string Receipt { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
