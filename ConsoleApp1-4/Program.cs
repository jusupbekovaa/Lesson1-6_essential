using System;

namespace ConsoleApp1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure();
            Console.WriteLine("Периметр: "+ cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
