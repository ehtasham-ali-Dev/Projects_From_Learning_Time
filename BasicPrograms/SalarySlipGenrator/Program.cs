using System.Globalization;
using System.Xml.Linq;

namespace SalarySlipGenrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get current system culture
            CultureInfo culture = CultureInfo.CurrentCulture;

            // Get region info from culture
            RegionInfo region = new RegionInfo(culture.Name);

            // Currency symbol & name
            string currencySymbol = region.CurrencySymbol;
            string currencyName = region.ISOCurrencySymbol;


            Console.WriteLine("---ABC Limited---");
            Console.WriteLine("====================");
            Console.WriteLine("Employee Salary Slip");
            Console.WriteLine("===================");
            Console.WriteLine("");


            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

                           Console.Write("Age: ");
           Console.Write("Id #");
            string id= Console.ReadLine();

            Console.WriteLine("-------------------");
            Console.WriteLine("");

            Console.Write("Salary:");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.Write("Allownce: ");
                double allowance=Convert.ToDouble(Console.ReadLine());
            Console.Write("Dedcuction ");
            double deduction =Convert.ToDouble(Console.ReadLine());
            double netSalary = (salary + allowance) - deduction;

            Console.WriteLine("calcultaing.......");

            System.Threading.Thread.Sleep(3000);    

            Console.Clear();

           

               Console.WriteLine("\n--- Salary Slip ---");
            Console.WriteLine("Name: " + firstName +" "+lastName);
            Console.WriteLine("Id:# "+id);
            Console.WriteLine("Basic Salary:" + salary+currencySymbol);
            Console.WriteLine("Allowance:" + allowance+currencySymbol);
            Console.WriteLine("Deduction:" + deduction + currencySymbol);
            Console.WriteLine("Net Salary:" + netSalary + currencySymbol);

        }
    }
}
