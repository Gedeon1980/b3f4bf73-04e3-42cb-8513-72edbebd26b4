

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Incidentes")]
   public  class Incidents
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
