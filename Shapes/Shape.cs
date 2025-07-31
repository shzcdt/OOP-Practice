﻿namespace Shapes;

abstract class Shape
{
    public string PetName { get; set; }
    
    protected Shape(string name = "NoName")
    {
        PetName = name;       
    }

    public abstract void Draw();
}