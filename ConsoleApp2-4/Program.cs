using System;

namespace ConsoleApp2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();
            article.ArticleCode = "1235";
            article.Cost = 200;
            Invoice invoice = new Invoice();
            invoice.Quantity = 6;
            invoice.GetInvoice(invoice);
            invoice.InvoiceCalc(article);
            
        }
    }
}
