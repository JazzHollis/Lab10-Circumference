using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double radius;//field

        public double Radius//property
        {
            get { return radius; }
            set { radius = value; }

        }

        public double CalculateCircumference()
        {
            double circumference = Math.PI * radius * 2;
            return circumference;
        }


        public string CalculateFormattedCircumference()
        {
            double circumference = Math.PI * radius * 2;
            return ($"{circumference,0:N2}");
        }

        public double CalculateArea()
        {
            double area = (Math.PI * radius * radius);
            return area;
        }

        public string CalculatedFormattedArea()
        {
            double area= (Math.PI * radius * radius);
            return ($"{area,0:N2}");
        }
    }



}  

