using System;
using System.Linq;
using MaxService.Models.Cliente;
using Microsoft.AspNetCore.Mvc;
using MonoGamingStore.Data;
using Rotativa.AspNetCore;

namespace MaxService.Controllers
{
    public class DocumentoController : Controller
    {
        private  readonly ApplicationDbContext  _context;

        public DocumentoController(ApplicationDbContext context)
        {
            _context = context;
        }

        /*public IActionResult Documento()
        {
            var doc = _context.DataRegistro.OrderBy(x => x.RegistroId).ToList();
            //return new ViewAsPdf("Documento");
            return View(doc);
        }*/

        
    }
}