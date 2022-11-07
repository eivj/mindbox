using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    public static class ShapeArea
    {
        public static double CalcuteAreaOfShape(double radius)
        {
            Circle circle = new Circle(radius);
            double area = circle.CalculateArea();
            return area;
        }

        public static double CalcuteAreaOfShape(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            double area = triangle.CalculateArea();
            return area;
        }

      
    }
}
