using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSolution
{
    public class OrderReport
    {
        public void GenerateReport(Order order)
        {
            Console.WriteLine($"Reporte para orden:{order.OrderId} valor de la orden:{order.Amount}");
        }
    }
}
