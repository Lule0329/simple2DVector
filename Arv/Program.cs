using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 4;

            Simple2DVector vect = new Simple2DVector(x, y);
            Better2DVector vect2 = new Better2DVector(x, y);

            Console.WriteLine(vect2.GetMagnitude());
        }
    }
}
