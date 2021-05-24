using System;

namespace ConsoleApp3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom cRoom = new Classroom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

            Console.ReadKey();
        }
    }
}
