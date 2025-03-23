using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreasOfShapesApp
{
    class Square : Shapes //Inheritance
    {
        //Fields
        double side;

        //Constructor
        public Square(double s)
        {
            this.side = s;
        }

        //Overriden method
        public override void CalculateArea()
        {
            double area = this.side * this.side;
            Console.WriteLine($"Area of Square is : {area} square cm");
        }
    }
}
