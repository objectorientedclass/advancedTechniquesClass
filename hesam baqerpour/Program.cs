using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point _point = new Point();
            _point.setPoint(4, 5);
            _point.setPoint(7, 8);

            Console.Read();
        }
    }


    public class Point
    {
        private float x;
        private float y;

        public Point()
        {
            this.x = 0;
            this.y =0;
        }

  

        public void setPoint(float _x, float _y)
        {
            this.x = _x;
            this.y = _y;

        }


    }
}