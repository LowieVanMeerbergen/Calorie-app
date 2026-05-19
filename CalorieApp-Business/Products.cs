using System;
using System.Collections.Generic;
using System.Text;

namespace CalorieApp_Business
{
    public class Products
    {
        //Fields
        private string _name;
        private int _weight;
        private int _caloriesPer100g;

        //Properties
        public string Name
        {
            get { return _name; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        
        public int CaloriesPer100g
        {
            get { return _caloriesPer100g; }
        }

        //Calculation
        public int CalculatedCalories
        {
            get { return _weight * _caloriesPer100g / 100; }
        }

        //Constructor(s)
        public Products(string name, int caloriesPer100g, int weight)
        {
            _name = name;
            _caloriesPer100g = caloriesPer100g;
            _weight = weight;
        }

        //Makes the list look nice
        public override string ToString()
        {
            return $"{_name} | {CalculatedCalories} kCal";
        }
    }
}