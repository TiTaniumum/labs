using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle
{
    class Rectangle
    {
        public int width;
        public int height;
        public int area;
        public int per;

        public Rectangle()
        {
            width = 5;
            height = 10;
        }

        public void FindArea()
        {
            area = width * height;
        }

        public void FindPer()
        {
            per = (width + height) * 2;
        }

        public override string ToString()
        {
            return width + "\n" + height + "\n" + area + "\n" + per;
        }
    }

    class programm
    {
        static void Main(string[] args)
        {
            Rectangle s = new Rectangle();
            s.FindArea();
            s.FindPer();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
