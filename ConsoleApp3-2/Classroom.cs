using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3_2
{
    class Classroom
    {
        Pupil[] pupils;
        public Classroom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("Учеба: ");
            foreach (Pupil item in pupils)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.WriteLine("Чтение: ");
            foreach (Pupil item in pupils)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.WriteLine("Письмо: ");
            foreach (Pupil item in pupils)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.WriteLine("Отдых: ");
            foreach (Pupil item in pupils)
                item.Relax();
        }
    }
}
