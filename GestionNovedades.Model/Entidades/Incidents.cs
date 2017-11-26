// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Incidents.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the Incidents type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The incidents.
    /// </summary>
    [Table("Incidentes")]
    public class Incidents
    {
        /// <summary>
        /// Gets or sets the incident id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdIncidentes")]
        public Guid IncidentId { get; set; }

        /// <summary>
        /// Gets or sets the incident start.
        /// </summary>
        [Column("Fechallegada", TypeName = "datetime")]
        public DateTime IncidentStart { get; set; }

        /// <summary>
        /// Gets or sets the incident moved.
        /// </summary>
        [Column("FechaTraslado", TypeName = "datetime")]
        public DateTime IncidentMoved { get; set; }

        /// <summary>
        /// Gets or sets the incident solved.
        /// </summary>
        [Column("FechaSolucion", TypeName = "datetime")]
        public DateTime IncidentSolved { get; set; }
    }
}
