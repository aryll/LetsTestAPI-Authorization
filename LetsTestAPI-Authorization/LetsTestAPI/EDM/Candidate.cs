//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LetsTestAPI.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Adress { get; set; }
        public string Schools { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
        public string Courses { get; set; }
        public string Remarks { get; set; }
        public bool IsRecruitmentOpened { get; set; }
        public bool IsActive { get; set; }
    
        public virtual User User { get; set; }
    }
}
