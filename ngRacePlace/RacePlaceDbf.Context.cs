﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ngRacePlace
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RacePlaceDbfEntities : DbContext
    {
        public RacePlaceDbfEntities()
            : base("name=RacePlaceDbfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public virtual DbSet<Entrant> Entrants { get; set; }
        public virtual DbSet<EntrantEvent> EntrantEvents { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<IndividualResult> IndividualResults { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<RaceDetail> RaceDetails { get; set; }
        public virtual DbSet<RaceGroup> RaceGroups { get; set; }
        public virtual DbSet<RaceResult> RaceResults { get; set; }
    
        public virtual int uspLogError(ObjectParameter errorLogID)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspLogError", errorLogID);
        }
    
        public virtual int uspPrintError()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspPrintError");
        }
    }
}