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
    
    public partial class Technology
    {
        public Technology()
        {
            this.CandidatesInTechnologies = new HashSet<CandidatesInTechnology>();
            this.SpecialistsInTechnologies = new HashSet<SpecialistsInTechnology>();
            this.TestsInTechnologies = new HashSet<TestsInTechnology>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<CandidatesInTechnology> CandidatesInTechnologies { get; set; }
        public virtual ICollection<SpecialistsInTechnology> SpecialistsInTechnologies { get; set; }
        public virtual ICollection<TestsInTechnology> TestsInTechnologies { get; set; }
    }
}
