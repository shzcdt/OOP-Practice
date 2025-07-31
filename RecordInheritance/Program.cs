using System;
using System.Xml.Schema;
using RecordInheritance;

Console.WriteLine("Record type inheritance!");

Car c = new Car("Honda", "Pilot", "Blue");
MiniVan miniVan = new MiniVan("Honda", "Pilot", "Blue", 10);

Console.WriteLine($"Checking MiniVan: {miniVan is Car}");

PositionalCar pc = new PositionalCar("Honda", "Pilot", "Blue");
PositionalMiniVan pm = new PositionalMiniVan("Honda", "Pilot", "Blue", 10);
Console.WriteLine($"Checking PositionalMiniVan is-a PositionalCar: {pm is PositionalCar}");
MotorCycle mc = new MotorCycle("Harley", "Lowrider");
Scooter sc = new Scooter("Harley", "Lowrider");
Console.WriteLine($"MotorCycle and Scooter are equal: {Equals(mc,sc)}");

public record MotorCycle(string Make, string Model); 
public record Scooter(string Make, string Model) : MotorCycle(Make,Model);