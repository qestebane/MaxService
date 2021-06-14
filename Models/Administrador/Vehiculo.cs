using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_Vehiculo")]
    public class Vehiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("VehiculoId")] //PK
        public int VehiculoId { get; set; }

        [Required]
        [Column("TipoVehiculo")]
        public string TipoVehiculo { get; set; }

        [Required]
        [Column("FotoVehiculo")]
        public string FotoVehiculo { get; set; }

        [Required]
        [ForeignKey("MarcaVehiculoId_fk")]
        public int MarcaVehiculoId { get; set; }
        public virtual MarcaVehiculo MarcaVehiculo{get; set;}
    

    }
}