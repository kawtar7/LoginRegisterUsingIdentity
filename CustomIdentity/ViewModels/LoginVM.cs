using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="username invalid!!")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "password invalid!!")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name ="remember me")]
        public bool RememberMe { get; set;}
    }
}
