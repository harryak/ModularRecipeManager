using Microsoft.AspNetCore.Mvc;

namespace ModularRecipeManager.Controllers
{
    public class MeasurementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}