using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added to cart : " + product.Name);
        }

        public void Add2(string productName, string explain, double cost, int StockPeriod)
        {
            Console.WriteLine("Added to cart : " + productName);
        }
    }
}
