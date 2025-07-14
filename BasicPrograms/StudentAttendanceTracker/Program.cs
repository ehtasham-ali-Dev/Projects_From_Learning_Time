namespace StudentAttendanceTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Student Attendance Tracker---");
            Console.ResetColor();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Enter Number Of students: ");
            int numberOfStudents=Convert.ToInt32(Console.ReadLine());

            string[] studentName = new string[numberOfStudents];
            char[]attendence = new char[numberOfStudents];

            for (int i = 0;i< numberOfStudents; i++)
            {
                Console.WriteLine($"Enter name of student {i+1}: ");
                studentName[i] = Console.ReadLine();

            }
            Console.WriteLine("Type A for absent and type p for present: ");
            
            for (int i = 0; i< numberOfStudents; i++)
            {
                Console.WriteLine($"Is {studentName[i]} present? (P/A): ");
                attendence[i] = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"{studentName[i]}-{(attendence[i] == 'p' ? "present" : "Abesent")}");
                Console.WriteLine("");
            }
            Console.WriteLine("Report");
            Console.WriteLine("");

            int present = 0; int absent = 0;
            for (int i=0; i< numberOfStudents; i++)
            {
                Console.WriteLine($"{studentName[i]}-{(attendence[i] == 'p' ? "present" : "Abesent")}");
                if (attendence[i] == 'p')
                {
                    present++;
                }
                else
                {
                    absent++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("=======================");
                Console.WriteLine("Total students: {0}",numberOfStudents);
                Console.WriteLine("Presnt students: {0}", present);
                Console.WriteLine("Absent students: {0}", absent);
            

        }
    }
}
