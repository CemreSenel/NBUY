using Microsoft.AspNetCore.Mvc;

namespace ShoppingApp.Web.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
