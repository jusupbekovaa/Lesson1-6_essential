using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_3
{
    class Content
    {
        string text;
        public string Text
        {
            get
            {
                if (text == null)
                {
                    return "Контент отсутствует";
                }
                else
                    return text;
            }
            set { text = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
