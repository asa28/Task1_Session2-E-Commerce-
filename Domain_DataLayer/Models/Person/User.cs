using Domain_DataLayer.CommonModels;
using System.ComponentModel.DataAnnotations;

namespace Domain_DataLayer.Models.Person
{
    public class User : BasicModel
    {
        [Required(ErrorMessage = "The FirstName is required")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        

        [MaxLength(14,ErrorMessage = "The IdentityNumber can't exceed 14 digits")]
        [MinLength(14,ErrorMessage = "The IdentityNumber can't be less than 14 digits")]
        [Required(ErrorMessage = "The IdentityNumber is required")]
        public int IdentityNumber { get; set; }

        
        [MinLength(11, ErrorMessage = "The Mobile-Phone Number can't exceed 11 digits")]
        [MaxLength(11, ErrorMessage = "The Mobile-Phone Number can't be less than 11 digits")]
        [Required(ErrorMessage = "The Mobile-Phone Number must be provided")]
        public int MobilePhone { get; set; }

        
        
        [EmailAddress(ErrorMessage = "The email address is required")]
        public string Email { get; set; }

    }
}
