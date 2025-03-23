using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreasOfShapesApp
{
    class Rectangle : Shapes //Inheritance
    {
        //Fields
        double width, height;

        //Constructor
        public Rectangle(double w, double h)
        {
            this.height = h;
            this.width = w;
        }

        //Overriden method
        public override void CalculateArea()
        {
            double area = this.width * this.height;
            Console.WriteLine($"Area of Rectangle is : {area} square cm");
        }
    }
}
