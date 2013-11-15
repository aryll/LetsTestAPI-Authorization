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
    
    public partial class Test
    {
        public Test()
        {
            this.Instances = new HashSet<Instance>();
            this.Questions = new HashSet<Question>();
            this.TestsInTechnologies = new HashSet<TestsInTechnology>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int SpecialistID { get; set; }
        public string Comments { get; set; }
        public int Time { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<Instance> Instances { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TestsInTechnology> TestsInTechnologies { get; set; }
    }
}