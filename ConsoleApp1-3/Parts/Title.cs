using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_3
{
    class Title
    {
        string text;
        public string Text {
            get { 
                if (text == null)
                {
                    return "Заголовок отсутствует";
                }
            else
                    return text; 
            }
            set { text = value; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
