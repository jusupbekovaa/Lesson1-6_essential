using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4_2
{
    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт документ в формате XML");
        }
        public override void Create()
        {
            Console.WriteLine("Создан документ в формате XML");
        }
        public override void Change()
        {
            Console.WriteLine("Отредактирован документ в формате XML");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен документ в формате XML");
        }
    }
}
