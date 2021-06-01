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
        public IActionResult Entrar(){
            return View("_Layout2");
        }
    }
}