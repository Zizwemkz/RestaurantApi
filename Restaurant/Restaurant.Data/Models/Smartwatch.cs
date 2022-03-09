using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Models
{
    public class Smartwatch
    {
        public int WatchId { get; set; }
        public string Brandname { get; set; }    
        public int Serialnumber { get; set; }
        public int RestaurantId { get; set; }
        public virtual RestaurantDetails RestaurantDetail { get; set; }

    }
}
