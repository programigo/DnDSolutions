using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models
{
    public enum CamperType
    {
        [Display(Name = "Class A Motorhome")]
        ClassAMotorhome,
        [Display(Name = "Class B Motorhome")]
        ClassBMotorhome,
        [Display(Name = "Class C Motorhome")]
        ClassCMotorhome,
        [Display(Name = "Travel Trailer")]
        TravelTrailer,
        [Display(Name = "Folding Tent Trailer")]
        FoldingTentTrailer,
        [Display(Name = "Fifth Wheel")]
        FifthWheel,
        [Display(Name = "Truck Camper")]
        TruckCamper,
    }
}
