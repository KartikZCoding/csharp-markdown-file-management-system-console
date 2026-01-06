using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDown_File_Management.Helpers
{
    static class TopicHelper
    {
        public static void PrintingHeading(string msg)
        {
            Console.WriteLine();
            Console.WriteLine($"=== {msg.ToUpper()} ===");
            Console.WriteLine();
        }

        public static void PrintingEnding()
        {
            Console.WriteLine();
            Console.WriteLine("======================================");
        }
    }
}
