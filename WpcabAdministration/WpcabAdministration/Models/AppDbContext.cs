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

        public System.Data.Entity.DbSet<WpcabAdministration.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<WpcabAdministration.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<WpcabAdministration.Models.District> Districts { get; set; }

        public System.Data.Entity.DbSet<WpcabAdministration.Models.PoliceStation> PoliceStations { get; set; }

        public System.Data.Entity.DbSet<WpcabAdministration.Models.PostOffice> PostOffices { get; set; }

        public System.Data.Entity.DbSet<WpcabAdministration.Models.Village> Villages { get; set; }

        public System.Data.Entity.DbSet<WpcabAdministration.Models.Zone> Zones { get; set; }
    }
}