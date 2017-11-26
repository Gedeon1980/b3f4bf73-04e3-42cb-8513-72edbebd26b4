// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Role.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   The role.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The role.
    /// </summary>
    [Table("Roles")]
    public class Role
    {
        /// <summary>
        /// Gets or sets the id role.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IdRol")]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role description.
        /// </summary>
        [Column("DescripcionRol", TypeName = "varchar")]
        [StringLength(15)]
        public string RoleDescription { get; set; }
    }
}
