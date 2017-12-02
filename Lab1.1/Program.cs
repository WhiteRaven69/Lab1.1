using System;

namespace Lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Valentin", "Migley", new DateTime(1997, 06, 29));
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1.ToShortStrig());

            Console.ReadLine();
        }
    }
}
