﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NiceStore
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NiceStoreDBEntities : DbContext
    {
        public NiceStoreDBEntities()
            : base("name=NiceStoreDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CartTB> CartTBs { get; set; }
        public virtual DbSet<CustomerTB> CustomerTBs { get; set; }
        public virtual DbSet<FactorTB> FactorTBs { get; set; }
        public virtual DbSet<PhoneTB> PhoneTBs { get; set; }
        public virtual DbSet<SCP> SCPs { get; set; }
        public virtual DbSet<ToolsTB> ToolsTBs { get; set; }
    }
}