using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Models
{
    public class RestaurantDetails
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Waiter> Waiter { get; set; }

    }
}
