using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Car
    {
        public void Display(double power, string course, int count, string color, bool ihk, bool isn, double length)
        {
            Engine eng = new Engine();
            power = eng.Power;
            course = eng.Course;

            Wheels whee = new Wheels();
            count = whee.Count;

            Body body = new Body();
            color = body.Color;
            ihk = body.IsHatchback;
            isn = body.IsSedan;
            length = body.Length;

            Console.WriteLine
                ("Elementy samochodu: " + Environment.NewLine +
                "Moc: {0}," + Environment.NewLine +
                "{1}," + Environment.NewLine +
                "{2}," + Environment.NewLine +
                "{3}," + Environment.NewLine +
                "{4}," + Environment.NewLine +
                "{5}," + Environment.NewLine +
                "{6}",
                eng.Power, eng.Course, whee.Count, body.Color, body.IsHatchback, body.IsSedan, body.Length);

        }
    }
}
