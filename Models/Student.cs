using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace WebApplication2.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Enter proper Name")]
        [MinLength(5)]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Enter proper phonenumber")]
        [MinLength(10)]
        [MaxLength(10)]
        public int PhoneNumber { get; set; }


    }
}
