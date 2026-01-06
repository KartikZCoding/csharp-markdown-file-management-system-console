using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class OOPMenu
    {
        public static void Display()
        {
            bool looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("  OBJECT ORIENTED PROGRAMMING MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Structures\n" +
                    "2. Classes\n" +
                    "3. Methods\n" +
                    "4. Class fields\n" +
                    "5. Class properties\n" +
                    "6. ToString function override");
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
                    OOP.Topic01_Structures();
                    break;

                case 2:
                    OOP.Topic02_Classes();
                    break;

                case 3:
                    OOP.Topic03_Methods();
                    break;

                case 4:
                    OOP.Topic04_ClassFields();
                    break;

                case 5:
                    OOP.Topic05_ClassProperties();
                    break;

                case 6:
                    OOP.Topic06_ToStringFunctionOverride();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
