using System;

namespace SolidSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("ORD123", 250.75);

            IOrderRepository repository = new MySqlOrderRepository();

            OrderService orderService = new OrderService(repository);
            orderService.ProcessOrder(order);
            orderService.SaveOrder(order);

            OrderReport reportGenerator = new OrderReport();
            reportGenerator.GenerateReport(order);
        }
    }
}
