using DnDSolutions.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DnDSolutions.Web.ViewComponents
{
	public class CustomerInfoViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(string userId, string username)
		{
			DeliveryViewModel deliveryViewModel = new DeliveryViewModel
			{
				UserId = userId,
				Username = username,
			};

			return View(deliveryViewModel);
		}
	}
}
