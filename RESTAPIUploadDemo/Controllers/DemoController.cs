using Microsoft.AspNetCore.Mvc;

namespace RESTAPIUploadDemo.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
