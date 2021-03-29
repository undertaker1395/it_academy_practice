using System;

namespace Figures
{
    class Program
    {
        static Figure[] figures;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rnd = new Random();
            int randomFigure;

            for (int m = 0; m < 5; m++)
            {
                randomFigure = rnd.Next(0, 2);
                if (randomFigure == 0)
                {
                    figures[m] = new FourSquare();
                    figures[m].name = "Квадрат";
                    Console.WriteLine("Укажите сторону квадрата:");
                    figures[m].height = Convert.ToInt32(Console.ReadLine());
                    figures[m].square = FourSquare.Square();
                }
                else if (randomFigure == 1)
                {
                    figures[m] = new Circle();
                    Console.WriteLine("Укажите радиус круга");
                    figures[m].radius = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    figures[m] = new Trangle();
                    Console.WriteLine("Укажите укажите высоту треугольника");
                    figures[m].height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите укажите длинну основания треугольника");
                    figures[m].baseSide = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < 3; i++) ;
        }
    }
    interface IFigure
    {
        public void Square();
    }
    class Figure
    {
        public string name;
        public int radius;
        public int height;
        public int baseSide;
        public double square;
    }

    class FourSquare : Figure, IFigure
    {
        public void Square()
        {
            square = Math.Pow(height, 2);
        }
    }
    class Circle : Figure, IFigure
    {
        public void Square()
        {
            square = Math.PI * Math.Pow(radius, 2);
        }
    }
    class Trangle : Figure, IFigure
    {
        public void Square()
        {
            square = (height * baseSide) / 2;
        }
    }

}
