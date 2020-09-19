﻿using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public class Boat : DeliveryItem, IMeasurable
    {
        public BoatType Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string Make { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

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
        public bool IsOnTrailer { get; set; }

        [Required]
        public BoatServiceType ServiceType { get; set; }

        public string Description { get; set; }
    }
}
