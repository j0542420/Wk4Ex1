using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex1
{
    internal class Program
    {
        //convert to USD
        public static double ConvertToUSD(double amount, string fromCurrency)
        {
            //convert currency based on input currency
            switch (fromCurrency)
            {
                //convert EUR to USD
                case "EUR": 
                    return amount / 0.96;
                //convert JPY to USD
                case "JPY":
                    return amount / 152.20;
                //if input is already in USD, return is unchanged
                default:
                    return amount;
            }
        }
        //convert to EUR
        public static double ConvertToEUR(double amount, string fromCurrency)
        {
            //convert currency base on input currency
            switch (fromCurrency)
            {
                //convert USD to EUR
                case "USD":
                    return amount * 0.96;
                //convert JPY to EUR
                case "JPY":
                    return amount / 158.18;
                //if input is already in EUR, return is unchanged
                default:
                    return amount;
            }
        }
        public static double ConvertToJPY(double amount, string fromCurrency)
        {
            //convert currency based on input currency
            switch (fromCurrency)
            {
                //convert JPY to USD
                case "USD":
                    return amount * 152.20;
                //convert JPY to EUR
                case "EUR":
                    return amount * 158.18;
                //if input is already in EUR, return is unchanged
                default:
                    return amount;
            }
        }
        static void main()
        { 
            
        }
    }
}
