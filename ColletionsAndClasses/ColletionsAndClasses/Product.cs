using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    internal class Product 
    {
        public string Name { get; set; }
        private decimal price;
        public decimal Price 
        {
            get
            { 
                return price;
            }
            set 
            {
                if (value < 0)
                {
                    price = 0;
                }
                else
                {
                    price = value;
                }
            } 
        }
        public enum Currency { GEL, USD, EUR }
        
        private Currency _currency;
        public Currency currency
        { 
            get 
            {
                return _currency; 
            } set
            {
                _currency = value;
            }
        }

        public override string ToString()
        {
            return $" product : {Name}, Price : {Price}, Currency {currency} ";
        }


    }
}
