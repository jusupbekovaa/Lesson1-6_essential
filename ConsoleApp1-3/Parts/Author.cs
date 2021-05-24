using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_3
{
    class Author
    {
        string text;
        public string Text
        {
            get
            {
                if (text == null)
                {
                    return "Имя автора отсутствует";
                }
                else
                    return text;
            }
            set { text = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
