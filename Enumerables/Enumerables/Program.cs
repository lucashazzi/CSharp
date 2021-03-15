using System;
using Enumerables.Entities;
using Enumerables.Entities.Enums;
namespace Enumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };


            Console.WriteLine(order.ToString());
            //Enumerado p/ string
            string txt = OrderStatus.PendingPayment.ToString();
            //string p/ enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
