using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Models
{
    public class Waiter
    {
        public int WaiterId { get; set; }
        public string Name { get; set; }
        public int RestaurantId { get; set; }
        public int RestaurantPhonebookId { get; set; }
        public virtual RestaurantPhonebook RestaurantPhonebook { get; set; }
        public virtual RestaurantDetails RestaurantDetail { get; set; }

    }
}
