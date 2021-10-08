using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soapure.Models
{
    public class Soap
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        [Required]
        public string ProductName { get; set; }
        [Display(Name = "Main Ingredient")]
        public string MainIngredient{get; set;}
        public string Color { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        [Range(1 , 5)]
        [Required]

        public int Rating { get; set; }
    }
}
