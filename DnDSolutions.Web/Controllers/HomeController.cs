using DnDSolutions.Services;
using DnDSolutions.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DnDSolutions.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int page = 1)
        {
            //if (User.IsInRole(GlobalConstants.TransporterRole))
            //{
            //    return View(new DeliveryListingViewModel
            //    { 
            //        Deliveries = this.deliveries.All(),
            //        TotalDeliveries = this.deliveries.Total(),
            //        CurrentPage = page,
            //    });
            //}
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
