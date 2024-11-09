using Microsoft.AspNetCore.Mvc;

namespace RESTAPIUploadDemo.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
