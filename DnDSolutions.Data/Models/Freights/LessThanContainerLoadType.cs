using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Freights
{
    public enum LessThanContainerLoadType
    {
        [Display(Name = "Alcohol")]
        Alcohol,
        [Display(Name = "New Commercial Goods")]
        NewCommercialGoods,
        [Display(Name = "Used Commercial Goods")]
        UsedCommercialGoods,
    }
}
