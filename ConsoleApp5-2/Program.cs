using System;

namespace ConsoleApp5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Введите количество элементов массива: ");
            int Num = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[Num];
            for (int i = 0; i < Num; i++)
            {
                myArray[i] = random.Next(1, 20);
                Console.WriteLine("Элемент {0} индекса = {1}", i, myArray[i]);
            }
            MyArray myArray1 = new MyArray();
            myArray1.Max(myArray);
            myArray1.Min(myArray);
            Console.WriteLine("Cумма элементов массива " + myArray1.Sum(myArray));
            myArray1.Average(myArray);
            myArray1.OddNumbers(myArray);

        }
    }
}
