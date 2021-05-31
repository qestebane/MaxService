using System.Linq;
using MaxService_1.Models;
using MaxService_1.Models.Producto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MonoGamingStore.Data;

namespace MaxService_1.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdministradorController(ApplicationDbContext context)
        {
            _context = context;
        }

        //LISTADO DE LAS MARCAS__________________________________________________________
        public IActionResult MarcaVehiculo(){
            var marca_vehiculo = _context.DataMarcaVehiculo.OrderBy(mv => mv.MarcaVehiculoId).ToList();
            return View(marca_vehiculo);
        }

        //REGISTRO DE MARCA____________________________________________________
        public IActionResult RegistrarMarcaVehiculo(){
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarMarcaVehiculo(MarcaVehiculo mv){
            if(ModelState.IsValid){
                _context.Add(mv);
                _context.SaveChanges();
                return RedirectToAction("MarcaVehiculo");
            }
            return View(mv);
        }


        //MODIFICACION DE MARCA_________________________________________________________________________
        public IActionResult ModificarMarcaVehiculo(int id) {
            var marca_vehiculo = _context.DataMarcaVehiculo.Find(id);
            return View(marca_vehiculo);
        }

        [HttpPost]
        public IActionResult ModificarMarcaVehiculo(MarcaVehiculo mv) {
            if (ModelState.IsValid) {
                var marca_vehiculo = _context.DataMarcaVehiculo.Find(mv.MarcaVehiculoId);
                marca_vehiculo.NombreMarca = mv.NombreMarca;
                marca_vehiculo.Modelo = mv.Modelo;
                _context.SaveChanges();
                return RedirectToAction("MarcaVehiculo");
            }
            return View(mv);
        }


        //ELIMINACION DE MARCA______________________________________________________
        [HttpPost]
        public IActionResult EliminarMarcaVehiculo(int id) {
            var marca_vehiculo = _context.DataMarcaVehiculo.Find(id);
            _context.Remove(marca_vehiculo);
            _context.SaveChanges();

            return RedirectToAction("MarcaVehiculo");
        }

        //---
        //LISTADO DE VEHICULOS_______________________________________________
        public IActionResult Vehiculo(){
            var vehiculo = _context.DataVehiculo.OrderBy(v => v.VehiculoId).ToList();
            return View(vehiculo);
        }

        //REGISTRO DE VEHICULO ____________________________________________________
        public IActionResult RegistrarVehiculo(){
            ViewBag.MV = _context.DataMarcaVehiculo.ToList().Select(v => new SelectListItem(v.NombreMarca, v.MarcaVehiculoId.ToString()));
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarVehiculo(Vehiculo v){
            if(ModelState.IsValid){
                _context.Add(v);
                _context.SaveChanges();
                return RedirectToAction("Vehiculo");
            }
            return View(v);
        }

        //MODIFICACION DE MARCA_________________________________________________________________________
        public IActionResult ModificarVehiculo(int id) {
            var vehiculo = _context.DataVehiculo.Find(id);
            ViewBag.MV = _context.DataMarcaVehiculo.ToList().Select(v => new SelectListItem(v.NombreMarca, v.MarcaVehiculoId.ToString()));
            return View(vehiculo);
        }

        [HttpPost]
        public IActionResult ModificarVehiculo(Vehiculo v) {
            if (ModelState.IsValid) {
                var vehiculo = _context.DataVehiculo.Find(v.VehiculoId);
                vehiculo.TipoVehiculo = v.TipoVehiculo;
                vehiculo.FotoVehiculo = v.FotoVehiculo;
                vehiculo.MarcaVehiculoId = v.MarcaVehiculoId;
                _context.SaveChanges();
                return RedirectToAction("Vehiculo");
            }
            return View(v);
        }


        //ELIMINACION DE MARCA______________________________________________________
        [HttpPost]
        public IActionResult EliminarVehiculo(int id) {
            var vehiculo = _context.DataVehiculo.Find(id);
            _context.Remove(vehiculo);
            _context.SaveChanges();
            return RedirectToAction("Vehiculo");
        }


        //---
        //LISTADO DE Marcas de LLantas _______________________________________________
        public IActionResult MarcaLlanta(){
            var marca_llanta = _context.DataMarcaLlanta.OrderBy(v => v.MarcaLlantaId).ToList();
            return View(marca_llanta);
        }

        //REGISTRO DE MARCA DE LLANTA ____________________________________________________
        public IActionResult RegistrarMarcaLlanta(){
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarMarcaLlanta(MarcaLlanta mll){
            if(ModelState.IsValid){
                _context.Add(mll);
                _context.SaveChanges();
                return RedirectToAction("MarcaLlanta");
            }
            return View(mll);
        }

        //MODIFICACION DE MARCA de LLANTA _________________________________________________________________________
        public IActionResult ModificarMarcaLlanta(int id) {
            var marca_llanta = _context.DataMarcaLlanta.Find(id);
            return View(marca_llanta);
        }

        [HttpPost]
        public IActionResult ModificarMarcaLlanta(MarcaLlanta mll) {
            if (ModelState.IsValid) {
                var marca_llanta = _context.DataMarcaLlanta.Find(mll.MarcaLlantaId);
                marca_llanta.NombreMarca = mll.NombreMarca;
                _context.SaveChanges();
                return RedirectToAction("MarcaLlanta");
            }
            return View(mll);
        }


        //ELIMINACION DE MARCA DE LLANTA ______________________________________________________
        [HttpPost]
        public IActionResult EliminarMarcaLlanta(int id) {
            var marca_llanta = _context.DataMarcaLlanta.Find(id);
            _context.Remove(marca_llanta);
            _context.SaveChanges();
            return RedirectToAction("MarcaLlanta");
        }

    }
}