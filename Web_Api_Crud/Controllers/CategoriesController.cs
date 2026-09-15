using Microsoft.AspNetCore.Mvc;

namespace Web_Api_Crud.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
