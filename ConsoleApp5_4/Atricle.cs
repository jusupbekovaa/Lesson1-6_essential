using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5_4
{
    public class Atricle
    {
        string title;
        string shopName;
        double price;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Atricle()
        {

        }
        public Atricle(string title, string shopName, double price)
        {
            this.title = title;
            this.shopName = shopName;
            this.price = price;
        }
        public void GetInfo()
        {
            Console.WriteLine("Название магазина:{0} Название товара:{1} Цена:{2} ", ShopName, Title, Price);
        }
    }
}
