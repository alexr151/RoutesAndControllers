using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarShopChapter6.Controllers
{
    
    public class ProductController : Controller
    {

        //List() method of Product controller
       [Route("Product/{cat?}/{num?}")]
        public IActionResult List(string cat = "All", int num = 1)
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
