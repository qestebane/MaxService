using MaxService.Models.registrar;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace MaxService.Models

{
    public class ApplicationsRegistroDbContext : IdentityDbContext
    {

        public ApplicationsRegistroDbContext(DbContextOptions<ApplicationsRegistroDbContext> options)
            : base(options)
        {

        }
     
        public DbSet<nuevoregistro> registro { get; set; }
    }
}