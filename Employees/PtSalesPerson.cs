namespace Employees;

sealed class PtSalesPerson : SalesPerson
{
    public PtSalesPerson(string fullName, int age, int id, float pay, string ssn, int numnOfSales) : base(fullName, age,
        id, pay, ssn, numnOfSales)
    {
    }

    public PtSalesPerson()
    {
    }
}