using System;

namespace aula1102
{
    class Program
    {
        // Dado dois pontos no espaço, calcular a distância entre eles

        static void Main(string[] args)
        {
            double x, y, d;

            Point p1 = new Point();
            Point p2 = new Point(4,0);

            Console.WriteLine("Digite as cordenadas do primeiro ponto: ");
            Console.Write("X: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = Double.Parse(Console.ReadLine());

            p2.setXY(x, y);
            d = p1.Distance(p2);
            Console.Write(d);
        }
    }

    class Point {
        private double x;
        private double y;

        public void setXY(double cx, double cy) {
            x = cx;
            y = cy;
        }

        public void setX(double cx) {
            setXY(cx, 0);
        }

        public void setY(double cy) {
            setXY(0, cy);
        }

        public double getX() {
            return x;
        }

        public double getY() {
            return y;
        }

        //Constructors
        public Point() {
            setXY(0, 0);
        }

        public Point(double cx, double cy) {
            setXY(cx, cy);
        }

        public Point(Point p) {
            setXY(p.x, p.y);
        }

        public double Distance(double cx, double cy) {
            double d;
            d = Math.Sqrt(Math.Pow(x-cx, 2) + Math.Pow(y-cy, 2));
            
            return d;
        }

        public double Distance(Point p) {
            double d;
            d = Math.Sqrt(Math.Pow(x-p.x, 2) + Math.Pow(y-p.y, 2));

            return d;
        }
    }
}
