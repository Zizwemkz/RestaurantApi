using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Models
{
    public class RestaurantPhonebook
    {
        public int RestaurantPhonebookId { get; set; }
        public int PhoneNumber { get; set; }
        public int RestaurantId { get; set; }

        public virtual RestaurantDetails RestaurantDetail { get; set; }
    }
}
