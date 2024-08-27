using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzeria.Models;

namespace Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel() {
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice = 4
            },

             new PizzasModel() {
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Beef = true,
                FinalPrice = 5
            },

             new PizzasModel() {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Ham = true,
                FinalPrice = 12
            },

             new PizzasModel() {
                ImageTitle = "MeatFeast",
                PizzaName = "MeatFeast",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Ham = true,
                Beef = true,
                FinalPrice = 14
            },

             new PizzasModel() {
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Mushrooms = true,
                FinalPrice = 5
            },

              new PizzasModel() {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Peperoni = true,
                FinalPrice = 7
            },

               new PizzasModel() {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Tuna = true,
                FinalPrice = 9
            },

               new PizzasModel() {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice = 5,
                TomatoSouce = true,
                Cheese = true,
                Mushrooms = true,
                Pineapple = true,
                FinalPrice = 12
            }

        };

        public void OnGet()
        {

        }
    }
}
