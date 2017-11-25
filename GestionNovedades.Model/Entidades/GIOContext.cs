using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.Entidades
{
    class GIOContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Settled> Problems { set; get; }


        public GIOContext(): base("GIOContext") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GIOContext, Configuration>("GIOContext"));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
