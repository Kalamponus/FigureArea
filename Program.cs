using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureAreaLib;

namespace FigureArea
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2, 6, 10);
            Circle circle = new Circle(8);
            double a = triangle.Area();  
            double b = circle.Area();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
