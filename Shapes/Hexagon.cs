namespace Shapes;

class Hexagon : Shape
{
    public Hexagon() { }
    public Hexagon(string name) : base(name) { }

    public override void Draw()
    {
        Console.WriteLine("Drawing the {0} Hexagon", PetName);
    }
}