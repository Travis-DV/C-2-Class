using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    internal class CreateIndex
    {
        private static int indexSize = 10;
        private double[] numbers = new double[indexSize];

        public double this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value;
            }
        }

        public int GetSize()
        {
            return indexSize;
        }
    }
}
