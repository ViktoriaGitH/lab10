using System;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5);
            square1.DisplayInfo();
            Console.WriteLine($"Лице: {square1.CalculateArea()}");

            Rectangle rectangle1 = new Rectangle(4, 6);
            rectangle1.DisplayInfo();
            Console.WriteLine($"Лице: {rectangle1.CalculateArea()}");

            Rhombus rhombus1 = new Rhombus(4, 5);
            rhombus1.DisplayInfo();
            Console.WriteLine($"Лице: {rhombus1.CalculateArea()}");

            Parallelogram parallelogram1 = new Parallelogram(4, 6, 5);
            parallelogram1.DisplayInfo();
            Console.WriteLine($"Лице: {parallelogram1.CalculateArea()}");
        }
    }


    public class GeometricFigure
    {
        
        protected double sideA;
        protected double sideB;

        
        public GeometricFigure(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фигура: Страна A - {sideA}, Страна Б - {sideB}");
        }

        
        public virtual double CalculateArea()
        {
            return sideA * sideB;
        }
    }

    public class Square : GeometricFigure
    {
        public Square(double side)
            : base(side, side)
        {
        }
    }

    public class Rectangle : GeometricFigure
    {
        public Rectangle(double sideA, double sideB)
            : base(sideA, sideB)
        {
        }
    }

    public class Rhombus : GeometricFigure
    {
        
        public Rhombus(double side, double height)
            : base(side, height)
        {
        }

        
        public override double CalculateArea()
        {
            return (sideA * sideB)/2;
        }
    }

    public class Parallelogram : GeometricFigure
    {
        public Parallelogram(double sideA, double sideB, double height)
            : base(sideA, height)
        {
            this.sideB = sideB;
        }

        // Пренаписване на метода за пресмятане на площта за успоредник
        public override double CalculateArea()
        {
            return sideA * sideB;
        }
    }
}