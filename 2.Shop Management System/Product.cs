using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Shop_Management_System
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }
}
