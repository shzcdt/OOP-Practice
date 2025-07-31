using System;
using BasicInheritance;

Console.WriteLine("***** Basic Inheritance *****\n");

Car myCar = new Car(80) {Speed = 50};

Console.WriteLine("My car is going {0} MPH", myCar.Speed);

MiniVan myVan = new MiniVan {Speed = 20};
Console.WriteLine("My Van us going {0} MPH", myVan.Speed);
// myVan._currSpeed = 55; 
Console.ReadLine();

public class OuterClass
{
    private class PublicInnerClass { } // открытый вложенный тип может использоваться кем угодно 
    
    private class PrivateInnerClass { } // закрытый вложенный тип может использоваться только членами включащего класса 
}
