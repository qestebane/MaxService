using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MonoGamingStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MaxService_1.Models.MarcaVehiculo> DataMarcaVehiculo { get; set; }
        public DbSet<MaxService_1.Models.Producto.Vehiculo> DataVehiculo { get; set; }
        public DbSet<MaxService_1.Models.Producto.MedidaLlanta> DataMedidaLlanta { get; set; }
        public DbSet<MaxService_1.Models.Producto.DetalleLlanta> DataDetalleLlanta { get; set; }
        public DbSet<MaxService_1.Models.Producto.Llanta> DataLlanta { get; set; }
        public DbSet<MaxService.Models.Mantenimiento.Login> DataMantenimiento { get; set; }
    }
}
