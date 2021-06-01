using System.Linq;
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
    }
}