using System;
namespace Employees;

abstract partial class Employee
{
    public double GetBenefitCost() 
        => empBenefits.ComputePayDeduction();

    public BenefitPackage Benefits
    {
        get => empBenefits;
        set => empBenefits = value;
    }
    
    public EmployeePayTypeEnum PayType
    {
        get => _payType;
        set => _payType = value;
    }
    
    public int Age
    {
        get => _empAge;
        set => _empAge = value;
    }
    
    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Error! Name Length exceeds 15 characters.");
            }
            else
            {
                _empName = value;
            }
        }
    }

    public int Id
    {
        get { return _empId; }
        set {_empId = value;}
    }

    public float Pay
    {
        get { return _currPay; }
        set {_currPay = value;}
    }

    public string SocialSecurityNumber 
    { 
       get => _empSSN;
       private set => _empSSN = value;
    }
    
    // public void GiveBonus(float amount)
    // {
    //     Pay = this switch
    //     {
    //         {PayType: EmployeePayTypeEnum.Commission} 
    //             => Pay += .10F * amount,
    //         {PayType: EmployeePayTypeEnum.Hourly}
    //             => Pay += 40F * amount/2080F,
    //         {PayType: EmployeePayTypeEnum.Salaried}
    //             => Pay += amount,
    //             _=> Pay += 0
    //     };
    // }

    public virtual void GiveBonus(float amount)
    {
        Pay += amount;
    }
    
    public virtual void DisplayStats()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("ID: {0}", Id);
        Console.WriteLine("Pay: {0}", Pay);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Social Security Number: {0}", SocialSecurityNumber);
    }
}