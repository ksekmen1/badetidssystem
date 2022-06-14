using System;

namespace Badetidssystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kreds k1 = new Kreds("1", "Familien Rose", "C1", 28, "6");
            Kreds k2 = new Kreds("2", "Familien Hansen", "C2", 23, "7");
            Kreds k3 = new Kreds("3", "Familien Olsen", "C3", 10, "8");

            BadeTidsPeriode b1 = new BadeTidsPeriode("Baby hold", DayOfWeek.Monday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(9).AddMinutes(10), "Hans Peter", "7") ;
            Console.WriteLine(k1);
            b1.AddKreds(k1);
            b1.AddKreds(k2);
            b1.AddKreds(k3);

            Console.WriteLine(b1);
            b1.DKreds("1");
            Console.WriteLine(b1);




        }
    }
}
