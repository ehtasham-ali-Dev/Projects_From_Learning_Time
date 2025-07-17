
using FormatorsAppNew.Properties;
using System;
using System.Globalization;

using System.Media;   // it will help us to read audio file 
using System.Resources;
namespace FormatorsAppNew
{

    
   
        internal class Program
        {
            private static void Main(string[] args)
            {
                // for a while i turn off typing sound due to erros ......

                //SoundPlayer typingSoundPlayer = new SoundPlayer(Resources.KBSound);


                //typingSoundPlayer.Play();

                Console.ReadLine();

                string IntroText = "Hallo Dear User! \nI hope you will be very well";
                Console.ForegroundColor = ConsoleColor.Green;


                foreach (char c in IntroText)
                {
                    Console.Write(c);

                    //typingSoundPlayer.Play();

                    Thread.Sleep(50);
                }

                Console.WriteLine("!!!!please tell me what i can do from these three options "); ;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n 1:-Show Date \n2:-Show Time\n3:-Show me currencies ");
                string chooice = Console.ReadLine();
                switch (chooice)
                {
                    case "1":
                        Console.WriteLine("Good! Now tell me in which formate you want Date  ");
                        Console.WriteLine("1:- Day/Month/Year \n2:-Day and  Month \n3:-Full Date with time ");
                        string ChooseDatePattren = Console.ReadLine();
                        switch (ChooseDatePattren)
                        {
                            case "1":
                                Console.WriteLine("Today is : {0:d}", DateTime.Now);
                                break;
                            case "2":
                                Console.WriteLine("Today is : {0:M}", DateTime.Now);
                                break;
                            case "3":
                                Console.WriteLine("Today is : {0:F}", DateTime.Now);
                                break;
                            default:
                                Console.WriteLine("!!!!Error You choose a wrong chooice!!! ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Good! Now tell me in which formate you want Time ");
                        Console.WriteLine("1:- (21:19)This type \n2:- short date and time\n3:-RFC1123 pattern ");
                        string ChooseTimePattren = Console.ReadLine();
                        switch (ChooseTimePattren)
                        {
                            case "1":
                                Console.WriteLine("Today is : {0:t}", DateTime.Now);
                                break;
                            case "2":
                                Console.WriteLine("Today is : {0:G}", DateTime.Now);
                                break;
                            case "3":
                                Console.WriteLine("Today is : {0:R}", DateTime.Now);
                                break;
                            default:
                                Console.WriteLine("!!!!Error You choose a wrong chooice!!! ");
                                Console.ForegroundColor = ConsoleColor.Red;

                                break;

                        }
                        break;

                    case "3":
                        Console.WriteLine("Good! Now tell me about the country you are wanting  to see currency:-  ");
                        string CountryName = Console.ReadLine().ToLower();
                        switch (CountryName)
                        {
                            case "pakistan":
                            case "pk":
                                CultureInfo cultureInfo = new CultureInfo("ur-PK");
                                Console.WriteLine("Currency for Pakistan:Ruppes and it's symbol is {0}", cultureInfo.NumberFormat.CurrencySymbol);
                                break;
                            case "united kingdom":
                            case "uk":
                                CultureInfo ukCultureInfo = new CultureInfo("en-GB");
                                Console.WriteLine("Currency for United Kingdom:Pounds and it's sybmol is  {0}", ukCultureInfo.NumberFormat.CurrencySymbol);
                                break;
                            case "us":
                            case "USA":
                            case "unitedstates":
                            case "america":

                                CultureInfo usCulutreInfo = new CultureInfo("en-US");
                                Console.WriteLine("Currency for United States: {0}", usCulutreInfo.NumberFormat.CurrencySymbol);

                                break;


                            default:
                                Console.WriteLine("!!!!Sorry now we are not able to tell you about {0} .But in future we will add more data in our DataBase.\n I hope you will not mind .May God bless you . !!!!", CountryName);
                                Console.ForegroundColor = ConsoleColor.Red;

                                break;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("\n!!!Opps '{0}' is  Wrong input ,now this program will be terminate !!!!!!", chooice);

                        break;




                }
                Console.WriteLine("\n============================================================\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

