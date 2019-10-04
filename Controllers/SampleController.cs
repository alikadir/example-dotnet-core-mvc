using Microsoft.AspNetCore.Mvc;

namespace FirstDotnetCoreMVC.Controllers
{
    public class SampleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}