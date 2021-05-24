using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2_4
{
    class Article
    {
        string articleCode;
        double cost;
        public string ArticleCode
        {
            get
            {
                return articleCode;
            }
            set
            {
                articleCode = value;
            }
        }
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
        public Article() { }
        public Article(string articleCode, double cost)
        {
            this.articleCode = articleCode;
            this.cost = cost;
        }
    }
}
