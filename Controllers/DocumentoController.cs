using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace MaxService.Controllers
{
    public class DocumentoController : Controller
    {
        public IActionResult Documento()
        {
            return new ViewAsPdf("Documento");
        }
        public IActionResult Documento2()
        {

            return RedirectToAction("abrirPagina");
        }
        public IActionResult abrirPagina()
        {

            return View();
        }

    }
}