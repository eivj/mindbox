using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace mindbox
{
    public class Circle : GeometricShape
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            try
            {
                if (radius <= 0)
                {
                    throw new ArgumentException("radius must be > 0");
                }
                else
                {
                    Radius = radius;
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
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            return CircleArea;
        }
    }
}
