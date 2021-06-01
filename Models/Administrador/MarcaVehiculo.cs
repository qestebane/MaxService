using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models
{
    [Table("T_MarcaVehiculo")]
    public class MarcaVehiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("MarcaVehiculoId")] //PK
        public int MarcaVehiculoId { get; set; }

        [Column("NombreMarca")]
        public string NombreMarca { get; set; }

        [Column("Modelo")]
        public string Modelo { get; set; }
    }
}