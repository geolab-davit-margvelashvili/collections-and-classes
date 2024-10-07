using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    internal class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age {  get
            {
                return age;
            }
            set
            { if (value < 0)

                {
                    age = 0;
                }
                else if (value > 120)
                {
                    age = 120;
                }
                else
                {
                    age = value;
                }
            } 
        }   
        
            
        

        public string DisplayInfo()
        {
            if (Name != null)

            { return $" Name : {Name}, Age : {Age} "; }

            else { return " enter both name and age "; }
        }
    }
}
