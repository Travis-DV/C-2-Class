using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    internal class Box
    {
        private double length;   
        private double width;  
        private double height;   

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double getVolume()
        {
            return Length * Width * Height;
        }

        // Overload + operator to add two Box objects.
        public static Box operator + (Box b, Box c)
        {
            Box newBox = new();
            newBox.Length = b.Length + c.Length;
            newBox.Width = b.Width + c.Width;
            newBox.Height = b.Height + c.Height;
            return newBox;
        }
    }
}
