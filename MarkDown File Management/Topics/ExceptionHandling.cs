using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopicRunner.Topics;

namespace TopicRunner.Topics
{
    static class ExceptionHandling
    {
        public static void Topic01_ExceptionHandlingBasics()
        {
            Console.WriteLine();
            Console.WriteLine("=== EXCEPTION HANDLING BASICS ===");
            Console.WriteLine();

            Console.Write("Enter a number : ");
            //when enter "[][]" then give exception or enter a big number like "2000000000000000" also a exception
            //that is unHandle exception
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num);

            Console.ReadLine();

            TopicHelper.PrintingEnding();
        }

        public static void Topic02_TryCatch()
        {
            Console.WriteLine();
            Console.WriteLine("=== TRY...CATCH ===");
            Console.WriteLine();

            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter number less than 2 billion");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something has went wrong!!");
                }
            }

            Console.WriteLine("Goodbye!!");

            TopicHelper.PrintingEnding();
        }

        public static void Topic03_PrintingErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("=== PRINTING ERROR MESSAGE ===");
            Console.WriteLine();

            try
            {
                Console.Write("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }

            TopicHelper.PrintingEnding();
        }

        public static void Topic04_ExerciseCustomTryParse()
        {
            Console.WriteLine();
            Console.WriteLine("=== EXERCISE CUSTOM TryParse ===");
            Console.WriteLine();

            Console.Write("Enter a number : ");
            if (CustomTryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yey " + result);
            }
            else
            {
                Console.WriteLine("Oh no!");
            }

            TopicHelper.PrintingEnding();
        }

        private static bool CustomTryParse(string input, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
