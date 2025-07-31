using System;
using Employees;

Console.WriteLine("***** The Employee Class Hierarchy *****\n");

SalesPerson fred = new SalesPerson
{
    Age = 31, Name = "Fred", SalesNumber = 50
};

Employee.BenefitPackage.BenefitPackageLevel myBenefitPackageLevel = Employee.BenefitPackage.BenefitPackageLevel.Gold;

Manager chucky = new Manager("Chucky", 43, 93, 3000, "932-32-3232", 9000);
chucky.GiveBonus(299);
chucky.DisplayStats();
Console.WriteLine();

SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "333-32-3232", 31);
fran.GiveBonus(299);
fran.DisplayStats();
Console.WriteLine();

// the best bonus system 

Manager Roma = new Manager("Roma", 50, 92, 100000, "333-32-3232", 9000);
Roma.GiveBonus(299);
Roma.DisplayStats();
Console.WriteLine();
CastingExample();

static void CastingExample()
{
    object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
    
    Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);

    SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
    
    Employee beck = new PtSalesPerson("Beck", 834, 3002, 100000, "111-12-1119", 90);
    
    GivePromotion(beck);
    GivePromotion(jill);
    GivePromotion(moonUnit);
    GivePromotion((Manager)frank);
}

static void GivePromotion(Employee emp)
{
    Console.WriteLine("{0} was promoted!", emp.Name);

    switch (emp)
    {
        case SalesPerson salesPerson when salesPerson.SalesNumber > 5:
            Console.WriteLine("{0} made {1} sale (s)!", salesPerson.Name, salesPerson.SalesNumber);
            break;
        case Manager manager:
            Console.WriteLine("{0} had {1} stock options...", manager.Name, manager.StockOption);
            break;
        case Employee _:
            Console.WriteLine("Unable to promote{0}. Wrong employee type", emp.Name);
            break;
    }
    Console.WriteLine();
}

// object frank = new Manager();
// Hexagon hex;
// try
// {
//     hex = (Hexagon)frank;
// }
// catch (InvalidCastException ex)
// {
//     Console.WriteLine(ex.Message);
// }
object[] things = new object[4];
things[0] = new Hexagon();
things[1] = false;
things[2] = new Manager();
things[3] = "last thing";

foreach (object item in things)
{
    Hexagon hex = item as Hexagon;
    if (hex == null)
    {
        Console.WriteLine("Item is not a Hexagon");
    }
    else
    {
        hex.Draw();
    }
}

Console.ReadLine();

