using System;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ: ");
            string text = Console.ReadLine();
            switch(text)
            {
                case "pro":
                    DocumentWorker proVersion = new ProDocumentWorker(text);
                    proVersion.OpenDocument();
                    proVersion.EditDocument();
                    proVersion.SaveDocument();
                    break;
                case "exp":
                    DocumentWorker expVersion = new ExpertDocumentWorker(text);
                    expVersion.OpenDocument();
                    expVersion.EditDocument();
                    expVersion.SaveDocument();
                    break;
                default:
                    Console.WriteLine("Неверный ключ. Бесплатная версия");
                    DocumentWorker documentWorker = new DocumentWorker(text);
                    documentWorker.OpenDocument();
                    documentWorker.EditDocument();
                    documentWorker.SaveDocument();
                    break;
            }
        }
    }
}
