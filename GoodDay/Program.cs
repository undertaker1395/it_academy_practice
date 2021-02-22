using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            if (greeting.Hours(DateTime.Now.TimeOfDay) < 12 && greeting.Hours(DateTime.Now.TimeOfDay) >= 9)
            {
                Console.WriteLine(DateTime.Now.TimeOfDay);
                Console.WriteLine("Good Morning, guys");
            }

            if (greeting.Hours(DateTime.Now.TimeOfDay) < 15 && greeting.Hours(DateTime.Now.TimeOfDay) >= 12)
            {
                Console.WriteLine(DateTime.Now.TimeOfDay);
                Console.WriteLine("Good day, guys");
            }

            if (greeting.Hours(DateTime.Now.TimeOfDay) < 22 && greeting.Hours(DateTime.Now.TimeOfDay) >= 15)
            {
                Console.WriteLine(DateTime.Now.TimeOfDay);
                Console.WriteLine("Good evening, guys");
            }
            else
            {
                Console.WriteLine(DateTime.Now.TimeOfDay);
                Console.WriteLine("Why are you not sleeping? You need get up early");
            }
        }
    }
    class Greeting
    {
        public int Hours(TimeSpan dayTime)
        {
            int h = dayTime.Hours;
            return h;
        }
    }
}
