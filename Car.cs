using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_ConstructorMethodOverloading_Hafsa
{
    internal class Car
    {
        //fields
        public string _make;
        public string _model;
        public int _year;
        public int _mileage;

        //constructors
        public Car()
        {
            _make = "unassigned";
            _model = "unassigned";
            _year = 0;
            _mileage = 0;
        }//default constructor

        public Car(string make, string model)
        {
            _make = make;
            _model = model;
            _year = 0;
            _mileage = 0;
        }//make and model constructor

        public Car(string make, string model, int year, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
        }//make model year and mileage constructor

        //override tostring()
        public override string ToString()
        {
            return $"{Year} {Make} {Model} - {Mileage}";
        }


        //properties
        public string Make
        {
            get => _make; set => _make = value; 
        }
        public string Model
        {
            get => _model; set => _model = value;
        }
        public int Year
        {
            get => _year; set => _year = value;
        }
        public int Mileage
        {
            get => _mileage; set => _mileage = value;
        }


    }//class


}//namespace
