﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using BE;
    
    public partial class ExamPlanningSystemSDMEntities1 : DbContext
    {
        public ExamPlanningSystemSDMEntities1()
            : base("name=ExamPlanningSystemSDMEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Censor> Censor { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
    }
}
