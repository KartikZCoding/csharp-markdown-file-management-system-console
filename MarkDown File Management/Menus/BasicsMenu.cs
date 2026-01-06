using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class BasicsMenu
    {
        public static void Display()
        {
            bool looping = true;

            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("          BASICS MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Numeric Data Types");
                Console.WriteLine("2. Text based Data Types");
                Console.WriteLine("3. Converting string to number");
                Console.WriteLine("4. Boolean Data Type");
                Console.WriteLine("5. Operators (+ - * /)");
                Console.WriteLine("6. Remainder %");
                Console.WriteLine("7. Var Keyword");
                Console.WriteLine("8. Const keyword");
                Console.WriteLine();
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-8): ");
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
                    Basics.Topics01_NumericDataTypes();
                    break;
                case 2:
                    Basics.Topic02_TextDataTypes();
                    break;
                case 3:
                    Basics.Topic03_ConvertingString();
                    break;
                case 4:
                    Basics.Topic04_BooleanDataType();
                    break;
                case 5:
                    Basics.Topic05_Operators();
                    break;
                case 6:
                    Basics.Topic06_Remainder();
                    break;
                case 7:
                    Basics.Topic07_VarKeyword();
                    break;
                case 8:
                    Basics.Topic08_ConstKeyword();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        }

    }
}
