using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSolution
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Procesando orden:{order.OrderId}");
        }
        public void SaveOrder(Order order)
        {
            _orderRepository.Save(order);
        }
    }
}
