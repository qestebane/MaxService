using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_MedidaLlanta")]
    public class MedidaLlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("MedidaLlantaId")] //PK
        public int MedidaLlantaId { get; set; }

        [Column("Ancho")]
        public int Ancho { get; set; }

        [Column("Diametro")]
        public int Diametro { get; set; }

        [Column("Perfil")]
        public int Perfil { get; set; }

    }
}