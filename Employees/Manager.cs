namespace Employees;

class Manager : Employee
{
    public int StockOption { get; set; }

    public Manager() { }
    
    public Manager(string fullName, int age, int empId, float currPay, string ssn, int numbOfOpts) 
        : base(fullName, age, empId, currPay, ssn, EmployeePayTypeEnum.Salaried)
    {
        StockOption = numbOfOpts;
    }

    public override void GiveBonus(float amount)
    {
        base.GiveBonus(amount);
        Random r = new Random();
        StockOption += r.Next(500);
    }

    public override void DisplayStats()
    {
        base.DisplayStats();
        Console.WriteLine("Number of sales: {0}", StockOption);
    }
}