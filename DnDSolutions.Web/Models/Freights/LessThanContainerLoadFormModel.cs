using DnDSolutions.Data;
using DnDSolutions.Data.Models.Freights;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Freights
{
	public class LessThanContainerLoadFormModel : DeliveryFormModel, IMeasurable
	{
		[Required]
		public LessThanContainerLoadType Type { get; set; }

		[Required]
		public HandlingUnitType HandlingUnit { get; set; }

		public MeasurementUnit MeasurementUnit { get; set; }

		[Required]
		public int LengthFirstPart { get; set; }

		public int? LengthSecondPart { get; set; }

		[Required]
		public int WidthFirstPart { get; set; }

		public int? WidthSecondPart { get; set; }

		[Required]
		public int HeightFirstPart { get; set; }

		public int? HeightSecondPart { get; set; }

		[Required]
		public int Weight { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Display(Name = "Stackable (Items that can be stacked to reduce linear space.)")]
		public bool IsStackable { get; set; }

		[Display(Name = "Hazardous (Hazmat such as chemicals, acid, waste with a UN number.)")]
		public bool IsHazardous { get; set; }
	}
}
