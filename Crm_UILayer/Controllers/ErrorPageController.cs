using Microsoft.AspNetCore.Mvc;

namespace Crm_UILayer.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
