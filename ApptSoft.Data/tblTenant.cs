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
    
    public partial class tblTenant
    {
        public int Id { get; set; }
        public string FlatNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string PermanentAddress { get; set; }
        public string Adharcard { get; set; }
        public string Photo { get; set; }
        public string PoliceDocumentVerification { get; set; }
        public System.DateTime RentedForm { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
