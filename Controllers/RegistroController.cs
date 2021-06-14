using System;
using System.Linq;
using MaxService.Models.Cliente;
using Microsoft.AspNetCore.Mvc;
using MonoGamingStore.Data;
using Rotativa.AspNetCore;

namespace MaxService.Controllers
{
    public class RegistroController:Controller
    {
        private  readonly ApplicationDbContext  _context;
        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Documento()
        {
            var doc = _context.DataRegistro.OrderBy(x => x.RegistroId).ToList();
            //return new ViewAsPdf("Documento");
            return View(doc);
        }

        public IActionResult Registro(){
            return View();
        }

        [HttpPost]
        public IActionResult Registro(Registro r){
            r.FechaActual = DateTime.Now.ToString();
            if(ModelState.IsValid){
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("Documento");
            }
            return View(r);
        }

    }
}