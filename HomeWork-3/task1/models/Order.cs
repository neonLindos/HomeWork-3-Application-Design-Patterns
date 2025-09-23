using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3.task1.models
{
    public class Order
    {
        public  string ProductName { get; set; }
        public  int Quantity { get; set; }
        public  double Price { get; set; }

        public Order(string productName, int quantity, double price)
        {
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

    }
}
