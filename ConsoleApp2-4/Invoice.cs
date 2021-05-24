using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2_4
{
    class Invoice
    {
        public readonly int account = 1;
        public readonly string customer = "Клиент №1";
        public readonly string provider= "Поставщик №1";
        Article article;
        public Article Article { get; set; }
        private int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public Invoice() { }
        public Invoice(Article article , int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }
        public void InvoiceCalc(Article article)
        {
            double Invoice = Quantity * article.Cost;
            double InvoiceTax = (Quantity * article.Cost) * 0.01;
            double finalInvoice = Invoice + InvoiceTax;
            Console.WriteLine("Сумма заказа(без НДС):{0} НДС:{1} Сумма заказа(с НДС):{2}, Артикул товара:{3} Стоимость:{4}", Invoice, InvoiceTax, finalInvoice, article.ArticleCode, article.Cost);

        }
        public void GetInvoice(Invoice invoice)
        {
            Console.WriteLine("Номер аккаунта:{0} Клиент:{1} Поставщик:{2} ", invoice.account, invoice.customer, invoice.provider);
        }
    }
}
