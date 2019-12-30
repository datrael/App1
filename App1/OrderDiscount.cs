namespace App1
{
    public class OrderDiscount
    {

        public static double discount = 0.20;
        public void CalculateDiscount(double order1)
        {
            Order order = new Order();
            order1 = order.Price * discount;
        }
    }
}
