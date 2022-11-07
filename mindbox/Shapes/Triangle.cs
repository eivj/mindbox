using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    public class Triangle : GeometricShape
    {
        private static double Side1 { get; set; }
        private static double Side2 { get; set; }
        private static double Side3 { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            try
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new ArgumentException("Triangle sides must be > 0");
                }
                else
                {
                    Side1 = side1;
                    Side2 = side2;
                    Side3 = side3;
                }
            }
            catch (ArgumentException e )
            {
                Console.WriteLine(e);
            }
           
        }
        /// <summary>
        /// calculate the area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {                
            double p = (Side1 + Side2 + Side3) / 2;
            double TriangleArea = Math.Sqrt(p*(p - Side1) * (p - Side2) * (p - Side3));
            return TriangleArea;
        }
        /// <summary>
        /// Сhecks if a triangle is a right triangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static bool CheckRightTriangle(double side1, double side2, double side3)
        {
            try
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new ArgumentException("Triangle sides must be > 0");
                }
                else
                {
                    bool resultOfPythagoras_1 = Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2);
                    bool resultOfPythagoras_2 = Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2);
                    bool resultOfPythagoras_3 = Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2);

                    if (resultOfPythagoras_1 || resultOfPythagoras_2 || resultOfPythagoras_3)
                        return true;

                    else
                        return false;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return false;
            }
           
          
    
        }
    }
}
