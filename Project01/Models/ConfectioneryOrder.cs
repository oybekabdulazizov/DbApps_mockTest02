﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project01.Models
{
    public class ConfectioneryOrder
    {
        public int IdConfectionery { get; set; }
        public int IdOrder { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }

        public virtual Confectionery Confectionery { get; set; }
        public virtual Order Order { get; set; }
    }
}
