using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Cube
    {
        internal static double Volume (double edge)
        {
            return Math.Pow(edge, 3);
        }
    }
}
