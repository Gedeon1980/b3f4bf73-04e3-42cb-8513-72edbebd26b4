// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Team.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   The team.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The team.
    /// </summary>
    [Table("Equipo")]
    public class Team
    {
        /// <summary>
        /// Gets or sets the team id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdEquipo")]
        public Guid TeamId { get; set; }

        /// <summary>
        /// Gets or sets the settled id.
        /// </summary>
        [Column("IdRadicado")]
        public Guid SettledId { get; set; }

        /// <summary>
        /// Gets or sets the settled.
        /// </summary>
        [ForeignKey("SettledId")]
        public Settled Settled { get; set; }

        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        [Column("EmpleadoId")]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
