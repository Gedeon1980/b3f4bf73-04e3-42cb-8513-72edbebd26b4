

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
        public Guid IdCompania { set; get; }

        [Column("IdentificacionCompania", TypeName = "varchar")]
        [StringLength(10)]
        public string CompaniaId { set; get; }

        [Column("NombreCompania", TypeName = "varchar")]
        [StringLength(70)]
        public string NombreCompania { set; get; }

    }
}
