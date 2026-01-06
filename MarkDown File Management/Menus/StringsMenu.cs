using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class StringsMenu
    {
        public static void Display()
        {
            bool looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("             STRINGS MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Console Input/Output\n" +
                    "2. Numeric formatting\n" +
                    "3. TryParse function\n" +
                    "4. Verbatim string literal (@)\n" +
                    "5. String formatting ({0})\n" +
                    "6. String interpolation ($)\n" +
                    "7. String concatenation (+)\n" +
                    "8. Empty string\n" +
                    "9. String Equals function\n" +
                    "10. String iteration (looping)\n" +
                    "11. String isNullOrEmpty function\n" +
                    "12. Exercise: Print string in reverse\n" +
                    "13. Exercise: Password checker");
                Console.WriteLine();
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-13): ");

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
                    Strings.Topic01_ConsoleInputOutput();
                    break;

                case 2:
                    Strings.Topic02_Numericformatting();
                    break;

                case 3:
                    Strings.Topic03_TryParseFunction();
                    break;

                case 4:
                    Strings.Topic04_VerbatimStringLiteral();
                    break;

                case 5:
                    Strings.Topic05_StringFormatting();
                    break;

                case 6:
                    Strings.Topic06_StringInterpolation();
                    break;

                case 7:
                    Strings.Topic07_StringConcatenation();
                    break;

                case 8:
                    Strings.Topic08_EmptyString();
                    break;

                case 9:
                    Strings.Topic09_StringEqualsFunction();
                    break;

                case 10:
                    Strings.Topic10_StringIterationLooping();
                    break;

                case 11:
                    Strings.Topic11_StringIsNullOrEmptyFunction();
                    break;

                case 12:
                    Strings.Topic12_ExercisePrintStringInReverse();
                    break;

                case 13:
                    Strings.Topic13_ExercisePasswordChecker();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
