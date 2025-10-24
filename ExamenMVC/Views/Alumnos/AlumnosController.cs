using Microsoft.AspNetCore.Mvc;

namespace ExamenMVC.Controllers
{
    [Route("examen-parcial-2/alumnos")]
    public class AlumnosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Esto busca la vista en Views/Alumnos/Index.cshtml
        }
    }
}
