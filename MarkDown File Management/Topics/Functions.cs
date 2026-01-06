using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicRunner.Topics
{
    static class Functions
    {
        public static void Topic01_FunctionBasic()
        {
            TopicHelper.PrintingHeading("Function (Basic)");

            WelcomeMessage0();
            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static void WelcomeMessage0()
        {
            Console.WriteLine("Welcome Kartik");
        }

        public static void Topic02_VoidFunction()
        {
            TopicHelper.PrintingHeading("Void Function");

            WelcomeMessage1();
            CreateAndPrintArray();

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static void CreateAndPrintArray()
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4 };

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }

        private static void WelcomeMessage1()
        {
            Console.WriteLine("Welcome to my program");
        }

        public static void Topic03_ReturnTypeFunction()
        {
            TopicHelper.PrintingHeading("Return type function");

            Console.Title = $"{ReturnName()} - {ReturnAge()}";
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                //cw
                numbers[i] = ReadNumbersFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            int[] newNumbers = CreateArray();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static int[] CreateArray()
        {
            return new int[3] { 1, 2, 3 };
        }
        private static int ReadNumbersFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static string ReturnName()
        {
            return "Kartik Ahir";
        }
        private static int ReturnAge()
        {
            return 21;
        }
        private static void PrintIntroduction()
        {
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }

        public static void Topic04_FunctionParameter()
        {
            TopicHelper.PrintingHeading("Function parameter");

            Console.WriteLine(Add(5, 5));

            int num = ReadInt("Enter a number");
            Console.WriteLine(num);

            int angle = ReadInt("Enter a angle");
            Console.WriteLine(angle);

            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");
            int result = Add(firstNum, secondNum);
            Console.WriteLine(result);


            string name = ReadString("Enter your name");
            int age = ReadInt("Enter your age");
            string details = UserDetails(name, age);
            Console.WriteLine(details);


            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}!";
        }
        private static string ReadString(string message)
        {
            Console.Write($"{message} : ");
            return Console.ReadLine();
        }
        private static int ReadInt(string message)
        {
            Console.Write($"{message} : ");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static int Add(int a, int b)
        {
            return a + b;
        }

        public static void Topic05_OptionalParameters()
        {
            TopicHelper.PrintingHeading("Optional parameters");

            int result = Add1(5, 10);
            Console.WriteLine(result);

            PrintName();

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static void PrintName(string name = "Joe")
        {
            Console.WriteLine($"My name is {name}");
        }

        private static int Add1(int a, int b = default)
        {
            return a + b;
        }

        public static void Topic06_NamedParameter()
        {
            TopicHelper.PrintingHeading("Named parameter");

            string nameInput = "Kartik";
            int ageInput = 23;
            string addressInput = "1 something road";

            PrintDetails(name: nameInput,
                            address: addressInput,
                            age: ageInput
                            );

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Address : {address}");

        }

        public static void Topic07_OutParameters()
        {
            TopicHelper.PrintingHeading("Out parameters");

            int num = 0;
            test(out num); // without out num 0 with out num 5
            Console.WriteLine(num);

            List<string> shoppingList = new List<string>
        {
            "Coffee", "Milk"
        };

            Console.Write("Enter an item to search : ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Fount {search} at index {index}");
            }
            else
            {
                Console.WriteLine("Not found!!");
            }


            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }

        private static void test(out int num)
        {
            num = 5;
        }

        public static void Topic08_ReferenceParameter()
        {
            TopicHelper.PrintingHeading("Reference Parameter");

            int num = 10;
            string name = "Kartik";

            Assign(ref num, ref name);

            Console.WriteLine($"{num} : {name}");

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null");
            }

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }
        private static void Assign(ref int num, ref string name)
        {
            num = 20;
            name = "Kartik Ahir";
        }

        public static void Topic09_ExerciseAreaOfTriangle()
        {
            TopicHelper.PrintingHeading("Exercise: Area of Triangle");

            /*
            * Ask user for width and height, store them
            * Create function to calculate the area
            * function should calculate the area using : (width * height) / 2
            * Call in main and print out the are of the triangle
            */

            int width = ReadInt1("Enter width");
            int height = ReadInt1("Enter height");

            Console.WriteLine($"{width} : {height}");

            Console.WriteLine($"The area is {CalcArea(width, height)}");


            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static int CalcArea(int width, int height)
        {
            return (width * height) / 2;
        }
        private static int ReadInt1(string s)
        {
            Console.Write($"{s} : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Topic10_ExerciseSumOfIntArray()
        {
            TopicHelper.PrintingHeading("Exercise: Sum of int Array");

            /*
           * create a initialise int array of number
           * create function SumOfNumbers with int return type
           * int array param
           * function should return total of all numbers
           * call in main and output the total
           * extra : chech array length
           *   return -1 if array empty
           *   check return in main and output message
           *   do we need to return -1, how else can we make this?
           */

            int[] numbers = new int[]
            {
            1,2,3,4,5
            };

            int result = SumOfNumbers(numbers);

            if (result > -1) // that create a issue when array is empty
            {
                Console.WriteLine($"The total is : {result}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!!");
            }

            if (SumOfNumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is : {total}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array!!");
            }

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        private static int SumOfNumbers(int[] numbers) // that create a issue when array is empty
        {
            if (numbers.Length > 0)
            {
                int total = 0;

                foreach (int number in numbers)
                {
                    total += number;
                }

                return total;
            }
            return -1;
        }

        private static bool SumOfNumbers(int[] numbers, out int total)
        {
            total = 0;
            if (numbers.Length > 0)
            {
                foreach (int number in numbers)
                {
                    total += number;
                }

                return true;
            }
            return false;
        }
    }
}
