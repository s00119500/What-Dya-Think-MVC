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
    public class SurveyAppContext : DbContext
    {
        /// connection string
        public SurveyAppContext()
            : base("SurveyAppContext") 
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