using TopicRunner.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicRunner.Menus
{
    static class MainMenu
    {
        public static void Display()
        {
            bool looping = true;

            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("     C# LEARNING TOPIC MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Basics");
                Console.WriteLine("2. Conditions & Loops");
                Console.WriteLine("3. Strings");
                Console.WriteLine("4. Arrays & Collections");
                Console.WriteLine("5. Functions");
                Console.WriteLine("6. Exception Handling");
                Console.WriteLine("7. Object-Oriented Programming");
                Console.WriteLine();
                Console.WriteLine("0. Exit");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-7): ");
                int.TryParse(Console.ReadLine(), out int choice);
                if (choice == 0)
                {
                    looping = false;
                }
                else
                {
                    HandleChoice(choice);
                }
            }

        }

        static void HandleChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    BasicsMenu.Display();
                    break;

                case 2:
                    ConditionsLoopsMenu.Display();
                    break;

                case 3:
                    StringsMenu.Display(); 
                    break;

                case 4:
                    ArraysCollectionsMenu.Display();
                    break;

                case 5:
                    FunctionsMenu.Display(); 
                    break;

                case 6:
                    ExceptionHandlingMenu.Display(); 
                    break;

                case 7:
                    OOPMenu.Display();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
