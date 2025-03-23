using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreasOfShapesApp
{
    internal class Program
    {
        //enum must be declared outside the main method
        enum Menu
        {
            Triangle = 1,
            Rectangle,
            Circle,
            Square,
            Exit
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select shape to calculate area for below:");
            Console.WriteLine();

            //Firstly we create a foreach loop to loop through the enum values
            foreach(Menu shape in Enum.GetValues(typeof(Menu)))
            {
                Console.WriteLine($"Press {(int)shape}: for {shape.ToString()}");
            }
            Console.WriteLine();
            Console.WriteLine("=========================================================");

            int choice = int.Parse(Console.ReadLine()); //user choice

            switch(choice)
            {
                case 1:
                    Console.WriteLine("You chose to calculate the area for Triangle");

                    //Here we get the user input
                    Console.WriteLine("Please enter the base of the triangle:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the height of the triangle:");
                    double th = double.Parse(Console.ReadLine());

                    //Here we declare the objects
                    Triangle tri = new Triangle(b, th);

                    //Here we invoke the CalculateArea() method
                    tri.CalculateArea();
                    break;
                case 2:
                    Console.WriteLine("You chose to calculate the area of Rectangle");

                    //Here we get the user input for Rectangle
                    Console.WriteLine("Please enter the height of the rectangle:");
                    double rh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the width of the rectangle");
                    double w = double.Parse(Console.ReadLine());

                    //Here we declare the object
                    Rectangle rec = new Rectangle(w, rh);

                    //Here we invoke the CalculateArea method
                    rec.CalculateArea();
                    break;
                case 3:
                    Console.WriteLine("You chose to calculate the area of Circle");

                    //Here we get the user input for Circle
                    Console.WriteLine("Please enter the radius of the circle:");
                    double r = double.Parse(Console.ReadLine());

                    //Here we declare the object
                    Circle cir = new Circle(r);

                    //Here we invoke the CalculateArea method
                    cir.CalculateArea();
                    break;
                case 4:
                    Console.WriteLine("You chose to calculate the area of Square");

                    //Here we get the user input for Square
                    Console.WriteLine("Please enter the side lenght of the square:");
                    double s = double.Parse(Console.ReadLine());

                    //Here we declare the object
                    Square sqr = new Square(s);

                    //Here we invoke the CalculateArea method
                    sqr.CalculateArea();
                    break;
                case 5:
                    Console.WriteLine("You chose to exit");
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();
        }
    }
}
