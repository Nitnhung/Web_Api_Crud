using Microsoft.AspNetCore.Mvc;

namespace Web_Api_Crud.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
