using DnDSolutions.Data;
using DnDSolutions.Data.Models.Freights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDSolutions.Web.Models.Freights
{
	public class LessThanContainerLoadDetailsViewModel : DeliveryViewModel
	{
        public LessThanContainerLoadType Type { get; set; }

        public HandlingUnitType HandlingUnit { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }

        public int LengthFirstPart { get; set; }

        public int? LengthSecondPart { get; set; }

        public int WidthFirstPart { get; set; }

        public int? WidthSecondPart { get; set; }

        public int HeightFirstPart { get; set; }

        public int? HeightSecondPart { get; set; }

        public int Weight { get; set; }

        public int Quantity { get; set; }

        public bool IsStackable { get; set; }

        public bool IsHazardous { get; set; }
    }
}
