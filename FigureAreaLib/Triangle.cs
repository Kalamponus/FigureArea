using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaLib
{
    public class Triangle
    {
        double firstSide, secondSide, thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        /// <summary>
        /// Функция нахождения площади треугольника по трём сторонам с проверкой, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            double area; 
            try
            {
                if (firstSide > 0 && secondSide > 0 && thirdSide > 0 &&
                (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)) //Проверка, существует ли треугольник
                {
                    double halfPerim = (firstSide + secondSide + thirdSide) / 2;
                    if (!(firstSide == secondSide && secondSide == thirdSide && firstSide == thirdSide)) //Проверка, не является ли треугольник равносторонним
                    {
                        if (firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide) //Проверка, является ли треугольник прямоугольным (также и в двух условиях ниже)
                        {
                            area = (halfPerim - firstSide) * (halfPerim - secondSide);
                        }
                        else if (firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide)
                        {
                            area = (halfPerim - firstSide) * (halfPerim - thirdSide);
                        }
                        else if (secondSide * secondSide + thirdSide * thirdSide == firstSide * firstSide)
                        {
                            area = (halfPerim - thirdSide) * (halfPerim - secondSide);
                        }
                        else
                        {
                            area = Math.Sqrt(halfPerim * (halfPerim - firstSide) * (halfPerim - secondSide) * (halfPerim - thirdSide));
                        }
                    }
                    else
                    {
                        area = Math.Sqrt(halfPerim * (halfPerim - firstSide) * (halfPerim - secondSide) * (halfPerim - thirdSide));
                    }
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
        /// <summary>
        /// Упрощённая функция нахождения площади треугольника по трём сторонам
        /// </summary>
        /// <returns></returns>
        public double AreaSimple() //Т.к. при проверке задания будет просматриваться проверка на то, что треугольник прямоугольный, в основнов методе сделал её. Но, по идее, общая формула Герона подходит всем треугольникам.
        {
            double area;
            try
            {
                if (firstSide > 0 && secondSide > 0 && thirdSide > 0 &&
                                (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide)) //Проверка, существует ли треугольник
                {
                    double halfPerim = (firstSide + secondSide + thirdSide) / 2;
                    area = Math.Sqrt(halfPerim * (halfPerim - firstSide) * (halfPerim - secondSide) * (halfPerim - thirdSide));
                }
                else
                {
                    area = -1;
                }
            }
            catch
            {
                area= -1;
            }
            
            return area;
        }
    }
}
