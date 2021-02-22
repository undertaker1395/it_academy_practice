using System;

namespace PW._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string[] EmptyArray(string[] arr)
        {
            string[] emptyArr = new string[0];
            return emptyArr;
        }

        public string[] TriplArray(string[] arr)
        {
            int num = 32;
            char leter = 'a';
            string word = "Hello!";
            SomeType[] triplArr = new string[] {num, leter, word };
            return triplArr;
        }

        public int MaxArrVal(int max)
        {
            int[] maxValArr = new int[13];
            int maxVal = 0;
            Random rnd = new Random();
            for (int i = 0; i < maxValArr.Length; i++)
            {
                maxValArr[i] = rnd.Next(maxVal, 10);
                if (maxValArr[i] > maxVal) maxVal = maxValArr[i];
            }
            return maxVal;
        }
    }
}
