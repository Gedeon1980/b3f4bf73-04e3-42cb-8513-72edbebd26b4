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
        }

        /// <summary>
        /// Gets or sets the companies.
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the problems.
        /// </summary>
        public DbSet<Settled> Problems { get; set; }
    }
}
