using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Better2DVector : Simple2DVector
    {
        public Better2DVector(double x, double y) : base(x, y)
        {

        }

        public double GetMagnitude()
        {
            double sum = 0;
            sum = Math.Sqrt((X * X) + (Y * Y));
            return sum;
        }

        static double DotProduct(Better2DVector v1, Better2DVector v2)
        {
            return (v1.X * v2.X) + (v1.Y * v2.Y);
        }
    } 
}
