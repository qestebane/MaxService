using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_MedidaLlanta")]
    public class MedidaLlanta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("MedidaLlantaId")] //PK
        public int MedidaLlantaId { get; set; }

        [Required]
        [Column("Ancho")]
        public int Ancho { get; set; }

        [Required]
        [Column("Diametro")]
        public int Diametro { get; set; }

        [Required]
        [Column("Perfil")]
        public int Perfil { get; set; }

        [Required]
        [Column("MmCocada")]
        public double MmCocada { get; set; }

    }
}