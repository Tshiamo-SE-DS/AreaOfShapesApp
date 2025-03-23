using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreasOfShapesApp
{
    class Triangle : Shapes //inheritance
    {
        double tbase, height;

        //Parameterized Constructor
        public Triangle(double b, double h)
        {
            this.height = h;
            this.tbase = b;
        }

        //Overriden method
        public override void CalculateArea()
        {
            double area = 0.5 * this.tbase * this.height;
            Console.WriteLine($"Area of Triangle is : {area} square cm");
        }
    }
}
