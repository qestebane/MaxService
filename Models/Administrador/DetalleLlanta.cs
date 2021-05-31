using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_DetalleLlanta")]
    public class DetalleLlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("DetalleLlantaId")] //PK
        public int DetalleLlantaId { get; set; }

        [Column("IndiceCarga")]
        public int IndiceCarga { get; set; }

        [Column("IndiceVelocidad")]
        public char IndiceVelocidad { get; set; }

        [Column("FotoLlanta")]
        public string FotoLlanta { get; set; }

        [Column("Construccion")]
        public char Construccion { get; set; }

        [Column("PresionMaxima")]
        public string PresionMaxima { get; set; }

        [Column("LimiteCarga")]
        public string LimiteCarga { get; set; }

        [Column("Clasificacion")]
        public string Clasificacion { get; set; }

        [Column("CodigoUTQG")]
        public string CodigoUTQG { get; set; }

        [Column("FechaFabricacion")]
        public string FechaFabricacion { get; set; }

        [ForeignKey("MedidaLlantaId_fk")]
        public int MedidaLlantaId { get; set; }
        
        [ForeignKey("MarcaLlantaId_fk")]
        public int MarcaLlantaId { get; set; }

        public virtual MedidaLlanta MedidaLlanta{get; set;}

        public virtual MarcaLlanta MarcaLlanta{get; set;}
    }
}