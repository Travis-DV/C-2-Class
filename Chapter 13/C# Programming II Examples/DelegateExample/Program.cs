
using DelegateExample;

VolumeDelegate v;

v = Cube.Volume; //Cube.Volume is compatible with v
Console.WriteLine("Cube Volume is " + v(15).ToString());

v = Sphere.Volume;
Console.WriteLine("Sphere Volume is " + v(15).ToString());

v = (double side) => Math.Pow(side, 3) / (6 * Math.Sqrt(2));
Console.WriteLine("Tetrahedron Volume is " + v(15).ToString());
//You can also call "Invoke":
Console.WriteLine("Tetrahedron Volume is " + v.Invoke(12).ToString());

namespace DelegateExample
{
    public delegate double VolumeDelegate(double measurement);
}
