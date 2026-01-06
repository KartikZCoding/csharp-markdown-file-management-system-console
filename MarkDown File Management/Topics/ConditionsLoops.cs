using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicRunner.Topics
{
    static class ConditionsLoops
    {
        public static void Topic01_IfStatements()
        {
            Console.WriteLine();
            Console.WriteLine("=== IF STATEMENTS ===");
            Console.WriteLine();

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your age : ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and Your age is " + age);

            // == > >= < <= != || &&

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("Your between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or Older");
                }
            }

            TopicHelper.PrintingEnding();
        }

        public static void Topic02_SwitchStatements()
        {
            Console.WriteLine();
            Console.WriteLine("=== SWITCH STATEMENTS ===");
            Console.WriteLine();

            Console.Write("Enter a day of the week : ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid, enter a value between 1 and 7");
                    break;
            }

            TopicHelper.PrintingEnding();
        }

        public static void Topic03_ForLoops()
        {
            Console.WriteLine();
            Console.WriteLine("=== FOR LOOPS ===");
            Console.WriteLine();

            Console.Write("What do you want to repeat? : ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to say " + message + "? : ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }

            TopicHelper.PrintingEnding();
        }

        public static void Topic04_WhileLoops()
        {
            Console.WriteLine();
            Console.WriteLine("=== WHILE LOOPS ===");
            Console.WriteLine();

            Console.Write("Enter the first number : ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.Write("Whats the value of " + numberA + " X " + numberB + " ? ");
            Console.WriteLine();

            do
            {
                Console.Write("Enter your answer : ");
                actualAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAnswer)
                {
                    Console.WriteLine("it was wrong!");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");

            TopicHelper.PrintingEnding();
        }

        public static void Topic05_ConditionalOperator()
        {
            Console.WriteLine();
            Console.WriteLine("=== CONDITIONAL OPERATOR (?) ===");
            Console.WriteLine();

            int age = 10;

            // condition ? true : false
            string result = age >= 0 ? "Valid!" : "Invalid!";
            Console.WriteLine(result);

            TopicHelper.PrintingEnding();
        }
    }
}
