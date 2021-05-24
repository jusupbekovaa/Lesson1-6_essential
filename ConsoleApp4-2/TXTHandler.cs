using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_2
{
    class TXTHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ в формате TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Создан документ в формате TXT");
        }
        public override void Change()
        {
            Console.WriteLine("Отредактирован документ в формате TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен документ в формате TXT");
        }
    }
}
