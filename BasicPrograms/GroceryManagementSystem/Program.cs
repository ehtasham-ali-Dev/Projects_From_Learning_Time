namespace GroceryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] addItemArray = new string[1000];   /*i'm using array with max size
                                                        1000 then i'll update it furthur more */


            // now i'll apply funtions here 


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
            Console.WriteLine("4) Exit Item");
            int chooise=int.Parse(Console.ReadLine());
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

                    }
                    break;
            }

        }

        static void AddProduct()
            {
            Console.WriteLine("---Add item here---");
            Console.WriteLine("Item name: ");
            string itemName=Console.ReadLine();

            Console.WriteLine("Quantity(e.g:- 1,2):  ");
            int itemQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Item Price: ");
           double ItemPrice=double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Press any key to og back home .....");
            Console.ReadKey();

            Home();

            }
        static void DisplayProductsDetails()
        {
            
        }

}
}
