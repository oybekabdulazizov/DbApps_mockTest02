using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class Confectionery
    {
        public Confectionery()
        {
            ConfectioneryOrders = new HashSet<ConfectioneryOrder>();
        }

        public int IdConfectionery{ get; set; }
        public string Name { get; set; }
        public decimal PricePerItem { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ConfectioneryOrder> ConfectioneryOrders { get; set; }
    }
}
