﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LetsTestEntities : DbContext
    {
        public LetsTestEntities()
            : base("name=LetsTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Language> Languages { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Instance> Instances { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestsInTechnology> TestsInTechnologies { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidatesInLanguage> CandidatesInLanguages { get; set; }
        public DbSet<CandidatesInTechnology> CandidatesInTechnologies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<SpecialistsInTechnology> SpecialistsInTechnologies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersInRole> UsersInRoles { get; set; }
    }
}