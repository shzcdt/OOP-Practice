namespace Employees;

abstract partial class Employee
{
    public class BenefitPackage
    {
        public enum BenefitPackageLevel
        {
            Standard, Gold, Platinum
        }
        // Предположим, что есть другие члены, представляющие другие программы и т.д. 
        public double ComputePayDeduction()
        {
            return 125.0;
        }
    }
    protected BenefitPackage empBenefits = new BenefitPackage();
    protected EmployeePayTypeEnum _payType;
    protected string _empName;
    protected int _empId;
    protected float _currPay;
    protected int _empAge;
    protected string _empSSN;
    
    public Employee() {}

    public Employee(string name, int age, int id, float pay, string empSsn) 
        :this(name, 18, id, pay, empSsn, EmployeePayTypeEnum.Salaried) {}
    public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
    {
        Name = name;
        Id = id;
        Pay = pay;
        Age = age;
        SocialSecurityNumber = empSsn;
        PayType = payType;
    }
}