// შენ გაქვს კომპანია და გინდა შექმნა პროგრამა, რომელიც თანამშრომლების სახელფასო მონაცემებისა
// და ნამუშევარი დროის მიხედვით დაინგარიშებს ჯამურ ანაზღაურებას.
// ნამუშევარ საათებს ვითვლით ყოველდღიურად.
// თანამშრომელს ანაზღაურებს ვაძლევთ საათების მიხედვით.
// თუ ნამაშრომელმა იმუშავა დღეში 8-საათზე მეტი მაშინ ვუხდით ზეგანაკვეთურ ანაზღაურებას.
// ზეგანაკვეთური ანაზღაურება ერიცხება მხოლოდ იმ საათებზე რომელი 8-სამუშაო საათის მიღმაა.
// მაგალითად თუ იმუშავა 10 საათი, ზეგანაკვეთური ანაზღაურება ერიცხება 2-საათზე.
// თანამშრომლებს ზეგანაკვეთურ ნამუშევარ საათებში ვუხდით ხელფასის 125%-ს
// გარდა ჯამური ხელფასისა პროგრამამ უნდა გამოიტანოს იმ თანამშრომლების სია რომლებმაც
// ზეგანაკვეთურად იმუშავეს და მათთვის მისაცემი ანაზღაურება
//

internal enum Colors
{
    White,
    Green,
    Red
}

internal class Program
{
    public static void Main()
    {
        var company = new Company
        {
            Employees = GetEmployees()
        };

        var dateTime = DateTime.Now;

        var color = Colors.Green;

        switch (color)
        {
            case Colors.White:

                break;

            case Colors.Green:
                break;

            case Colors.Red:
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }

        var totalAmountToPay = company.CalculateTotalSalary();

        Console.WriteLine($"Total amount to pay: {totalAmountToPay:C}");
    }

    private static List<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                Name = "Daviti",
                Wage = 70.06m,
                WorkedHours = 7
            },

            new Employee
            {
                Name = "Gia",
                Wage = 80.01m,
                WorkedHours = 8
            },

            new Employee
            {
                Name = "Gela",
                Wage = 50.19m,
                WorkedHours = 11
            },

            new Employee
            {
                Name = "Mariami",
                Wage = 82.00m,
                WorkedHours = 9
            },
        };
    }
}