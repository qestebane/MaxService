using MaxService.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaxService.Controllers
{
    public class RegistroController:Controller
    {

     private  readonly ApplicationsRegistroDbContext  _context;
        

        public RegistroController(ApplicationsRegistroDbContext context)
        {
            _context = context;
        }
       public IActionResult nuevoregistro(){
            return View();
        }

    }
}