using ColletionsAndClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

////სავარჯიშო 1: კლასი "Person"
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



namespace ColletionsAndClasses
{
    internal class Person
    {
        public string Name { get; set; }
        private int _age;
        public int age
        {
            get { return _age;}
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else if (value > 120)
                {
                    _age = 120;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public void GetInfo(Person person)
        {
            if (person != null)
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {age}");
            }
            else
            {
                Console.WriteLine("No info");
            }

        }

    }
}
