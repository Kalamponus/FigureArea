using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    public class Circle
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Функция нахождения площади круга по радиусу
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            double area;
            try
            {
                if (radius > 0) // Проверка корректности ввода
                {
                    area = Math.Pow(Math.PI * radius, 2);
                }
                else
                {
                    area = -1;
                }
            }
            catch
            {
                area = -1;
            }

            return area;
        }
    }
}
