using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospitals.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Hospitals.DAL
{
    public class HospitalContext : DbContext
    {

            public HospitalContext() : base("HospitalContext")
            {
            }

            public DbSet<Hospital> Hospitals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) => modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}