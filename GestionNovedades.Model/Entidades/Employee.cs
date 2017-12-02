// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="OPA SAS">
//   All Rights Reserved
// </copyright>
// <summary>
//   The employee.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The employee.
    /// </summary>
    [Table("Empleados")]
    public class Employee
    {
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EmpleadoId")]
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the employee identification.
        /// </summary>
        [Column("IdentificacionEmpleado", TypeName = "varchar")]
        [StringLength(20)]
        public string EmployeeIdentification { get; set; }

        /// <summary>
        /// Gets or sets the employee name.
        /// </summary>
        [Column("NombreCompleto", TypeName = "varchar")]
        [StringLength(200)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the employee role id.
        /// </summary>
        [Column("IdRole")]
        public Guid EmployeeRoleId { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        [ForeignKey("EmployeeRoleId")]
        public Role Role { get; set; }
    }
}
