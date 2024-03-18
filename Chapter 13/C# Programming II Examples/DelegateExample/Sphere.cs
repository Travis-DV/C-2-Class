using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Sphere
    {
        internal static double Volume(double radius)
        {
            return (4/3) * Math.PI * Math.Pow(radius, 3);
        }
    }
}
