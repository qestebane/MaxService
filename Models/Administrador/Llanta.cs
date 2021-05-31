using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_Llanta")]
    public class Llanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("LlantaId")] //PK
        public int LlantaId { get; set; }

        [Column("Precio")]
        public double Precio { get; set; }

        [Column("Stock")]
        public int Stock { get; set; }

        [ForeignKey("DetalleLlantaId_fk")]
        public int DetalleLlantaId { get; set; }
        [ForeignKey("VehiculoId_fk")]
        public int VehiculoId { get; set; }

        public virtual DetalleLlanta DetalleLlanta{get; set;}
        public virtual Vehiculo Vehiculo{get; set;}
    }
}