using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Data.Models.Animals
{
    public enum HorseBreed
    {
        [Display(Name = "Andalusian")]
        Andalusian,
        [Display(Name = "Appaloosa")]
        Appaloosa,
        [Display(Name = "Arabian")]
        Arabian,
        [Display(Name = "Bay")]
        Bay,
        [Display(Name = "Clydesdale")]
        Clydesdale,
        [Display(Name = "Donkey")]
        Donkey,
        [Display(Name = "Draft")]
        Draft,
        [Display(Name = "Draft Cross")]
        DraftCross,
        [Display(Name = "Hanoverian")]
        Hanoverian,
        [Display(Name = "Holsteiner")]
        Holsteiner,
        [Display(Name = "Lipizzan")]
        Lipizzan,
        [Display(Name = "Miniature")]
        Miniature,
        [Display(Name = "Morgan")]
        Morgan,
        [Display(Name = "Mule")]
        Mule,
        [Display(Name = "Mustang")]
        Mustang,
        [Display(Name = "Paint")]
        Paint,
        [Display(Name = "Palomino")]
        Palomino,
        [Display(Name = "Pinto")]
        Pinto,
        [Display(Name = "Pony")]
        Pony,
        [Display(Name = "Quarter Horse")]
        QuarterHorse,
        [Display(Name = "Quarter HorseCross")]
        QuarterHorseCross,
        [Display(Name = "Saddlebred")]
        Saddlebred,
        [Display(Name = "Shetland Pony")]
        ShetlandPony,
        [Display(Name = "Standardbred")]
        Standardbred,
        [Display(Name = "Thoroughbred")]
        Thoroughbred,
        [Display(Name = "Thoroughbred Cross")]
        ThoroughbredCross,
        [Display(Name = "Warmblood")]
        Warmblood,
        [Display(Name = "Welsh")]
        Welsh,
        [Display(Name = "WelshPony")]
        WelshPony,
        [Display(Name = "Other")]
        Other,
    }
}
