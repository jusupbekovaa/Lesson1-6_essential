using System;

namespace ConsoleApp4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите формат документа");
            string text = Console.ReadLine();
            if(text == "doc" || text == "DOC" || text == "Doc")
            {
                AbstractHandler docHandler = new DOCHandler();
                docHandler.Create();
                docHandler.Open();
                docHandler.Change();
                docHandler.Save();
            }
            else if(text == "xml" || text == "XML" || text == "Xml")
            {
                AbstractHandler xmlHandler = new XMLHandler();
                xmlHandler.Create();
                xmlHandler.Open();
                xmlHandler.Change();
                xmlHandler.Save();
            }
            else if(text == "txt" || text == "TXT" || text == "Txt")
            {
                AbstractHandler txtHandler = new TXTHandler();
                txtHandler.Create();
                txtHandler.Open();
                txtHandler.Change();
                txtHandler.Save();
            }
            else
            {
                Console.WriteLine("Неправильный формат");
            }
        }
    }
}
