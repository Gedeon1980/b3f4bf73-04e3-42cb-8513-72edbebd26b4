

namespace GestionNovedades.Model.Entidades
{
    using System.Data.Entity;

    public class GIOContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Settled> Problems { set; get; }


        public GIOContext(): base("GIOContext") 
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
