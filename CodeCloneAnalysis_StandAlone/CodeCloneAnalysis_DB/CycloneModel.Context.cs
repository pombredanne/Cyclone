﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeCloneAnalysis_DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cycloneEntities : DbContext
    {
        public cycloneEntities()
            : base("name=cycloneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<clone_class> clone_class { get; set; }
        public DbSet<clone_fragment> clone_fragment { get; set; }
        public DbSet<clones_modified_users> clones_modified_users { get; set; }
        public DbSet<source> sources { get; set; }
        public DbSet<source_analyzer> source_analyzer { get; set; }
        public DbSet<source_file> source_file { get; set; }
        public DbSet<time_intervals> time_intervals { get; set; }
        public DbSet<webhook> webhooks { get; set; }
        public DbSet<webhook_commits> webhook_commits { get; set; }
        public DbSet<webhook_files> webhook_files { get; set; }
    }
}
