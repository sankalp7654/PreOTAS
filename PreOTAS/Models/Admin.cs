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
    
    public partial class Admin
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Dept { get; set; }
        public string Roles { get; set; }
    
        public virtual DEPT DEPT1 { get; set; }
    }
}
