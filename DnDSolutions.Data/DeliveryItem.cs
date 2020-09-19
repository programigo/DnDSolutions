using DnDSolutions.Data.Models;
using DnDSolutions.Data.Models.Photos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data
{
    public abstract class DeliveryItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime CollectionDateEarliest { get; set; }

        [Required]
        public DateTime CollectionDateLatest { get; set; }

        [Required]
        public DateTime DeliveryDateEarliest { get; set; }

        [Required]
        public DateTime DeliveryDateLatest { get; set; }

        [Required]
        [MaxLength(100)]
        public string PickupLocation { get; set; }

        [Required]
        [MaxLength(100)]
        public string DeliveryLocation { get; set; }

        public List<Photo> Photos { get; set; } = new List<Photo>();

        public string AdditionalDetails { get; set; }

        public DateTime CreateDate { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public List<Bid> Bids { get; set; } = new List<Bid>();
    }
}
