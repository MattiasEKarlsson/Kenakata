using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Models
{
    public class BillingInfoModel
    {
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Street name is required")]
        public string StreetAddress { get; set; }
        public string AdditionalAddressInfo { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        public string State { get; set; }
        [Required(ErrorMessage = "Zip code required")]
        [StringLength(5,
                  MinimumLength = 5,
                  ErrorMessage = "Postal Code must be 5 characters")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Phone number required")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Enter valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Enter a valid Emailaddress")]
        public string Email { get; set; }
        public string OrderNotes { get; set; }


        //ShippingForm

        
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingCompanyName { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingStreetAddress { get; set; }
        public string ShippingAdditionalAddressInfo { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        [StringLength(5,
                  MinimumLength = 5,
                  ErrorMessage = "Postal Code must be 5 characters")]
        public string ShippingPostalCode { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Enter valid phone number")]
        public string ShippingPhone { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Enter a valid Emailaddress")]
        public string ShippingEmail { get; set; }
        
    }
}
