using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_2
{
    class GoodPupil:Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Хороший ученик читает хорошо!");
        }
        public override void Study()
        {
            Console.WriteLine("Хороший ученик учится хорошо!");
        }
        public override void Write()
        {
            Console.WriteLine("Хороший ученик пишет хорошо!");
        }
        public override void Relax()
        {
            Console.WriteLine("Хороший ученик нормально отдыхает!");
        }
    }
}
