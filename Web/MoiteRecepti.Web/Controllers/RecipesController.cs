using Microsoft.AspNetCore.Mvc;
using MoiteRecepti.Web.ViewModels.Recipes;

namespace MoiteRecepti.Web.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateRecipeIputModel input)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return Redirect("/");
        }
    }
}
