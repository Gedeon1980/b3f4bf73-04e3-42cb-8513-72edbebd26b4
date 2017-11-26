// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Company.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   Defines the Company type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The company.
    /// </summary>
    [Table("Companias")]
    public class Company
    {
        /// <summary>
        /// Gets or sets the id company.
        /// </summary>
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the company id.
        /// </summary>
        [Column("IdentificacionCompania", TypeName = "varchar")]
        [StringLength(10)]
        public string CompanyIdentification { get; set; }

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        [Column("NombreCompania", TypeName = "varchar")]
        [StringLength(70)]
        public string CompanyName { get; set; }
    }
}
