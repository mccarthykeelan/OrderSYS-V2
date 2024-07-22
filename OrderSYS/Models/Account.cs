using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderSYS.Models
{
    public class Account
    {
        [DisplayName("Account ID")]
        [Required(ErrorMessage = "Account ID is required")]
        public int Id { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [DisplayName("First Initial")]
        [Required(ErrorMessage = "First Initial is required")]
        public string FirstInitial { get; set; }

        [DisplayName("Surname")]
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone number is required")]
        public string Phone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [DisplayName("Address Line 1")]
        [Required(ErrorMessage = "Address Line 1 is required")]
        public string Address1 { get; set; }

        [DisplayName("Address Line 2")]
        public string Address2 { get; set; } // Optional field

        [DisplayName("City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [DisplayName("County")]
        [Required(ErrorMessage = "County is required")]
        public string County { get; set; }

        [DisplayName("Eircode")]
        [Required(ErrorMessage = "Eircode is required")]
        public string Eircode { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Account Type")]
        [Required(ErrorMessage = "Account Type is required")]
        public string Type { get; set; } 

        [DisplayName("Account Status")]
        [Required(ErrorMessage = "Account Status is required")]
        public string Status { get; set; }
    }
}
