using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Crm_UILayer.ViewComponents.Dashboard
{
    public class Widgets:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v = context.Categories.Count();
            return View();
        }
    }
}
