using Microsoft.AspNetCore.Mvc;

namespace AppColecao.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
