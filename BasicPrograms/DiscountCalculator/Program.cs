using System.Globalization;

namespace DiscountCalculator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            RegionInfo region = new RegionInfo(culture.Name);

            string currencySymbol = region.CurrencySymbol; 
            string currencyName = region.ISOCurrencySymbol;  //these are advance concepts about culture info etc but i was just familer with them that something exsists to get culture info so i applied it and get the code from internet for begning 

            Console.Write("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter discount percentage: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            double discountAmount = (price * discount) / 100;
            double finalPrice = price - discountAmount;

            Console.WriteLine("Discount: " + discountAmount + currencySymbol);
            Console.WriteLine("Final Price: " + finalPrice + currencySymbol);
        }
    }
}
