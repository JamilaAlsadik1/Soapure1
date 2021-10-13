using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soapure.Models
{
    public class Soap
    {//adding five attributes(Id, ProductName,MainIngredient,Color, Price,ImageUrl)
        public int Id { get; set; }
        [Display(Name = "Product Name")]//changing the display name to be Product name
        [Required]
        public string ProductName { get; set; }
        [Display(Name = "Main Ingredient")]//changing the display name to be Main Ingredient
        public string MainIngredient{get; set;}
        public string Color { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]//specify the datatype of price as currency
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Display(Name = "Image")]//changing the display name to be Image
        public string ImageUrl { get; set; }
        [Range(1 , 5)]//adding range to the rating attribute
        [Required]

        public int Rating { get; set; }
    }
}
