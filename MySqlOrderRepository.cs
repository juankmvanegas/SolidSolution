using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSolution
{
    public class MySqlOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine($"Guardando orden:{order.OrderId} en bd Mysql");
        }
    }
}
