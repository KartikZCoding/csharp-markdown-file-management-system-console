using MarkDown_File_Management.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopicRunner.Topics
{
    static class Basics
    {
        public static void Topics01_NumericDataTypes()
        {
            TopicHelper.PrintingHeading("Numeric Data type");

            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            long bigNumber = 9000000000000L;
            Console.WriteLine(bigNumber);
            double negative = -55.2D;
            Console.WriteLine(negative);
            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            decimal money = 14.99M;
            Console.WriteLine(money);

            TopicHelper.PrintingEnding();
        }

        public static void Topic02_TextDataTypes()
        {
            TopicHelper.PrintingHeading("TEXT BASED DATA TYPES");

            string name = "Kartik";
            char letter = 'a';

            Console.WriteLine("Your name is : " + name);
            Console.WriteLine(name);
            Console.WriteLine(letter);

            TopicHelper.PrintingEnding();
        }

        public static void Topic03_ConvertingString()
        {
            TopicHelper.PrintingHeading("CONVERTING STRING TO NUMBER");

            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-900000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.43";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);

            string textPrecision = "5.0000001";
            float precision = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            TopicHelper.PrintingEnding();
        }

        public static void Topic04_BooleanDataType()
        {
            TopicHelper.PrintingHeading("BOOLEAN DATA TYPE");

            bool value = true;
            bool isMale = true;
            Console.WriteLine(isMale);

            isMale = false;
            Console.WriteLine(isMale);

            TopicHelper.PrintingEnding();
        }

        public static void Topic05_Operators()
        {
            TopicHelper.PrintingHeading("OPERATORS (+ - * /)");

            int age = 23; // used for + - *

            // age++;
            // age = age + 10;
            // + - * /
            age += 10;
            Console.WriteLine(age);

            double age1 = 23; // used for /
            age1 /= 10;
            Console.WriteLine(age1);

            // age--;
            // Console.WriteLine(age);

            string name = "Kartik ";
            name += "is programming"; // concating
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i);

            TopicHelper.PrintingEnding();
        }

        public static void Topic06_Remainder()
        {
            TopicHelper.PrintingHeading("REMAINDER %");

            int firstNum = 10;
            int secondNum = 2;

            // 10 / 3 = 3r1
            // 3 X 3 = 9, 1 left over to get to 10

            Console.WriteLine(firstNum % secondNum);
            Console.WriteLine(1000 % 90);
            Console.WriteLine(100 % 90);
            Console.WriteLine(71 % 10);

            TopicHelper.PrintingEnding();
        }

        public static void Topic07_VarKeyword()
        {
            TopicHelper.PrintingHeading("VAR KEYWORD");

            // int age = -23;
            var age = 23;
            Console.WriteLine(age);

            // long bigNumber = 9000000000000L;
            var bigNumber = 90000000000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.000001F;
            Console.WriteLine(precision);

            var money = 14.99M;
            Console.WriteLine(money);

            var name = "Kartik";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);

            TopicHelper.PrintingEnding();
        }

        public static void Topic08_ConstKeyword()
        {
            TopicHelper.PrintingHeading("Const Keyword");

            const int vat = 20;
            const double precentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * precentVAT);

            const string version = "v1.0";

            Console.WriteLine(vat);

            TopicHelper.PrintingEnding();
        }
    }
}
