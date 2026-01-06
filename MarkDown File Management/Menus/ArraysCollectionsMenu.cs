using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class ArraysCollectionsMenu
    {
        public static void Display()
        {
            bool looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("      ARRAY & COLLECTIONS MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Arrays []\n" +
                    "2. Array sorting\n" +
                    "3. Array reverse\n" +
                    "4. Array cleaning\n" +
                    "5. Array IndexOf\n" +
                    "6. Lists <>\n" +
                    "7. Dictionary\n" +
                    "8. Exercise: Odd/Even number split\n" +
                    "9. Exercise: Array of multiples");
                Console.WriteLine();
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-9): ");

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
                    ArraysCollections.Topic01_Arrays();
                    break;

                case 2:
                    ArraysCollections.Topic02_ArraySorting();
                    break;

                case 3:
                    ArraysCollections.Topic03_ArrayReverse();
                    break;

                case 4:
                    ArraysCollections.Topic04_ArrayCleaning();
                    break;

                case 5:
                    ArraysCollections.Topic05_ArrayIndexOf();
                    break;

                case 6:
                    ArraysCollections.Topic06_Lists();
                    break;

                case 7:
                    ArraysCollections.Topic07_Dictionary();
                    break;

                case 8:
                    ArraysCollections.Topic08_ExerciseOddEvenNumberSplit();
                    break;

                case 9:
                    ArraysCollections.Topic09_ExerciseArrayOfMultiples();
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
