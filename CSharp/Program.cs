using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> IngredientOptions = new List<Ingredient>() 
            {
                new Ingredient("Strawberries", (decimal)1.5),
                new Ingredient("Banana", (decimal)0.5),
                new Ingredient("Mango", (decimal)2.5),
                new Ingredient("Blueberries", (decimal)1),
                new Ingredient("Raspberries", (decimal)1),
                new Ingredient("Apple", (decimal)1.75),
                new Ingredient("Pineapple", (decimal)3.5)
            };

            List<Smoothie> Smoothies = new List<Smoothie>() {
                new Smoothie(new List<Ingredient>() {IngredientOptions[1]}),
                new Smoothie(new List<Ingredient>() {IngredientOptions[0], IngredientOptions[3], IngredientOptions[4]})
            };


            foreach (Smoothie smthy in Smoothies)
            {
                Console.WriteLine($"Name.....{smthy.GetName()}");
                Console.WriteLine($"Cost.....${smthy.GetCost()}");
                Console.WriteLine($"Price....${smthy.GetPrice()}\n\n");
            }
        }
    }

    class Ingredient
    {
        public Ingredient(string _name, decimal _price)
        {
            Name = _name;
            Price = _price;
        }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
    class Smoothie
    {
        public Smoothie(List<Ingredient> _ingredients)
        {
            Ingredients = _ingredients;
        }
        public List<Ingredient> Ingredients { get; private set; }

        public decimal GetCost()
        {
            decimal cost = 0;
            foreach (Ingredient i in Ingredients)
            {
                cost += i.Price;
            }
            return Math.Round(cost, 2);
        }

        public decimal GetPrice()
        {
            return Math.Round(GetCost() + GetCost() * (decimal)1.5, 2);
        }

        public string GetName()
        {
            List<string> ingr_names = new List<string>();
            foreach (Ingredient i in Ingredients)
            {
                ingr_names.Add(i.Name.Replace("berries", "berry"));
            }
            if (Ingredients.Count > 1)
            {
                return string.Join(" ", ingr_names) + " Fusion";
            }
            else
            {
                return string.Join(" ", ingr_names) + " Smoothie";
            }
        }
    }
}
