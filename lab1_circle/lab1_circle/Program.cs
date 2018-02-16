using System;

namespace ConsoleApp7
{
    class Circle
    {
        public double Radius;
        public double Area;
        public double Diameter;
        public double Circumference;
        public double Pi;

        public Circle()
        {
            Radius = 5;
            Pi = 3.14;
        }

        public void FindArea()
        {
            Area = Radius * Radius * Pi;
        }

        public void FindDiameter()
        {
            Diameter = Radius * 2;
        }

        public void FindCircumference()
        {
            Circumference = Diameter * Pi;
        }

        public override string ToString()
        {
            return Radius + "\n" + Diameter + "\n" + Area + "\n" + Circumference;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Circle s = new Circle();
            s.FindArea();
            s.FindDiameter();
            s.FindCircumference();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
