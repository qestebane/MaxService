using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService.Models.Listado
{
    [Table("T_Listar")]
    public class Listar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ListarId")] //PK
        public int ListarId { get; set; }

        [Required]
        [Column("Marca")]
        public string Marca { get; set; }

        [Required]
        [Column("Precio")]
        public double Precio { get; set; }

        [Required]
        [Column("Cantidad")]
        public int Cantidad { get; set; }

        [Required]
        [Column("Tipo")]
        public string Tipo { get; set; }

        [Required]
        [Column("IC")]
        public int IC { get; set; }

        [Required]
        [Column("IV")]
        public string IV { get; set; }

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

        [Required]
        [Column("Total")]
        public double Total { get; set; }
    }
}