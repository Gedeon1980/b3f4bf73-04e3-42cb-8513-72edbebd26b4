using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.Entidades
{
    [Table("Radicado")]
    class Settled
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdRadicado { get; set; }

        [Column("NumeroProceso",TypeName = "varchar")]
        [StringLength(10)]
        public string NumeroProceso { get; set; }

        /* como agrego la relacion con company*/
        
        /* como agrego Ciclo*/

        [Column("FechaInicio",TypeName = "datetime" )]
        public DateTime FechaInicio { get; set; }   

        [Column("Fechallegada",TypeName = "datetime")]
        public DateTime Fechallegada { get; set; }

        [Column("Estado", TypeName = "char")]
        [StringLength(1)]
        public char Estado { get; set; }

        /* como agrego la responsable */


        [Column("FechaUltimaRevision", TypeName = "datetime")]
        public DateTime FechaUltimaRevision { get; set; }

        [Column("FechaFinaliza", TypeName = "datetime")]
        public DateTime FechaFechaFinaliza{ get; set; }

        [Column("FechaEntrega", TypeName = "datetime")]
        public DateTime FechaEntrega { get; set; }

        /* Falta campo persona entrega*/

        /* Falta campo persona garantia*/

        [Column("Descripcion",TypeName = "varchar")]
        [StringLength(500)]
        public string Descripcion { get; set; }


    }
}
