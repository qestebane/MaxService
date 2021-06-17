using System.Linq;
using System.Threading.Tasks;
using MaxService.Models.Mantenimiento;
using Microsoft.AspNetCore.Mvc;
using MonoGamingStore.Data;

namespace MaxService.Controllers
{
    public class MantenimientoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MantenimientoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(){
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login l){
            var datos = _context.DataLogin.ToList();

            if(datos.Count()==1){
                foreach (var item in datos)
                {
                    if(l.Email.Equals(item.Email) && l.Password.Equals(item.Password)){
                        return Redirect("Administrador/MarcaVehiculo");
                    }
                    else{
                        ViewData["mensaje"] = "Email o Password incorrectos";
                        return View();
                    }
                }
            }
            else{
                if(ModelState.IsValid){
                    _context.Add(l);
                    _context.SaveChanges();
                    return Redirect ("Administrador/MarcaVehiculo");
                }
                
            }
            return View(l);
        }
    }
}