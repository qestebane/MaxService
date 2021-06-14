using System.Linq;
using MaxService.Models.Listado;
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
            var productos = _context.DataLlanta.Include(x => x.Vehiculo).Include(x=> x.DetalleLlanta).Include(x => x.DetalleLlanta.MedidaLlanta).ToList();
            
            return View(productos);
        }

        public IActionResult Detalle(int id){
            var detalle = _context.DataLlanta.Include(x => x.Vehiculo).Include(x=> x.DetalleLlanta).Include(x => x.DetalleLlanta.MedidaLlanta).Where(x => x.LlantaId == id).ToList();
            return View(detalle);
        }

        public IActionResult Agregar(int id){
            var agregar = _context.DataLlanta.Find(id);
            var agregar2 = _context.DataVehiculo.Find(agregar.VehiculoId);
            var agregar3 = _context.DataDetalleLlanta.Find(agregar.DetalleLlantaId);
            var agregar4 = _context.DataMedidaLlanta.Find(agregar3.MedidaLlantaId);

            Listar l = new Listar();
            l.Marca = agregar3.NombreMarca;
            l.Precio = agregar.Precio;
            l.Tipo = agregar2.TipoVehiculo;
            
            l.IC = agregar3.IndiceCarga;
            l.IV = agregar3.IndiceVelocidad;
            l.Construccion = agregar3.Construccion;
            l.PresionMaxima = agregar3.PresionMaxima;
            l.Clasificacion = agregar3.Clasificacion;
            l.FechaFabricacion = agregar3.FechaFabricacion;

            l.Ancho = agregar4.Ancho;
            l.Diametro = agregar4.Diametro;
            l.Perfil = agregar4.Perfil;
            l.MmCocada = agregar4.MmCocada;

            l.Total = agregar.Precio * l.Cantidad;

            if(ModelState.IsValid){
                _context.Add(l);
                _context.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(l);
        }

        public IActionResult Lista(){
            var listar = _context.DataLista.OrderBy(l => l.ListarId).ToList();
            return View(listar);
        }

        public IActionResult Eliminar(int id){
            var quitar = _context.DataLista.Find(id);
            _context.Remove(quitar);
            _context.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}