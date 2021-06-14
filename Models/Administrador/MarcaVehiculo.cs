using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models
{
    [Table("T_MarcaVehiculo")]
    public class MarcaVehiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("MarcaVehiculoId")] //PK
        public int MarcaVehiculoId { get; set; }

        [Required]
        [Column("NombreMarca")]
        public string NombreMarca { get; set; }

        [Required]
        [Column("Modelo")]
        public string Modelo { get; set; }
    }
}