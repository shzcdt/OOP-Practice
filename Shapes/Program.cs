using System;
using Shapes; 

Console.WriteLine("***** Fun with Polymorphism *****");

Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda"), new ThreeDCircle()};

foreach (Shape s in myShapes)
{
    s.Draw();
}
ThreeDCircle o = new ThreeDCircle();
o.Draw();

((Circle)o).Draw();

Console.ReadLine();
Hexagon hex = new Hexagon("Beth");
hex.Draw();
Circle circle = new Circle("Cindy");
circle.Draw();
Console.ReadLine();

