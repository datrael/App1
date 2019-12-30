using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12
{
    public class Program
    {

        static void Main(string[] args)
        {
            Order order = new Order();
            order.Name = "Zamówienie pierwsze";
            order.Price = 12.50;
            order.ShouldAddDiscount = true;

            Order order2 = new Order();
            order2.Name = "Zamówienie drugie";
            order2.Price = 17.40;
            order2.ShouldAddDiscount = false;

            Order order3 = new Order();
            order3.Name = "Zamówienie trzecie";
            order3.Price = 19.33;
            order.ShouldAddDiscount = true;

            OrderService os = new OrderService(11, 22);
            os.Add(order);

            OrderService os2 = new OrderService(33, 44);
            os2.Add(order2);

            OrderService os3 = new OrderService(55, 66);
            os3.Add(order3);

            OrderService wynik = new OrderService(11, 33);
            wynik.GetAll();

            FileLogger fl = new FileLogger();
            fl.ReadLogs();

            Console.ReadKey();
        }

    }
}
