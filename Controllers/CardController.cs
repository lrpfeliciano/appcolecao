using Microsoft.AspNetCore.Mvc;

namespace AppColecao.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
