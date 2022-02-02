using Microsoft.AspNetCore.Mvc;

namespace ProjetoAspNetMVC01.Presentation.Controllers
{
    //método utilizado para criar a página
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
