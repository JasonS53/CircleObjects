using System;
using System.Collections.Generic;
using System.Text;

namespace CircleObjects
{
    class Circle
    { 
        //fields
        private double _radius;
        
        //constructor
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(double radius)
        {   
            this._radius = radius;
        }

        //methods
        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public string CalculateFormattedCircumference(double circumference)
        {
            string circumferenceF = FormatNumber(circumference);
            return circumferenceF;
        }

        public double CalculateArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public string CalculateFormattedArea(double area)
        {
            string areaF = FormatNumber(area);
            return areaF;
        }

        private string FormatNumber(double x)
        {
            x = Math.Round (x,2);
            string x1 = x.ToString();
            return x1;
        }

    }
    
}


