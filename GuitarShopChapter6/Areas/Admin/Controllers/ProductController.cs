using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShopChapter6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        //List() method of Product controller
        [Route("[area]/[controller]s/{id?}")]
        public IActionResult List(string cat, int num)
        {
            return Content("Product controller, List action, " + "Category " + cat + ", Page: " + num);
        }

        //Route for products w/ ID
        public IActionResult Detail(int id)
        {
            return Content("Product controller, Detail action, id: " + id);
        }

        [NonAction]
        public string GetSlug(string name)
        {
            return name.Replace(' ', '-').ToLower();
        }
    }
}
