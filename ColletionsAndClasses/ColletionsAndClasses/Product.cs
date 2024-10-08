using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColletionsAndClasses
{
    public class Product
    {
        private decimal _price;
        public string Name { get; set; }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public Currency Currency { get; set; }
    }
}
