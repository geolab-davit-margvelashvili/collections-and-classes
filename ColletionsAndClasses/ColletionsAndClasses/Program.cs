using ColletionsAndClasses;
using System;

//სავარჯიშო 1: კლასი "Person"
//შექმენით კლასი სახელად Person, რომელსაც ექნება შემდეგი თვისებები (Property):
//Name(სახელი) - სტრინგის ტიპი
//Age(ასაკი) - მთელი რიცხვის ტიპი
//ასაკი ვერ იქნება 0-ზე ნაკლები ან 120-ზე მეტი. თუ ასაკი 0-ნაკლებია  ასაკი უნდა გახდეს 0-ის ტოლი თუ 120-ზე მეტია ასაკი უნდა გახდეს 120-ის ტოლი.
//კლასს უნდა ჰქონდეს GetInfo მეთოდი რომელიც დაარბურენს ტექსტს:
//მაგალითად:
//Person person = new Person();
//person.Name = "John";
//person.Age = 25;
//Console.WriteLine(person.DisplayInfo()); // უნდა დაბეჭდოს "Name: John, Age: 25"

//ამოცანა 2. კლასი "Car"
//შექმენით კლასი სახელად Car, რომელსაც ექნება შემდეგი თვისებები:
//Brand(ბრენდი) - სტრინგის ტიპი
//Year(წელი) - მთელი რიცხვის ტიპი
//გააკეთეთ ვალიდაცია Year თვისებაზე: წელი არ უნდა იყოს 1886-ზე ნაკლები და მიმდინარე წელზე მეტი (დაგჭირდებათ DateTime-ის გამოყენება)
//თუ წელი 1886-ზე ნაკლებია წელი ავტომატურად უნდა გახდეს 1886, თუ მიმდინარე წელზე მეტია უნდა გახდეს მიმდინარე წელი.
//მოცანა 3: კლასი და ენამი
//შექმენით ენამი Currency, რომელსაც ექნება შემდეგი მნიშვნელობები:
//GEL
//USD
//EUR
//შექმენით კლასი Product, რომელსაც ექნება შემდეგი თვისებები (Property):
//Name(დასახელება) - სტრინგის ტიპი
//Price(ფასი) - decimal ტიპი
//Currency(ვალუტა) - Currency ტიპი
//ფასი არ უნდა იყოს უარყოფითი. უარყოფითი ფასის მინიჭების შემთხვევაში ფასი უნდა გახდეს 0.



internal class Program
{
    public static void Main()
    {
        Exercise1();
        Exercise2();
        Exercise3();
    }
   public enum Currency
    {
        GEL = 1,
        USD,
        EUR

    }

    public static void Exercise1()
    {
        var person1 = new Person
        {
            Name = "Niko",
            Age = 27
        };

        var person2 = new Person
        {
            Name = "Sandro",
            Age = 0
        };

        var person3 = new Person
        {
            Name = "Jessica",
            Age = 124
        };

        var person4 = new Person();

        Console.WriteLine(person1.DisplayInfo());
        Console.WriteLine(person2.DisplayInfo());
        Console.WriteLine(person3.DisplayInfo());
        Console.WriteLine(person4.DisplayInfo());


    }

    public static void Exercise2()
    {
        var car1 = new Car
        {
            Brand = "BMW",
            Year = 2025
        };
        var car2 = new Car
        {
            Brand = "Mercedes",
            Year = 1821
        };

        var car3 = new Car
        {
            Brand = "Bentley",
            Year = 2021
        };

        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);

    }
    public static void Exercise3()
    {
        var product1 = new Product
        {
            Name = "Twix",
            Price = 10,
            currency = Product.Currency.GEL
        };

        var product2 = new Product
        {
            Name = "Bounty",
            Price = -10,
            currency = Product.Currency.USD
        };

        var product3 = new Product
        {
            Name = "Mars",
            Price = 3,
            currency = Product.Currency.EUR
        };

        Console.WriteLine(product1);
        Console.WriteLine(product2);
        Console.WriteLine(product3);
    }




}