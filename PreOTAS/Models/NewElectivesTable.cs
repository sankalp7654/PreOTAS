//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreOTAS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewElectivesTable
    {
        public string USN { get; set; }
        public string SubCode { get; set; }
        public int id { get; set; }
        public Nullable<bool> isValid { get; set; }
    
        public virtual Subject Subject { get; set; }
        public virtual STUDENT STUDENT { get; set; }
    }
}
