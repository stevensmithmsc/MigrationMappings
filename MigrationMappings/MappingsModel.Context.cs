﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MigrationMappings
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MappingsDBContext : DbContext
    {
        public MappingsDBContext()
            : base("name=MappingsDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Map> Maps { get; set; }
        public virtual DbSet<RefArea> RefAreas { get; set; }
        public virtual DbSet<RefVal> RefVals { get; set; }
    }
}
