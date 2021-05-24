using System;

namespace ConsoleApp1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            author.Text = "Иванов И.И.";
            Content content = new Content();
            content.Text = "Высоко высоко....";
            Title title = new Title();
            title.Text = "Горы в КР";
            Book book = new Book(title, author, content);
            book.Show();
            Console.ReadKey();
        }
    }
}
