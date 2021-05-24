using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_2
{
    class ExcelentPupil: Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Успешный ученик читает отлично!");
        }
        public override void Study()
        {
            Console.WriteLine("Успешный ученик учится отлично!");
        }
        public override void Write()
        {
            Console.WriteLine("Успешный ученик пишет отлично!");
        }
        public override void Relax()
        {
            Console.WriteLine("Успешный ученик мало отдыхает!");
        }
    }
}
