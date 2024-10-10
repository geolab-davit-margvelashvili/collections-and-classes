using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    internal class Car
    {
        public string Brand {  get; set; }
        private int year;
        public int Year {
            get
            {  return year; }
                 set
            {
                var dateTime = DateTime.Now;
                var currentYear = dateTime.Year;
                if (value > currentYear)
                {
                    year = currentYear;
                }
                else if (value < 1886)
                {
                    year = 1886;
                }
                else
                {
                    year = value;
                }

            }
        }

        public override string ToString()
        {
            return $" Brand : {Brand}, Year : {Year}";
        }
    }
}
