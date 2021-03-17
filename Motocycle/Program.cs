using System;

namespace Motocycle
{
    class Program
    {
        static Motocycle[] motocycles;
        static Motocycle.Engine[] engines;
        
        static void PrintMoto(Motocycle motocycle, Motocycle.Engine engine)
        {
            Console.WriteLine("{6}. Мотоцикл(Производитель): {0}, Модель: {1}, Идентификатор: {2}, Год: {3}\n{6}.1 Двигатель(Объём): {4}, Мощьность: {5}",
                motocycle.producer, motocycle.model, motocycle.serialNum, motocycle.issueYear, engine.volume, engine.power, motocycle.num);
        }

        static void Main(string[] args)
        {
            motocycles = new Motocycle[3];
            engines = new Motocycle.Engine[3];
            
            for (int m = 0; m < 3;  m++)
            {
                motocycles[m] = new Motocycle();
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
                engines[m].volume = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Укажите мощность двигателя");
                engines[m].power = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++) PrintMoto(motocycles[i], engines[i]);
        }
    }

    class Motocycle
    {
        readonly Guid _serialNum;
        string _model;
        string _producer;
        int _issueYear;
        int _milage;
        internal int num;

        public Guid serialNum { get { return _serialNum; } set { } }
        public string model { get { return _model; } set { } }
        public string producer { get { return _producer; } set { } }
        public int issueYear { get { return _issueYear; } set { } }
        public int milage 
        { 
            get 
            { 
                return _milage; 
            }
            set 
            {
                if (value > 100)
                    _milage = 100;
                else
                    _milage = value;
            }
        }

        private void Reset()
        {
            
        }

        internal class Engine
        {
            int _volume;
            int _power;

            public int volume 
            {
                get { return _volume; }

                set 
                {
                    if (value < 125)
                        _volume = 125;
                    else if (value > 3200)
                        _volume = 3200;
                    else
                        _volume = value;
                }
            }
            public int power
            {
                get { return _volume; }

                set
                {
                    if (value < 50)
                        _power = 50;
                    else if (value > 300)
                        _power = 300;
                    else
                        _power = value;
                }
            }
        }
    } 
}
