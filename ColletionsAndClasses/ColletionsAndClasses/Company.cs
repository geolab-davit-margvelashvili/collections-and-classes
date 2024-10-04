internal class Company
{
    public List<Employee> Employees { get; set; }

    public decimal CalculateTotalSalary()
    {
        decimal totalAmountToPay = 0m;
        foreach (var employee in Employees)
        {
            totalAmountToPay += employee.CalculateTotalWage();
        }

        return totalAmountToPay;
    }
}