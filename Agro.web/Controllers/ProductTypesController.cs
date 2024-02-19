using Agro.web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Agro.web.Controllers
{
    public class ProductTypesController : Controller
    {
        private readonly DataContext context;

        public ProductTypesController(DataContext context)
        {
            this.context = context;
        }
        public ActionResult Index() 
        {
           return View(this.context.ProductTypes.ToList());

        }
        public IActionResult Create() 
        {
            return View();
        }
    }
}
