using Domain_DataLayer.CommonModels;
using System.ComponentModel.DataAnnotations;

namespace Domain_DataLayer.Models.Person
{
    public class User : BasicModel
    {
        [Required(ErrorMessage = "The FirstName is required")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        [StringLength(14,ErrorMessage = "The IdentityNumber has to be 14 digits")]
        [Required(ErrorMessage = "The IdentityNumber is required")]
        public string IdentityNumber { get; set; }


        [StringLength(11, ErrorMessage = "The Mobile-Phone Number has to be 11 digits")]
        [Required(ErrorMessage = "The Mobile-Phone Number must be provided")]
        public string MobilePhone { get; set; }

        
        
        [EmailAddress(ErrorMessage = "The email address is required")]
        public string Email { get; set; }

    }
}
