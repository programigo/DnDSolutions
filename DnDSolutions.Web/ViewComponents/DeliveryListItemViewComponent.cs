using DnDSolutions.Data.Models.Photos;
using DnDSolutions.Web.Models.Deliveries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.ViewComponents
{
	public class DeliveryListItemViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(
			int id,
			string title,
			string pickupLocation,
			string deliveryLocation,
			DateTime collectionDate,
			List<Photo> photos,
			string controller,
			string action)
		{
			DeliveryListItemModel deliveryListItemModel = new DeliveryListItemModel
			{
				Id = id,
				Title = title,
				PickupLocation = pickupLocation,
				DeliveryLocation = deliveryLocation,
				CollectionDate = collectionDate,
				Photos = photos,
				Controller = controller,
				Action = action,
			};

			return View(deliveryListItemModel);
		}
	}
}
