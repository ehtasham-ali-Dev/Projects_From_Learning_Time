namespace BlackBoxOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booting();
            DrawOSBanner();

        }
        static void Booting()
        {
            Console.WriteLine("Booting BlackBox OS...");
            for (int i = 0; i <= 100; i += 10)
            {
                Console.Write($"/rLoading... {i}%");
                Thread.Sleep(200);
            }
            Console.Clear();
        }
        static void DrawOSBanner()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(@"  ____  _               _____ _  ______   ______   __   ____   _____ 
 |  _ \| |        /\   / ____| |/ /  _ \ / __ \ \ / /  / __ \ / ____|
 | |_) | |       /  \ | |    | ' /| |_) | |  | \ V /  | |  | | (___  
 |  _ <| |      / /\ \| |    |  < |  _ <| |  | |> <   | |  | |\___ \ 
 | |_) | |____ / ____ \ |____| . \| |_) | |__| / . \  | |__| |____) |
 |____/|______/_/    \_\_____|_|\_\____/ \____/_/ \_\  \____/|_____/ 
                                                                     
                                                                     ");
            Console.ResetColor();

            Console.WriteLine("Welcome to BlackBox OS!");

        }
        

    static void Home()
        {
            Console.WriteLine("1)OpenTerminal");
            Console.WriteLine("2)Notes");
            Console.WriteLine("3)Calculator");
            Console.WriteLine("4)Shutdown");
            int choise=int.Parse(Console.ReadLine());
            switch( choise )
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    
                    break;
            }
            
        }
        

    }
}
