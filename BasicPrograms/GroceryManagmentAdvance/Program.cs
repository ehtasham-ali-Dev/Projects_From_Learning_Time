using System.Security.Cryptography;

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
            Console.WriteLine("===", YourMartName, "===");
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
            int chooise = int.Parse(Console.ReadLine());   // there is a question here that if i make another seprate funtoin for choise so will it conusme more memory or will it be effiecnt 

            switch (chooise)
            {
                case 1:
                    AddItems();
                    break;
                case 2:
                    VeiwItems();
                    break;
                case 3:
                    RemoveItems();
                    break;
                case 4:
                    Exit();
                    break;
            }

        }
        static void AddItems()
        {
            Console.WriteLine("Add item here ");
            Console.WriteLine("");
            Console.Write("Item Name: ");
            string itemName = Console.ReadLine();
            Console.Write("Price: ");
            double itemPrice = double.Parse(Console.ReadLine());
            Console.Write("Item Quantity: ");
            int itemQuantity = int.Parse(Console.ReadLine());

            //for style 
            Console.WriteLine("");

            Console.WriteLine("Adding itemss......");
            System.Threading.Thread.Sleep(1000);

            // Adding Data 
            items.Add(itemName);
            prices.Add(itemPrice);
            quantities.Add(itemQuantity);

            //
            GoToHome();

        }
        static void VeiwItems()
        {

            if (items.Count == 0)   //first i was using null here what's the actual diffenrce btw null and empty list and what is best 
            {
                Console.WriteLine("No items no display please Add items....");
                GoToHome();
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Item {0})",i+1);
                Console.WriteLine("Name:{0} ",items[i]);
                Console.WriteLine("Quantity: {0}",quantities[i]);
                Console.WriteLine("Price: {0:c}",prices[i]);
                double total = quantities[i] * prices[i];
                Console.WriteLine("total price {0:c}",total);

                //for style 
                Console.WriteLine("");
                Console.WriteLine("------------------------");
                Console.WriteLine("");

            }

            double grandTotal = 0;

            for (int i = 0; i < items.Count; i++)
            {
                grandTotal += quantities[i] * prices[i];
            }

            Console.WriteLine("******************************");
            Console.WriteLine("Grand Total Price: {0:c}", grandTotal);
            Console.WriteLine("******************************");

            GoToHome();
        }
        static void RemoveItems()
        {
                Console.Write("Write the name of the item u want to remove: ");  // here i want if user have given space in the item name so ignore the space but idk hwo to do this 
                string itemToRemove = Console.ReadLine();
                Console.WriteLine("");
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == itemToRemove)
                {
                    items.RemoveAt(i);
                    quantities.RemoveAt(i);
                    prices.RemoveAt(i);
                    Console.WriteLine("Removing....");
                    Thread.Sleep(1000);
                    Console.Clear();

                    Console.WriteLine("Item Remove successfully..");
                    GoToHome();
                }
            }                  Console.WriteLine("no items to remove");
                  GoToHome();
                
            

        }
        static void Exit()
        {
            Console.WriteLine("Thakns for visiting our store ....");
            Console.WriteLine("");
            Console.WriteLine("If u have any complain press c other wise press m to exit");
            char choise =char.Parse(Console.ReadLine());
            if(choise =='c')
                {
                Console.WriteLine("Write your complain here we will take strict action on it : ");
                string complain=Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Thanks for your complain we will take strict action on it ");
                Environment.Exit(0);
            }
            else
            {

                Console.WriteLine("Thakns for visiting our store ....");
                Environment.Exit(0);

            }
            /* i want that user press any key to go back so chat gpt tell me this 
            f (!string.IsNullOrEmpty(input) && input.ToLower() == "c")
         
            but i dont know waht is this */
        }
    }
}
