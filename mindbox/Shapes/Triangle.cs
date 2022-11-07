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
                    throw new ArgumentException("The sides of a triangle cannot be 0");
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
        public override double CalculateArea()
        {                
            double p = (Side1 + Side2 + Side3) / 2;
            double TriangleArea = Math.Sqrt(p*(p - Side1) * (p - Side2) * (p - Side3));
            return TriangleArea;
        }

        public static bool CheckRightTriangle(double side1, double side2, double side3)
        {
            try
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    throw new ArgumentException("The sides of a triangle cannot be 0");
                }
                else
                {

                    if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2)
                        || Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2)
                        || Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2))
                    {
                        return true;
                    }

                    else
                        return false;
                }
            }
            catch (ArgumentException e )
            {
                Console.WriteLine(e);
                return false;
            }
           
          
    
        }
    }
}
