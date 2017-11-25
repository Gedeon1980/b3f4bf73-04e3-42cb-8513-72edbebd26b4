

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    [Table ("Empleados")]
    public class Employee
    {

        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid IdEmpleado { set; get; }

        [Column("Identificacion",TypeName = "varchar")]
        [StringLength(20)]
        public string Identificacion { set; get; }

        [Column("NombreCompleto", TypeName = "varchar")]
        [StringLength(200)]
        public string NombreCompleto { set; get; }
        
        [Column("IdRole")]
        public Guid IdRolEmpelado { set; get; }
        [ForeignKey("IdRolEmpelado")]
        public Role Rol { set; get; }
    }
}
