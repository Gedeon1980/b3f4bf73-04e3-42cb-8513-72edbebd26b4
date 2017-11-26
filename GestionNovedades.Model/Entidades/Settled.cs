// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Settled.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the Settled type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The settled.
    /// </summary>
    [Table("Radicado")]
    public class Settled
    {
        /// <summary>
        /// Gets or sets the settled id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdRadicado")]
        public Guid SettledId { get; set; }

        /// <summary>
        /// Gets or sets the settled number.
        /// </summary>
        [Column("NumeroProceso", TypeName = "varchar")]
        [StringLength(10)]
        public string SettledNumber { get; set; }

        /// <summary>
        /// Gets or sets the company report id.
        /// </summary>
        [Column("IdCompaniaReporta")]
        public Guid CompanyReportId { get; set; }

        /// <summary>
        /// Gets or sets the company report.
        /// </summary>
        [ForeignKey("IdCompaniaReporta")]
        public Company CompanyReport { get; set; }

        /// <summary>
        /// Gets or sets the settled start.
        /// </summary>
        [Column("FechaInicio", TypeName = "smalldatetime")]
        public DateTime SettledStart { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [Column("Estado")]
        public byte State { get; set; }

        /// <summary>
        /// Gets or sets the settled last revision.
        /// </summary>
        [Column("FechaUltimaRevision", TypeName = "smalldatetime")]
        public DateTime SettledLastRevision { get; set; }

        /// <summary>
        /// Gets or sets the setled end.
        /// </summary>
        [Column("FechaFinaliza", TypeName = "smalldatetime")]
        public DateTime SettledEnd { get; set; }

        /// <summary>
        /// Gets or sets the settled deliver date.
        /// </summary>
        [Column("FechaEntrega", TypeName = "smalldatetime")]
        public DateTime SettledDeliver { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Column("Descripcion", TypeName = "varchar")]
        [StringLength(500)]
        public string Description { get; set; }

        /*
        [Column("IdRequisitos")]
        public Guid IdRequisitos { get; set; }

        [ForeignKey("IdRequisitos")]
        public Employee Requisitos { get; set; }

        [Column("IdDesarrollo")]
        public Guid IdDesarrollo { get; set; }

        [ForeignKey("IdDesarrollo")]
        public Employee Desarrollo { get; set; }

        [Column("IdCalidad")]
        public Guid IdCalidad { get; set; }

        [ForeignKey("IdCalidad")]
        public Employee Calidad { get; set; }

        [Column("IdEntrega")]
        public Guid IdEntrega { get; set; }

        [ForeignKey("IdEntrega")]
        public Employee Entrega { get; set; }
        */
    }
}
