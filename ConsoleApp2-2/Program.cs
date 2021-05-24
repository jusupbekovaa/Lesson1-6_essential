using System;

namespace ConsoleApp2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = null;
            Converter converter = new Converter(84, 100, 10);
            Console.WriteLine("Это конвертер валют. Чтобы закончить конвертацию, введите EXIT");
            while(text!= "EXIT")
            {
                Console.WriteLine("Выберите операцию: \n1.Конвертировать из гривни \n2.Конвертировать в гривню");
                text = Console.ReadLine();
                switch(text)
                {
                    case "1":
                        ConvertTo(converter);
                        break;
                    case "2":
                        ConvertFrom(converter);
                        break;
                    default:
                        Console.WriteLine("Вы неправильно ввели код валюты");
                        break;
                }

            }
        }

        private static void ConvertTo(Converter converter)
        {
            Console.WriteLine("Введите сумму: ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите валюту: \n1.Доллар\n2.Евро\n3.Рубль");
            string text = Console.ReadLine();
            switch (text)
            {
                case "1":
                    converter.ConvertToUsd(value);
                    break;
                case "2":
                    converter.ConvertToEur(value);
                    break;
                case "3":
                    converter.ConvertToRub(value);
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели код валюты");
                    break;
            }
        }
        private static void ConvertFrom(Converter converter)
        {
            Console.WriteLine("Выберите валюту: \n1.Доллар\n2.Евро\n3.Рубль");
            string text = Console.ReadLine();
            switch (text)
            {
                case "1":
                    Console.WriteLine("Введите сумму: ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    converter.ConvertFromUsd(value);
                    break;
                case "2":
                    Console.WriteLine("Введите сумму: ");
                    value = Convert.ToDouble(Console.ReadLine());
                    converter.ConvertFromEur(value);
                    break;
                case "3":
                    Console.WriteLine("Введите сумму: ");
                    value = Convert.ToDouble(Console.ReadLine());
                    converter.ConvertFromRub(value);
                    break;
                default:
                    Console.WriteLine("Вы неправильно ввели код валюты");
                    break;
            }
        }
    }
}
