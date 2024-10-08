using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    internal class Car
    {
        public string Brand { get; set; }
        private int _year;
        private int firstCarYear = 1886;
        private int currentYear = DateTime.Now.Year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < firstCarYear)
                {
                    _year = firstCarYear;
                }
                else if (value > currentYear)
                {
                    _year = currentYear;
                }
                else
                {
                    _year = value;
                }
            }

        }
    }
}