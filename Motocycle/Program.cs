using System;

namespace Motocycle
{
    class Program
    {
        static Motocycle[] motocycles;
        static Engine[] engines;
        

        static void PrintMoto(Motocycle motocycle)
        {
            Console.WriteLine("{6}. Мотоцикл(Производитель): {0}, Модель: {1}, Идентификатор: {2}, Год: {3}\n{6}.1 Двигатель(Объём): {4}, Мощьность: {5}",
                motocycle.producer, motocycle.model, motocycle.serialNum, motocycle.issueYear, motocycle.engine.volume, motocycle.engine.power, motocycle.num);
        }

        static void Main(string[] args)
        {
            motocycles = new Motocycle[3];
            engines = new Engine[3];
            
            for (int m = 0; m < 3;  m++)
            {
                motocycles[m] = new Motocycle();
                engines[m] = new Engine();
                motocycles[m].num = m + 1;
                motocycles[m].serialNum = Guid.NewGuid();
                motocycles[m].issueYear = DateTime.Now.Year;
                Console.WriteLine("Укажите модель мотоцикла");
                motocycles[m].model = Console.ReadLine();
                Console.WriteLine("Укажите производителя мотоцикла");
                motocycles[m].producer = Console.ReadLine();
                Console.WriteLine("Укажите пробег мотоцикла");
                motocycles[m].milage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите объём двигателя");
                motocycles[m].engine.volume = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите мощность двигателя");
                motocycles[m].engine.power = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++) PrintMoto(motocycles[i]);
           
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
        internal Engine engine;
    
        
       

        private void Reset()
        {
            
        }

    }
    class Engine
    {
        internal int volume;
        internal int power;
    }
}
