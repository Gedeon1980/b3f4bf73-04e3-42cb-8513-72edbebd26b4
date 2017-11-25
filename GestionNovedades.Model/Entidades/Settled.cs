

namespace GestionNovedades.Model.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    [Table("Radicado")]
    public class Settled
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdRadicado { set; get; }

        [Column("NumeroProceso",TypeName = "varchar")]
        [StringLength(10)]
        public string NumeroProceso { set; get; }

        [Column ("IdCompania")]
        public Guid IdCompaniaReporta { set; get; }
        [ForeignKey("IdCompaniaReporta")]
        public Company CompaniaReporta { set; get; }
        
        [Column("IdRequisitos")]
        public Guid IdRequisitos { set; get; }
        [ForeignKey("IdRequisitos")]
        public Employee Requisitos { set; get; }


        [Column("IdDesarrollo")]
        public Guid IdDesarrollo { set; get; }
        [ForeignKey("IdDesarrollo")]
        public Employee Desarrollo { set; get; }


        [Column("IdCalidad")]
        public Guid IdCalidad { set; get; }
        [ForeignKey("IdCalidad")]
        public Employee Calidad { set; get; }

        [Column("IdEntrega")]
        public Guid IdEntrega { set; get; }
        [ForeignKey("IdEntrega")]
        public Employee Entrega { set; get; }

        [Column("FechaInicio",TypeName = "smalldatetime" )]
        public DateTime FechaInicio { set; get; }   

        [Column("Fechallegada",TypeName = "smalldatetime")]
        public DateTime Fechallegada { set; get; }

        [Column("Estado", TypeName = "char")]
        [StringLength(1)]
        public char Estado { set; get; }

        /* como agrego la responsable */


        [Column("FechaUltimaRevision", TypeName = "smalldatetime")]
        public DateTime FechaUltimaRevision { set; get; }

        [Column("FechaFinaliza", TypeName = "smalldatetime")]
        public DateTime FechaFechaFinaliza{ set; get; }

        [Column("FechaEntrega", TypeName = "smalldatetime")]
        public DateTime FechaEntrega { set; get; }

        /* Falta campo persona entrega*/

        /* Falta campo persona garantia*/

        [Column("Descripcion",TypeName = "varchar")]
        [StringLength(500)]
        public string Descripcion { set; get; }


    }
}
