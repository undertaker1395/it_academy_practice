using System;

namespace lecture_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            string result = str.ShortString(str);
            Console.WriteLine(result);
        }
    }

    public static class StringExtension
    {
        public static string ShortString(this string str, string longString)
        {
            string shortString = longString.Substring(0, 4) + "...";
            return shortString;
        }
    }
}
