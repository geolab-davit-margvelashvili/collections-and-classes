internal class Employee
{
    public string Name { get; set; }
    public decimal Wage { get; set; }

    public int WorkedHours { get; set; }
    public int WorkedOvertime => WorkedHours <= Constants.NormalWorkingHours ? 0 : WorkedHours - Constants.NormalWorkingHours;

    public decimal CalculateTotalWage() =>
        WorkedHours > Constants.NormalWorkingHours
            ? Constants.NormalWorkingHours * Wage + WorkedOvertime * Wage * Constants.OvertimeRate
            : Wage * WorkedHours;
}