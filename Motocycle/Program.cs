using System;

namespace Motocycle
{
    class Program
    {
        static Motocycle[] motocycles;
        
        static void PrintMoto(Motocycle motocycle) 
        {
            Console.WriteLine("{6}. Мотоцикл(Производитель): {0}, Модель: {1}, Идентификатор: {2}, Год: {3}\n{6}.1 Двигатель(Объём): {4}, Мощьность: {5}",
                motocycle.producer, motocycle.model, motocycle.serialNum, motocycle.issueYear, motocycle.Engine.volume, motocycle.Engine.power, motocycle.num)
        }

        static void Main(string[] args)
        {
            motocycles = new Motocycle[3];
            foreach(int m in motocycles)
            {
                motocycles[m] = new Motocycle();
                motocycles[m].num = m + 1;
                readonly motocycles[m].serialNum = new Guid();
                motocycles[m].issueYear = DateTime.Now.Year;
                Console.WriteLine("Укажите модель мотоцикла");
                motocycles[m].model = Console.ReadLine();
                Console.WriteLine("Укажите производителя мотоцикла");
                motocycles[m].producer = Console.ReadLine();
                Console.WriteLine("Укажите пробег мотоцикла");
                motocycles[m].milage = Console.ReadLine();
                Console.WriteLine("Укажите объём двигателя");
                motocycles[m].Engine.volume = Console.ReadLine();
                Console.WriteLine("Укажите мощность двигателя");
                motocycles[m].Engine.power = Console.ReadLine();
            }

            PrintMoto(motocycles[0]);
            PrintMoto(motocycles[1]);
            PrintMoto(motocycles[2]);
        }
    }

    class Motocycle
    {
        internal Guid serialNum;
        internal string model;
        internal string producer;
        internal int issueYear = DateTime.Now.Year;
        internal int milage;
        internal int num;
    
        
       

        private void Reset()
        {
            
        }

        internal class Engine
        {
            internal int volume;
            internal int power;
        }
    }
}
