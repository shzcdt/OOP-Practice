﻿namespace Shapes;

class ThreeDCircle : Circle
{
    public new string PetName { get; set; }
    
    public new void Draw()
    {
        Console.WriteLine("Drawing a 3D circle");
    }
}