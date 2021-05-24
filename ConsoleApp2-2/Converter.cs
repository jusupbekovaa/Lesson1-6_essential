using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2_2
{
    class Converter
    {
        double hrn,usd,eur,rub;
        public double Hrn
        {
            get
            {
                return hrn;
            }
            set
            {
                hrn = value;
            }
        }
        public double Usd
        {
            get
            {
                return usd;
            }
            set
            {
                usd = value;
            }
        }
        public double Eur
        {
            get
            {
                return eur;
            }
            set
            {
                eur = value;
            }
        }
        public double Rub
        {
            get
            {
                return rub;
            }
            set
            {
                rub = value;
            }
        }
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void ConvertToUsd(double value)
        {
            double result = value / Usd;
            Console.WriteLine("{0} гривен = {1} долларов", value, result);
        }
        public void ConvertToEur(double value)
        {
            double result = value / Eur;
            Console.WriteLine("{0} гривен = {1} евро", value, result);
        }
        public void ConvertToRub(double value)
        {
            double result = value / Rub;
            Console.WriteLine("{0} гривен = {1} рублей", value, result);
        }

        public void ConvertFromUsd(double value)
        {
            double result = value * Usd;
            Console.WriteLine("{0} долларов = {1} гривен", value, result );
        }

        public void ConvertFromEur(double value)
        {
            double result = value * Eur;
            Console.WriteLine("{0} евро = {1} гривен", value, result);
        }

        public void ConvertFromRub(double value)
        {
            double result = value * Rub;
            Console.WriteLine("{0} рублей = {1} гривен", value, result);
        }
    }
}
