

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
        public Guid IdEmpleados { get; set; }

        [Column("Identificacion",TypeName = "varchar")]
        [StringLength(20)]
        public string Identificacion { get; set; }

        [Column("NombreCompleto", TypeName = "varchar")]
        [StringLength(200)]
        public string NombreCompleto { get; set; }

        /* como le agregamos el rol*/

    }
}
