using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Konstruktor konstruktor = new Konstruktor();
            konstruktor.struk = "Nie czekajcie dłużej";
            Console.WriteLine(konstruktor.struk);

            Dom Zamieszkanie = new Dom();
            Zamieszkanie.Number = 39;
            Zamieszkanie.Option = "Ulica";
            Zamieszkanie.Name = "Królewska";
            Console.WriteLine(Zamieszkanie.Option + " " + Zamieszkanie.Name + " " + Zamieszkanie.Number);

            Patient pacjent1 = new Patient();
            pacjent1.Name = "Arkadiusz Stoik";
            pacjent1.Adress = new Adress();
            pacjent1.Newsletter = new Newsletter();
            pacjent1.Display();

            Patient pacjent2 = new Patient();
            pacjent2.Name = "Szymon Cynik";
            pacjent2.Adress = new Adress();
            pacjent2.Newsletter = new Newsletter();

            Patient pacjent3 = new Patient();
            pacjent3.Name = "Stefan Epiryk";
           // pacjent3.Adress._city = "Kraków";
           // pacjent3.Adress._street = "Mazowiecka";
           // pacjent3.Newsletter.IsSigned = true;
            pacjent3.Display();

            // string pacjenci[] = new string[3] {pacjent1.Name, pacjent2.Name, pacjent3.Name};
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

            OrderService os = new OrderService(11,22);
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
