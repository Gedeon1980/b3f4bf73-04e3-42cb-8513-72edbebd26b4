// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GIOContext.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the GIOContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Entidades
{
    using System.Data.Entity;

    using GestionNovedades.Model.Migrations;

    /// <summary>
    /// The gio context.
    /// </summary>
    public class GioContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GioContext"/> class.
        /// </summary>
        public GioContext()
            : base("GioContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GioContext, Configuration>("GioContext"));
        }

        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the problems.
        /// </summary>
        public DbSet<Settled> Problems { get; set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        public DbSet<Team> Teams { get; set; }

        /// <summary>
        /// Gets or sets the incidents.
        /// </summary>
        public DbSet<Incidents> Incidents { get; set; }

        /// <summary>
        /// Gets or sets the Roles.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
