namespace GroceryManagmentAdvance
{
    internal class Program
    {
        static List<string> items = new List<string>();
        static List<int> quantities = new List<int>();
        static List<double> prices = new List<double>();

        static void Main(string[] args)
        {
            string YourMartName = "Sham'z Store";
            Console.WriteLine("===",YourMartName,"===");
            Home();

        }
        static void GoToHome()

        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to go back to home....");
            Console.ReadKey();
            Console.Clear();
            Home();
        }
        static void Home()
        {
            Console.WriteLine("Select from given options");
            Console.WriteLine("1) Add items");
            Console.WriteLine("2) Veiw items");
            Console.WriteLine("3) Remove items");
            Console.WriteLine("4) Exit");
            int chooise =int.Parse(Console.ReadLine());   // there is a question here that if i make another seprate funtoin for choise so will it conusme more memory or will it be effiecnt 
            
           switch(chooise) 
                {
                case 1:
                    AddItems();
                    break;
                case 2:
                    VeiwItems();
                    break;
                case 3:
                    //RemoveItems();
                    break;
                case 4:
                    //Exit();
                    break;
            }

        }
        static void AddItems()
        {
            Console.WriteLine("Add item here ");
            Console.WriteLine("");
            Console.Write("Item Name: ");
            string itemName=Console.ReadLine();
            Console.Write("Price: ");
            double itemPrice=double.Parse(Console.ReadLine());
            Console.Write("Item Quantity: ");
            int itemQuantity=int.Parse(Console.ReadLine());

            //for style 
            Console.WriteLine("");

            Console.WriteLine("Adding itemss......");
            System.Threading.Thread.Sleep(2000);

            // Adding Data 
            items.Add(itemName);
            prices.Add(itemPrice);
            quantities.Add(itemQuantity);

            //
            GoToHome();

        }
        static void VeiwItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == null)
                {
                    Console.WriteLine("No items no display please Add items....");
                   GoToHome();
                }
                else
                {
                    Console.WriteLine(items[0]);
                    Console.WriteLine(quantities[0]);
                    Console.WriteLine(prices[0]);
                }
            }
        }

    }
}
