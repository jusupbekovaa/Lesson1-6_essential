using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_2
{
    class BadPupil: Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Плохой ученик читает плохо!");
        }
        public override void Study()
        {
            Console.WriteLine("Плохой ученик учится плохо!");
        }
        public override void Write()
        {
            Console.WriteLine("Плохой ученик пишет плохо!");
        }
        public override void Relax()
        {
            Console.WriteLine("Плохой ученик много отдыхает!");
        }
    }
}
