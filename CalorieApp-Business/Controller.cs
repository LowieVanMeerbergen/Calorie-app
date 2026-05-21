using System;
using System.Collections.Generic;

namespace CalorieApp_Business
{
    public class Controller
    {
        //List of the eaten products
        private List<Products> _eatenProducts;

        //Constant calories for each product
        private Dictionary<string, int> _productCalories;

        //Giving the right amount of calories to each product
        public Controller()
        {
            _eatenProducts = new List<Products>();
            //This is the list of names and ccalories
            _productCalories = new Dictionary<string, int>
            {
                {"Pizza salami",270},
                {"Cheeseburger",295},
                {"Frieten",312},
                {"Frikandel",222},
                {"Kroket",260},
                {"Chicken nuggets",270},
                {"Doner kebab",215},
                {"Chips naturel",542},
                {"Doritos Nacho Cheese",490},
                {"Cheetos Nibb-it",471},
                {"Popcorn zoet",410},
                {"M and M's",490},
                {"Snickers",488},
                {"Nutella",539},
                {"Pindakaas",620},
                {"Cola",42},
                {"Energy drink",47},
                {"Chocolade melk",83},
                {"Instant noodles",450},
                {"Kaaspizza",265},
            };
        }
        //Gives the list of names for the combobox
        public List<string> GetProductNames()
        {
            return new List<string>(_productCalories.Keys);
        }
        //Adds the eaten product to the list
        public void AddProduct(string name, int weight)
        {
            int caloriesPer100g = _productCalories[name];
            Products product = new Products(name, caloriesPer100g, weight);
            _eatenProducts.Add(product);
        }
        //Returns list of eaten productss
        public List<Products> GetEatenProducts()
        {
            return _eatenProducts;
        }
        //Calculates total amount of kCal eaten
        public int GetTotalCalories()
        {
            int total = 0;
            foreach (Products product in _eatenProducts)
            {
                total += product.CalculatedCalories;
            }
            return total;
        }
    }
}
