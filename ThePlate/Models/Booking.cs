using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThePlate.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "Fyll i förnamn")]
        [Display(Name = "Förnamn")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Fyll i efternamn")]
        [Display(Name = "Efternamn")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Fyll i e-mail")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public int PhoneNumber { get; set; }

        [Required(ErrorMessage = "Välj ett datum")]
        [Display(Name = "datum")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Välj en tid")]
        [Display(Name = "Klockslag")]
        public string DinnerTime { get; set; }

        [Required(ErrorMessage = "Ange hur många gäster")]
        [Display(Name = "Antal gäster")]
        public int guestAmount { get; set; }
    }
}
