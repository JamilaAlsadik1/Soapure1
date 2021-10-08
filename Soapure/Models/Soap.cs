using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soapure.Models
{
    public class Soap
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string MainIngredient{get; set;}
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
