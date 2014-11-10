using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WpcabAdministration.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDbConnectionString")
        {

        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Relative> Relatives { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<PoliceStation> PoliceStations { get; set; }

        public DbSet<PostOffice> PostOffices { get; set; }

        public DbSet<Village> Villages { get; set; }

        public DbSet<Zone> Zones { get; set; }
    }
}