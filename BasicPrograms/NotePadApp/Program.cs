using System;
using System.IO;

namespace NotepadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackBox Notepad!");
            Console.WriteLine("Start typing your notes. Type 'SAVE' to save and exit.");

            string filePath = "notes.txt";  // File jisme data save hoga
            StreamWriter writer = new StreamWriter(filePath); // File open for writing

            while (true)
            {
                string input = Console.ReadLine(); // User se ek line input lena

                if (input.ToUpper() == "SAVE") // Agar user 'SAVE' likhta hai
                {
                    break; // Loop se bahar nikal jao
                }

                writer.WriteLine(input); // Har line ko file mein likhna
            }

            writer.Close(); // File save & close karni zaroori hai
            Console.WriteLine("Your notes are saved in 'notes.txt'. Thank you!");
        }
    }
}
