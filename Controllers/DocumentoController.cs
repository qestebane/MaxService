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
    }
}