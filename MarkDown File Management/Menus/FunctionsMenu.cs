using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class FunctionsMenu
    {
        public static void Display()
        {
            bool looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("          FUNCTIONS MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Function (Basic)\n" +
                    "2. Void Function\n" +
                    "3. Return type function\n" +
                    "4. Function parameter\n" +
                    "5. Optional parameters\n" +
                    "6. Named parameter\n" +
                    "7. Out parameters\n" +
                    "8. Reference Parameter\n" +
                    "9. Exercise: Area of Triangle\n" +
                    "10. Exercise: Sum of int Array");
                Console.WriteLine();
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-10): ");

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
                    Functions.Topic01_FunctionBasic();
                    break;

                case 2:
                    Functions.Topic02_VoidFunction();
                    break;

                case 3:
                    Functions.Topic03_ReturnTypeFunction();
                    break;

                case 4:
                    Functions.Topic04_FunctionParameter();
                    break;

                case 5:
                    Functions.Topic05_OptionalParameters();
                    break;

                case 6:
                    Functions.Topic06_NamedParameter();
                    break;

                case 7:
                    Functions.Topic07_OutParameters();
                    break;

                case 8:
                    Functions.Topic08_ReferenceParameter();
                    break;

                case 9:
                    Functions.Topic09_ExerciseAreaOfTriangle();
                    break;

                case 10:
                    Functions.Topic10_ExerciseSumOfIntArray();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
