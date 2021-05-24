using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_3
{
    class Player : IPlayable, IRecodable
    {
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Play()
        {
            Console.WriteLine("Проигрывание...");
        }

        public void Record()
        {
            Console.WriteLine("Запись...");
        }

        public void Stop()
        {
            Console.WriteLine("Стоп");
        }
    }
}
