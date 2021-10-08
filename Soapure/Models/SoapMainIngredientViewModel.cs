using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soapure.Models
{
    public class SoapMainIngredientViewModel
    {
        public List<Soap> Soaps { get; set; }
        public  SelectList MainIngredient { get; set; }//will contain the list of main ingredient
        public string SoapMainIngredient { get; set; } //contain Selected main Ingredient
        public string searchString { get; set; }//which contains the text users enter in the search text box
    }
}
