﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebHookManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbd63c48f65aad4276b507a55c00bad8ffEntities : DbContext
    {
        public dbd63c48f65aad4276b507a55c00bad8ffEntities()
            : base("name=dbd63c48f65aad4276b507a55c00bad8ffEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<webHook> webHooks { get; set; }
        public virtual DbSet<webHookCommit> webHookCommits { get; set; }
        public virtual DbSet<webHookFile> webHookFiles { get; set; }
    }
}
