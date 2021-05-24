using System;

namespace ConsoleApp5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Atricle atricle1 = new Atricle("Tovar1","Shop1", 150 );
            Atricle atricle2 = new Atricle("Tovar2", "Shop1", 250);
            atricle1.GetInfo();
            atricle2.GetInfo();
            Console.ReadKey();
        }
    }
}
