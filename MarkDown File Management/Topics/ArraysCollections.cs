using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicRunner.Topics
{
    static class ArraysCollections
    {
        public static void Topic01_Arrays()
        {
            TopicHelper.PrintingHeading("Arrays []");

            /* int num1 = 5, num2 = 10, num3 = 15, num4 = 30;
            int[] numbers = new int[3];

            Console.Write("Enter a number : ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number : ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number : ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number : ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter a {i + 1} number : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            } */

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angleCount; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum == 180 ? "Valid!" : "Invalid!");

            TopicHelper.PrintingEnding();
        }
        public static void Topic02_ArraySorting()
        {
            TopicHelper.PrintingHeading("Array sorting");

            int[] numbers = new int[] { 4, 7, 3, 1, 5, 9, 2, 8, 6 };

            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic03_ArrayReverse()
        {
            TopicHelper.PrintingHeading("Array reverse");

            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.Reverse(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic04_ArrayCleaning()
        {
            TopicHelper.PrintingHeading("Array cleaning");

            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.Clear(numbers, 0, numbers.Length);

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic05_ArrayIndexOf()
        {
            TopicHelper.PrintingHeading("Array IndexOf");

            int[] numebrs = new int[] { 90, 199, 22, 50, 30 };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            // int position = Array.IndexOf(numebrs, search);
            // int position = Array.IndexOf(numebrs, search, 2);
            int position = Array.IndexOf(numebrs, search, 1, 2);

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been fount at position {position + 1}.");
            }
            else
            {
                Console.WriteLine($"Number {search} has been not found!");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic06_Lists()
        {
            TopicHelper.PrintingHeading("Lists <>");

            int[] numbers = new int[] { 1, 2, 3 };

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            // listNumbers.(have all methods)

            TopicHelper.PrintingEnding();
        }
        public static void Topic07_Dictionary()
        {
            TopicHelper.PrintingHeading("Dictionary");

            /*Dictionary<int, string> names = new Dictionary<int, string>();
    names.Add(1, "Kartik");
    names.Add(2, "Aryan");
    names.Add(3, "Vivek");*/

            /*Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "Kartik"},
                {2, "Aryan"},
                {3, "Paresh"},
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Console.WriteLine();

            foreach (KeyValuePair<int, string> pair in names)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Karik"},
                {"Science", "Aryan"}
            };

            // Console.WriteLine(teachers["Math"]);
            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found!");
            }

            foreach (var pair in teachers)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic08_ExerciseOddEvenNumberSplit()
        {
            TopicHelper.PrintingHeading("Exercise: Odd/Even number split");

            /*
            * Create a two list with integer data type, one for even, one for odd
            * Loop from 0-20
            * if number is even, add to even list
            * if number is odd, add to odd list
            * Print even list
            * print odd list
            */  

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Printing even numbers:");
            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("Printing odd numbers: ");
            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic09_ExerciseArrayOfMultiples()
        {
            TopicHelper.PrintingHeading("Exercise: Array of multiples");

            /*
            * Define and initialise two integers (num, length)
            * (7,5) -> [7, 14, 21, 28, 35]
            * create int array with size length
            * loop through and insert the (loop counter x num) into the array
            * print final array
            */

            int num = 7, length = 5;
            int[] result = new int[length];

            for (int i = 1; i <= result.Length; i++)
            {
                result[i - 1] = num * i;
            }
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            TopicHelper.PrintingEnding();
        }
    }
}
