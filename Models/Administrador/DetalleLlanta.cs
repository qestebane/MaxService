using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_DetalleLlanta")]
    public class DetalleLlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("DetalleLlantaId")] //PK
        public int DetalleLlantaId { get; set; }

        [Required]
        [Column("NombreMarca")]
        public string NombreMarca { get; set; }

        [Required]
        [Column("IndiceCarga")]
        public int IndiceCarga { get; set; }

        [Required]
        [Column("IndiceVelocidad")]
        public string IndiceVelocidad { get; set; }

        [Required]
        [Column("FotoLlanta")]
        public string FotoLlanta { get; set; }

        [Required]
        [Column("Construccion")]
        public string Construccion { get; set; }

        [Required]
        [Column("PresionMaxima")]
        public string PresionMaxima { get; set; }

        [Required]
        [Column("Clasificacion")]
        public string Clasificacion { get; set; }

        [Required]
        [Column("FechaFabricacion")]
        public string FechaFabricacion { get; set; }

        [Required]
        [ForeignKey("MedidaLlantaId_fk")]
        public int MedidaLlantaId { get; set; }

        public virtual MedidaLlanta MedidaLlanta{get; set;}
    }
}