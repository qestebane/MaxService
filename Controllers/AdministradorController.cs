using System;
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
            var marca_llanta = _context.DataMarcaLlanta.OrderBy(mll => mll.MarcaLlantaId).ToList();
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


        //---
        //LISTADO DE MEDIDAS de las LLantas _______________________________________________
        public IActionResult MedidaLlanta(){
            var medida_llanta = _context.DataMedidaLlanta.OrderBy(mell => mell.MedidaLlantaId).ToList();
            return View(medida_llanta);
        }

        //REGISTRO DE MEDIDA DE LLANTA ____________________________________________________
        public IActionResult RegistrarMedidaLlanta(){
            return View();
        }
        
        [HttpPost]
        public IActionResult RegistrarMedidaLlanta(MedidaLlanta mell){
            if(ModelState.IsValid){
                _context.Add(mell);
                _context.SaveChanges();
                return RedirectToAction("MedidaLlanta");
            }
            return View(mell);
        }

        //MODIFICACION DE MEDIDA de la LLANTA _________________________________________________________________________
        public IActionResult ModificarMedidaLlanta(int id) {
            var medida_llanta = _context.DataMedidaLlanta.Find(id);
            return View(medida_llanta);
        }

        [HttpPost]
        public IActionResult ModificarMedidaLlanta(MedidaLlanta mell) {
            if (ModelState.IsValid) {
                var medida_llanta = _context.DataMedidaLlanta.Find(mell.MedidaLlantaId);
                medida_llanta.Ancho = mell.Ancho;
                medida_llanta.Diametro = mell.Diametro;
                medida_llanta.Perfil = mell.Perfil;
                _context.SaveChanges();
                return RedirectToAction("MedidaLlanta");
            }
            return View(mell);
        }


        //ELIMINACION DE MARCA DE LLANTA ______________________________________________________
        [HttpPost]
        public IActionResult EliminarMedidaLlanta(int id) {
            var medida_llanta = _context.DataMedidaLlanta.Find(id);
            _context.Remove(medida_llanta);
            _context.SaveChanges();
            return RedirectToAction("MedidaLlanta");
        }



        //---
        //LISTADO DE DETALLES de las LLantas _______________________________________________
        public IActionResult DetalleLlanta(){
            var detalle_llanta = _context.DataDetalleLlanta.OrderBy(dll => dll.DetalleLlantaId).ToList();
            return View(detalle_llanta);
        }

        //REGISTRO DE DETALLE DE LLANTA ____________________________________________________
        public IActionResult RegistrarDetalleLlanta(){
            ViewBag.Ancho = _context.DataMedidaLlanta.ToList().Select(mell => new SelectListItem("Ancho: "+ mell.Ancho.ToString()+ ",  Diametro: " +mell.Diametro.ToString()+",  Perfil: "+mell.Perfil.ToString(), mell.MedidaLlantaId.ToString()));
            ViewBag.MLL = _context.DataMarcaLlanta.ToList().Select(mll => new SelectListItem(mll.NombreMarca, mll.MarcaLlantaId.ToString()));
            return View();
        }
        

        [HttpPost]
        public IActionResult RegistrarDetalleLlanta(DetalleLlanta dll){
           // Console.WriteLine(dll.MedidaLlantaId);

            if(ModelState.IsValid){
                _context.Add(dll);
                _context.SaveChanges();
                return RedirectToAction("DetalleLlanta");
            }
            return View(dll);
        }

        //MODIFICACION DE DETALLE de la LLANTA _________________________________________________________________________
        public IActionResult ModificarDetalleLlanta(int id) {
            var detalle_llanta = _context.DataDetalleLlanta.Find(id);
            ViewBag.Ancho = _context.DataMedidaLlanta.ToList().Select(mell => new SelectListItem("Ancho: "+ mell.Ancho.ToString()+ ",  Diametro: " +mell.Diametro.ToString()+",  Perfil: "+mell.Perfil.ToString(), mell.MedidaLlantaId.ToString()));
            ViewBag.MLL = _context.DataMarcaLlanta.ToList().Select(mll => new SelectListItem(mll.NombreMarca, mll.MarcaLlantaId.ToString()));
            return View(detalle_llanta);
        }

        [HttpPost]
        public IActionResult ModificarDetalleLlanta(DetalleLlanta dll) {
            if (ModelState.IsValid) {
                var detalle_llanta = _context.DataDetalleLlanta.Find(dll.DetalleLlantaId);
                detalle_llanta.IndiceCarga = dll.IndiceCarga;
                detalle_llanta.IndiceVelocidad = dll.IndiceVelocidad;
                detalle_llanta.IndiceVelocidad = dll.IndiceVelocidad;
                detalle_llanta.FotoLlanta = dll.FotoLlanta;
                detalle_llanta.Construccion = dll.Construccion;
                detalle_llanta.PresionMaxima = dll.PresionMaxima;
                detalle_llanta.LimiteCarga = dll.LimiteCarga;
                detalle_llanta.Clasificacion = dll.Clasificacion;
                detalle_llanta.CodigoUTQG = dll.CodigoUTQG;
                detalle_llanta.FechaFabricacion = dll.FechaFabricacion;
                detalle_llanta.MedidaLlantaId = dll.MedidaLlantaId;
                detalle_llanta.MarcaLlantaId = dll.MarcaLlantaId;
                _context.SaveChanges();
                return RedirectToAction("DetalleLlanta");
            }
            return View(dll);
        }


        //ELIMINACION DE DETALLE DE LLANTA ______________________________________________________
        [HttpPost]
        public IActionResult EliminarDetalleLlanta(int id) {
            var detalle_llanta = _context.DataDetalleLlanta.Find(id);
            _context.Remove(detalle_llanta);
            _context.SaveChanges();
            return RedirectToAction("DetalleLlanta");
        }
    }
}