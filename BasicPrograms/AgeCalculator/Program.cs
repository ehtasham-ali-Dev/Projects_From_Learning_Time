namespace AgeCalculator

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //these are the programs releted to just basic concepts like arthimatic operations,simple I/O and type casting 
            Console.WriteLine("Heye !! How are u ");
            Console.WriteLine("What's your name ");
            string nameOfPerson=Console.ReadLine();
            Console.WriteLine("What's Your year of birth");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

           
            int currentYear =DateTime.Now.Year;
            Console.Clear();

            int userAge = currentYear - birthYear; //This is a formula for age finding 
            Console.WriteLine("----------------------");
            Console.WriteLine("Heye " + nameOfPerson +" Your Age is : " + userAge);
            Console.WriteLine("----------------------");

        }
    }
}
