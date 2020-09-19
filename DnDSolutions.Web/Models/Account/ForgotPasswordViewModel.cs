using System.ComponentModel.DataAnnotations;

namespace DnDSolutions.Web.Models.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
