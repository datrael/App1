using System.Xml.Serialization;
using System.IO;

namespace App1
{
    public class OrderService
    {
        readonly private int discount;
        readonly private int logger;
        public OrderService(int discount, int logger)
        {

        }
        public void Add(Order order)
        {
            if (order.ShouldAddDiscount = true)
            {
                OrderDiscount od = new OrderDiscount();
                od.CalculateDiscount(discount);
            }
        }
        public void GetAll() 
        {
            string order = System.IO.File.ReadAllText(@"c:\opt");
            System.Console.WriteLine("orders.txt = {0}", order);
        }
  }
}
