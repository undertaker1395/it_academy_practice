using System;

namespace Motocycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Motocycle
    {
        public Motocycle(string mod, string prod, int mil)
        {
            Guid serialNum = Guid.NewGuid();
            string model = mod;
            string producer = prod;
            int issueYear = DateTime.Now.Year;
            int milage = mil;
        }
        
       

        private void Reset()
        {
            Motocycle.
        }

        class Engine
        {
            int volume = 0;
            int power = 0;
        }
    }
}
