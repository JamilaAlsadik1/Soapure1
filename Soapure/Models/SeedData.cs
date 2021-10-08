using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Soapure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soapure.Models
{
    public class SeedData
    {
        public static void Intialize(IServiceProvider serviceProvider)
        {
            using (var context = new SoapureContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<SoapureContext>>()))
            {
                if (context.Soap.Any())
                {
                    return;
                }
                context.Soap.AddRange(
                    new Soap
                    {
                        ProductName= "Cranberry & Almond Bar Soap",
                        MainIngredient= "Cranberry and almond",
                        Color= "red",
                        Price=17.00M,
                        ImageUrl= "`/img/cranberry.jpg"
                    },
                    new Soap
                    {
                        ProductName = "Kale& Basil Bar soap",
                        MainIngredient = "Kale and basil ",
                        Color = "Green",
                        Price = 13.00M,
                        ImageUrl = "`/img/kale.jpg"
                    },
                    new Soap
                    {
                        ProductName = "Honey, Oats & Cocoa Bar Soap",
                        MainIngredient = "Honey, Oats and Cocoa",
                        Color = "cream",
                        Price = 10.00M,
                        ImageUrl = "`/img/honey.jpg"
                    },
                    new Soap
                    {
                        ProductName = "Fennel & Charcoal Bar Soap",
                        MainIngredient = "Fennel and Charcoal",
                        Color = "Marble ",
                        Price = 6.95M,
                        ImageUrl = "/img/fennel.jpg"
                    },
                    new Soap
                    {
                        ProductName = "Cinnamon & Sweet Orange Bar Soap",
                        MainIngredient = "Cinnamon and Sweet orange ",
                        Color = "Brown and cream",
                        Price =8.95M,
                        ImageUrl = "`/img/cinnamon.jpg"
                    },
                     new Soap
                     {
                         ProductName = "Roasted Squash Bar Soap",
                         MainIngredient = "Squash",
                         Color = "orange",
                         Price = 10.95M,
                         ImageUrl = "`/img/squash.jpg"
                     },
                      new Soap
                      {
                          ProductName = "Rosemary & Maple Bar Soap",
                          MainIngredient = "Rosemary and maple ",
                          Color = "Brown",
                          Price = 12.95M,
                          ImageUrl = "`/img/rosemary.jpg"
                      },
                       new Soap
                       {
                           ProductName = "Juicy orange Bar Soap",
                           MainIngredient = "Orange ",
                           Color = "Orange ",
                           Price = 5.95M,
                           ImageUrl = "`/img/orange.jpg"
                       },
                        new Soap
                        {
                            ProductName = "Pumpkin Bar Soap",
                            MainIngredient = "Pumpkin ",
                            Color = "Light orange",
                            Price = 8.95M,
                            ImageUrl = "`/img/pumpkin.jpg"
                        },
                         new Soap
                         {
                             ProductName = "Aloe Bar Soap ",
                             MainIngredient = "Aloe and peppermint ",
                             Color = "cream",
                             Price = 4.95M,
                             ImageUrl = "`/img/aloe.jpg"
                         }


                    );
                context.SaveChanges();
            }
        }
    }
}
