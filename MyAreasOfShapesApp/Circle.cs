using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreasOfShapesApp
{
    class Circle : Shapes //Inheritance
    {
        //Fields
        const double pi = 3.1428;
        double radius;

        //constructor
        public Circle(double r)
        {
            this.radius = r;
        }

        //Overriden method
        public override void CalculateArea()
        {
            double area = pi * this.radius * this.radius;
            Console.WriteLine($"Area of Circle is : {area} square cm");
        }
    }
}
