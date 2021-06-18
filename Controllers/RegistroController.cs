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

        public IActionResult Modificar(int id)
        {
            var modificar = _context.DataRegistro.Find(id);
            return View(modificar);
        }

        [HttpPost]
        public IActionResult Modificar(Registro r)
        {
            if (ModelState.IsValid) {
                var cliente = _context.DataRegistro.Find(r.RegistroId);
                cliente.Nombre = r.Nombre;
                cliente.Apellido = r.Apellido;
                cliente.Correo = r.Correo;
                cliente.Documento = r.Documento;
                cliente.Apellido = r.Apellido;
                cliente.FechaActual = DateTime.Now.ToString();
                cliente.FechaEntrega = r.FechaEntrega;
                cliente.DireccionEntrega = r.DireccionEntrega;
                cliente.ModoPago = r.ModoPago;
                cliente.PlazoPago = r.PlazoPago;
                cliente.Adjunto = r.Adjunto;

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

        public IActionResult Cancelar(){
            var datos = _context.DataLista.ToList();
            foreach (var item in datos)
            {
                var dato = _context.DataLista.Find(item.ListarId);
                _context.Remove(dato);
                
            }
            _context.SaveChanges();
            return Redirect("/Producto/Catalogo");
        }

        public IActionResult Aceptar(){
            var datos = _context.DataLista.ToList();
            foreach (var item in datos)
            {
                var dato = _context.DataLista.Find(item.ListarId);
                _context.Remove(dato);
                
            }
            _context.SaveChanges();
            return Redirect("/Producto/Catalogo");
        }

    }
}