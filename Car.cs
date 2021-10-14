﻿using System;
using System.Collections.Generic;
using System.Text;
using Validator;
namespace Car_Lot_Group_Lab
{
    class Car
    {
        //properties
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private decimal Price { get; set; }
        //constructors
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        //methods
        public override string ToString()
        {
            return $"{Make}\t{Model}\t{Year}\t${Price}";
        }

    }
}
