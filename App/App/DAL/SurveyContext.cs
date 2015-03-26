using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using App.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace App.DAL
{
    /// <summary>
    /// Context class tells us whats in the data model
    /// </summary>
    public class SurveyContext : DbContext
    {
        /// connection string
        public SurveyContext()
            : base("myConnectionString") 
        { }

        /// tables from models
        
        /// login and register
        public DbSet<Login> Login { get; set; }
        public DbSet<Register> Register { get; set; }



        /// pluralize tables
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}