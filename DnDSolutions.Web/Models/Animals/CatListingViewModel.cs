﻿using DnDSolutions.Services.Models.Animals;
using System;
using System.Collections.Generic;

namespace DnDSolutions.Web.Models.Animals
{
	public class CatListingViewModel
	{
		public IEnumerable<CatListingServiceModel> Cats { get; set; }

		public int TotalCats { get; set; }

		public int TotalPages => (int)Math.Ceiling((double)this.TotalCats / 10);

		public int CurrentPage { get; set; }

		public int PreviousPage => this.CurrentPage <= 1 ? 1 : this.CurrentPage - 1;

		public int NextPage => this.CurrentPage == this.TotalPages ? this.TotalPages : this.CurrentPage + 1;
	}
}
