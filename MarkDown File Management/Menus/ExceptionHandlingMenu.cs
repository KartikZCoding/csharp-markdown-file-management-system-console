using TopicRunner.Topics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class ExceptionHandlingMenu
    {
        public static void Display()
        {
            bool looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("       EXCEPTION HANDLING MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Exception Handling (Basics)");
                Console.WriteLine("2. Try...catch");
                Console.WriteLine("3. Printing error message");
                Console.WriteLine("4. Exercise: Custom TryParse");
                Console.WriteLine();
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-4): ");

                int.TryParse(Console.ReadLine(), out int choice);

                if (choice == 0)
                {
                    looping = false;
                }
                else
                {
                    HandleChoice(choice);
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static void HandleChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    ExceptionHandling.Topic01_ExceptionHandlingBasics();
                    break;

                case 2:
                    ExceptionHandling.Topic02_TryCatch();
                    break;

                case 3:
                    ExceptionHandling.Topic03_PrintingErrorMessage();
                    break;

                case 4:
                    ExceptionHandling.Topic04_ExerciseCustomTryParse();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
