using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNovedades.Model.Entidades
{
    [Table("Incidentes")]
    class Incidents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdIncidentes { get; set; }
        
        /*Enlace Proceso*/

        [Column("Fechallegada", TypeName = "datetime")]
        public DateTime Fechallegada { get; set; }


        [Column ("FechaTraslado",TypeName = "datetime")]
        public DateTime FechaTraslado { get; set; }


        [Column("FechaSolucion", TypeName = "datetime")]
        public DateTime FechaSolucion { get; set; }

        /* Adjuntos */


    }
}
