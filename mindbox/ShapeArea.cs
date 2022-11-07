using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    public static class ShapeArea
    {
        /// <summary>
        /// Calculate the area of ​​a circle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CalcuteAreaOfShape(double radius)
        {
            Circle circle = new Circle(radius);
            double area = circle.CalculateArea();
            return area;
        }
        /// <summary>
        /// Calculate the area of ​​a triangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static double CalcuteAreaOfShape(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            double area = triangle.CalculateArea();
            return area;
        }

      
    }
}
