using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WhatDyaThink.Models;

namespace WhatDyaThink.DAL
{
    /// <summary>
    /// Context Class tells us whats in the data model
    /// </summary>
    public class SurveyContext : DbContext
    {
        /// connection string
        public SurveyContext()
            : base("SurveyContext")
        { }

        public DbSet<Survey> Survey { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Responces> Responces { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Registration> Registration { get; set; }

        /// pluralize tables
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}