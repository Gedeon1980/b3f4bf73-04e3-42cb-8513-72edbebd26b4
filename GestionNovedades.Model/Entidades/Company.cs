using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.Entidades
{
     [Table("Companias")]
    class Company
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
