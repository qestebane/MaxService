using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MaxService_1.Models.Producto
{
    [Table("T_Vehiculo")]
    public class Vehiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("VehiculoId")] //PK
        public int VehiculoId { get; set; }

        [Column("TipoVehiculo")]
        public string TipoVehiculo { get; set; }

        [Column("FotoVehiculo")]
        public string FotoVehiculo { get; set; }

        [ForeignKey("MarcaVehiculoId_fk")]
        public int MarcaVehiculoId { get; set; }
        public virtual MarcaVehiculo MarcaVehiculo{get; set;}
    

    }
}