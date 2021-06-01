using System.Linq;
using MaxService_1.Models.Producto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonoGamingStore.Data;

namespace MaxService_1.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context){
            _context = context;
        }

        public IActionResult Catalogo(){
            DetalleLlanta detalle_llanta = new DetalleLlanta();
            detalle_llanta.DetalleLlantaId = 2;
            var foto = _context.DataDetalleLlanta.Find(detalle_llanta.DetalleLlantaId);

            ViewData["foto"] = foto.FotoLlanta;
            
            return View();
        }

        public IActionResult Detalle(){
            return View();
        }
    }
}