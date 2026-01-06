using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Menus
{
    static class ConditionsLoopsMenu
    {
        public static void Display()
        {
            bool looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("      CONDITIONS & LOOPS MENU");
                Console.WriteLine("======================================");
                Console.WriteLine("1. If statements");
                Console.WriteLine("2. Switch statements");
                Console.WriteLine("3. For loops");
                Console.WriteLine("4. While loops");
                Console.WriteLine("5. Conditional operator (?)");
                Console.WriteLine();
                Console.WriteLine("0. Back to Main Menu");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice (0-5): ");

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
                    ConditionsLoops.Topic01_IfStatements();
                    break;
                case 2:
                    ConditionsLoops.Topic02_SwitchStatements();
                    break;
                case 3:
                    ConditionsLoops.Topic03_ForLoops();
                    break;
                case 4:
                    ConditionsLoops.Topic04_WhileLoops();
                    break;
                case 5:
                    ConditionsLoops.Topic05_ConditionalOperator();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

    }
}
