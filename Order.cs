using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSolution
{
    public class Order
    {
        public string OrderId { get; private set; }
        public double Amount { get; private set; }

        public Order(string orderId, double amount)
        {
            OrderId = orderId;
            Amount = amount;
        }
    }
}
