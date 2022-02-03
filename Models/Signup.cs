using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace WebApplication2.Models
{
    public class Signup
    {
       

        [Display(Name ="First Name")]
        [Required(ErrorMessage ="Must enter your first name")]
        public string? FirstName { get; set; }

        [Display(Name ="Last Name")]
        [Required(ErrorMessage ="Must enter your last name")]
        public string? LastName { get; set;}
        
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        [Required(ErrorMessage ="Must enter valid Email")]
        [EmailAddress(ErrorMessage ="Enter valid EmailAddress")]
        public string? Email { get; set; }   

        [Display(Name ="Password")]
        [Required(ErrorMessage ="Enter a valid password from your preference")]
        [DataType(DataType.Password)]
        [StringLength(100,MinimumLength=8,ErrorMessage ="Enter valid password for registration")]
        public string? Password { get; set; }

        [Display(Name ="ConfirmPassword")]
        [Required(ErrorMessage ="Enter same password to confirm registration")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Enter right password")]
        public string? ConfirmPassword { get; set; }


    }
}
