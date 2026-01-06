using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TopicRunner.Topics
{
    static class Strings
    {
        public static void Topic01_ConsoleInputOutput()
        {
            TopicHelper.PrintingHeading("Console Input/Output");

            Console.WriteLine("Hello my name is Kartik!");

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

            Console.Write("Your name is ");
            Console.Write(name);
            Console.Write(" and Your age is ");
            Console.Write(age);

            Console.WriteLine("Your name is " + name + " and Your age is " + age);

            TopicHelper.PrintingEnding();
        }
        public static void Topic02_Numericformatting()
        {
            TopicHelper.PrintingHeading("Numeric formatting");

            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            // Console.WriteLine(string.Format("{0} {1}", value, 1000));
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double money = -10D / 3D; //3.33333333

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-IN")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));

            TopicHelper.PrintingEnding();

        }
        public static void Topic03_TryParseFunction()
        {
            TopicHelper.PrintingHeading("TryParse function");

            bool success = true;

            while (success)
            {
                Console.Write("Enter a number : ");
                string numInput = Console.ReadLine();

                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic04_VerbatimStringLiteral()
        {
            TopicHelper.PrintingHeading("Verbatim string literal (@)");

            // \t \n \" \\
            string speech = "He said \"something\"";
            Console.WriteLine(speech);
            string path = "D:\\Kartik Courses\\C# Course\nNew line test";
            Console.WriteLine(path);

            // $ +
            // $"your name is {name}"
            // "your name is" + name

            path = @"D:\Kartik Courses\C# Course" + "\nNew line test";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            TopicHelper.PrintingEnding();
        }
        public static void Topic05_StringFormatting()
        {
            TopicHelper.PrintingHeading("String formatting ({0})");

            string name = "Kartik";
            int age = 21;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();
            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);

            TopicHelper.PrintingEnding();
        }
        public static void Topic06_StringInterpolation()
        {
            TopicHelper.PrintingHeading("String interpolation ($)");

            string name = "Kartik";
            int age = 21;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine($"Your name is {name}, and your age is {age}");

            TopicHelper.PrintingEnding();
        }
        public static void Topic07_StringConcatenation()
        {
            TopicHelper.PrintingHeading("String concatenation (+)");

            string name = "Kartik";
            int age = 21;

            Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", age));

            string[] names = new string[] { "Kartik ", "Ahir ", "Test" };
            Console.WriteLine(string.Concat(names));

            TopicHelper.PrintingEnding();
        }
        public static void Topic08_EmptyString()
        {
            TopicHelper.PrintingHeading("Empty string");

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}.");
            }
            else
            {
                Console.WriteLine("Name is empty!");
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic09_StringEqualsFunction()
        {
            TopicHelper.PrintingHeading("String Equals function");

            string message = "Hello";
            string compare = "Helloo";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            if (!name.Equals(""))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Invalid name input!");
            }

            // == this check also a memory
            // .Equals() this check only values so use this!!

            TopicHelper.PrintingEnding();
        }
        public static void Topic10_StringIterationLooping()
        {
            TopicHelper.PrintingHeading("String iteration (looping)");

            string message = "C# is awesome";
            // Console.WriteLine(message[0]);
            // Console.WriteLine(message[1]);
            // Console.WriteLine(message[2]);
            // Console.WriteLine(message[3]);

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(150);
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            TopicHelper.PrintingEnding();
        }
        public static void Topic11_StringIsNullOrEmptyFunction()
        {
            TopicHelper.PrintingHeading("String isNullOrEmpty function");

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            if (!string.IsNullOrEmpty(name)) //check both null and empty ""
            {
                if (name.Equals("Kartik"))
                {
                    Console.WriteLine("Correct!");
                }
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic12_ExercisePrintStringInReverse()
        {
            TopicHelper.PrintingHeading("Exercise: Print string in reverse");

            /*
            * Ask user to input message
            * Print in order
            * Print in reverse
            */

            Console.Write("Enter your message : ");
            string message = Console.ReadLine();

            /*for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
            }*/
            Console.WriteLine(message);

            Console.WriteLine();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }

            TopicHelper.PrintingEnding();
        }
        public static void Topic13_ExercisePasswordChecker()
        {
            TopicHelper.PrintingHeading("Exercise: Password checker");

            /*
            * ask user to enter password, and store
            * ask user to enter password again, and store
            * check if they are both contain something
            *   if so check if they are the same
            *       if they are, print "password match"
            *       if they are not, print "password do not match"
            *   if they are empty, print "please enter a password"
            */

            Console.Write("Enter your password : ");
            string password = Console.ReadLine();

            Console.Write("Enter your password again : ");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Password Match!");
                        }
                        else
                        {
                            Console.WriteLine("Password do not match!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }

            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            TopicHelper.PrintingEnding();
        }
    }

}
