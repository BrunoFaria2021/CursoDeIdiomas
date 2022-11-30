using Microsoft.AspNetCore.Mvc;

namespace CursosDeIdiomas.Services.Controllers
{
    public class TurmaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
