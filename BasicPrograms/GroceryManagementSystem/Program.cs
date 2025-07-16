namespace GroceryManagementSystem
{
    internal class Program

    {
        static string[] itemNames = new string[1000];
        static int[] itemQuantities = new int[1000];
        static double[] itemPrices = new double[1000];
        static int itemCount = 0;
        static void Main(string[] args)
        {


            // now i'll apply funtions here 
            while (true)
            {

                Console.WriteLine("----Welcome to Sham'z store----");
                Console.WriteLine("========== ********** ===========");
                Home();


            }
            //here i'm making functions for making my program easy to manage and readable 
            static void Home()
            {
                Console.WriteLine("----(Choose  from given options)----");
                Console.WriteLine("");

                Console.WriteLine("1) Add Item");
                Console.WriteLine("2) Veiw Item");
                Console.WriteLine("3) Remove Item");
                Console.WriteLine("4) Exit ");
                int chooise = int.Parse(Console.ReadLine());
                Chooise(chooise);



            }
            static void Chooise(int chooise)
            {
                switch (chooise)
                {
                    case 1:
                        {
                            AddProduct();
                        }
                        break;
                    case 2:
                        {
                            DisplayProductsDetails();
                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {
                            Exit();

                        }
                        break;
                }

            }

            static void AddProduct()
            {
                Console.WriteLine("---Add item here---");
                Console.WriteLine("Item name: ");
                itemNames[itemCount] = Console.ReadLine();

                Console.WriteLine("Quantity(e.g:- 1,2):  ");
                itemQuantities[itemCount] = int.Parse(Console.ReadLine());

                Console.WriteLine("Item Price: ");
                itemPrices[itemCount] = double.Parse(Console.ReadLine());
                itemCount++;

                Console.Clear();

                Console.WriteLine("item Added sucessfully");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to og back home .....");
                Console.ReadKey();

                Home();

            }
            static void DisplayProductsDetails()
            {

                if (itemCount == 0)
                {
                    Console.WriteLine("Sorry no item to display");
                    Console.WriteLine("");
                    Console.WriteLine("press any key to go back to home");

                    Console.ReadKey();
                }
                else
                {
                    for (int i = 0; i < itemCount; i++)
                    {
                        Console.WriteLine($"{i + 1}) ");
                        Console.WriteLine($"Name:{itemNames[i]}");
                        Console.WriteLine($"Quantity:{itemQuantities[i]}");
                        Console.WriteLine($"Price:{itemPrices[i]}");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("");
                        
                    }
                    Console.WriteLine("press any key to go back home....");
                    Console.ReadKey();

                    Console.Clear();
                }

            }
            static void Exit()
            {
                Console.WriteLine("Thanks for visiting.....");
                Console.WriteLine("");
                Console.WriteLine("press e for exit or c for complain: ");                          //what if i put any key to go exit and only one specific key for complain 
                char endingChoise = char.Parse(Console.ReadLine());

                if (endingChoise == 'c')
                {

                    Console.WriteLine("If u have any complain sumbit it .....");
                    Console.WriteLine("");

                    Console.WriteLine("Write your complain without any hasitation:-  ");
                    string complain = Console.ReadLine();

                    Console.WriteLine("");
                    Console.Clear();
                    Console.WriteLine("Thanks for your complain we will  take action on it .....");
                   break;
                }
                else
                {
                    break;
                }
                    
            }
        }
    }
}