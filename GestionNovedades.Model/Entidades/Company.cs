

namespace GestionNovedades.Model.Entidades
{

    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    [Table("Companias")]
    public class Company
    {

        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid IdCompanias { get; set; }

        [Column("IdentificacionCompania", TypeName = "varchar")]
        [StringLength(10)]
        public string CompaniaId { get; set; }

        [Column("NombreCompania", TypeName = "varchar")]
        [StringLength(70)]
        public string NombreCompania { get; set; }

    }
}
