using System;
using System.Linq;
using MaxService.Models.Cliente;
using Microsoft.AspNetCore.Mvc;
using MonoGamingStore.Data;
using Rotativa.AspNetCore;

namespace MaxService.Controllers
{
    public class RegistroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Documento(int id)
        {
            var doc = _context.DataRegistro.OrderBy(x => x.RegistroId).Where(x => x.RegistroId == id).ToList();
            ViewData["idd"] = id;

            //return new ViewAsPdf("Documento");

            return View(doc);
        }
        public IActionResult Pdf(int id)
        {

            var doc = _context.DataRegistro.OrderBy(x => x.RegistroId).Where(x => x.RegistroId == id).ToList();
            return new ViewAsPdf(doc);
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Registro r)
        {

            if (ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("Documento", new { id = r.RegistroId });
            }
            return View(r);
        }

        public IActionResult Ticket(int id)
        {
            var doc = _context.DataRegistro.OrderBy(x => x.RegistroId).Where(x => x.RegistroId == id).ToList();
            return View(doc);
        }

    }
}