using System;
using System.Collections.Generic;
using System.Text;

namespace CalorieApp_Business
{
    internal class Products
    {
        //Fields
        private string _name;
        private int _weight;
        private int _calories;


        //properties
        public string Name 
        {
            get { return _name; }
        }
        public int Weight 
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public int Calories 
        {
            get { return _calories}
        }


        //methods



    }
}
