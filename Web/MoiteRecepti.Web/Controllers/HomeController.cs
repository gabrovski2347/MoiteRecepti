namespace MoiteRecepti.Web.Controllers
{
    using System.Diagnostics;

    using MoiteRecepti.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using MoiteRecepti.Web.ViewModels.Home;
    using MoiteRecepti.Data.Common.Repositories;
    using MoiteRecepti.Data.Models;
    using System.Linq;
    using MoiteRecepti.Services.Data;

    public class HomeController : BaseController
    {
        private readonly IGetCountService countService;

        public HomeController(IGetCountService countService)
        {
            this.countService = countService;
        }
        public IActionResult Index()
        {
            var viewModel = countService.GetCounts();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
