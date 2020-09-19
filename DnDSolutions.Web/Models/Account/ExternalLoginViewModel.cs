using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Account
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
