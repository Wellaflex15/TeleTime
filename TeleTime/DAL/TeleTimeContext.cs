using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TeleTime.Models;

namespace TeleTime.DAL
{
    public class TeleTimeContext : DbContext
    {
        public TeleTimeContext() : base("TeleTimeContext")
        {
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}