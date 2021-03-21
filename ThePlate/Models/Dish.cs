using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThePlate.Models
{
    public class Dish
    {

        public int DishId { get; set; }

        [Required(ErrorMessage = "Du måste fylla i namn på maträtt")]
        [Display(Name = "Maträtt")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Det måste finnas en beskrivning")]
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Maträtten måste ha ett  pris")]
        [Display(Name = "Pris")]
        public int Price { get; set; }
    }
}
