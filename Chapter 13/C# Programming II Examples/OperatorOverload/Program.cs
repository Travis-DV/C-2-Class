using OperatorOverload;

Box Box1 = new();   // Declare Box1 of type Box
Box Box2 = new();   // Declare Box2 of type Box
Box Box3;

// box 1 specification
Box1.Length = 6.0;
Box1.Width = 7.0;
Box1.Height = 5.0;

// box 2 specification
Box2.Length = 12.0;
Box2.Width = 13.0;
Box2.Height = 10.0;

// volume of box 1
Console.WriteLine("Volume of Box1 : {0}", Box1.getVolume());

// volume of box 2
Console.WriteLine("Volume of Box2 : {0}", Box2.getVolume());

// Add two object as follows:
Box3 = Box1 + Box2;
Console.WriteLine("Length of Box3 : {0}", Box3.Length);
Console.WriteLine("Width of Box3 : {0}", Box3.Width);
Console.WriteLine("Height of Box3 : {0}", Box3.Height);
Console.WriteLine("Volume of Box3 : {0}", Box3.getVolume());
Console.ReadKey();
