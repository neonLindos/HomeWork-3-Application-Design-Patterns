using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_3.task1.models;

namespace HomeWork_3.task1.controller
{
    public class OrderController
    {

        public double CalculateTotalPrice(Order order)
        {
            // Рассчет стоимости с учетом скидок
            return order.Quantity * order.Price * 0.9;
        }

       

       
    }


}

