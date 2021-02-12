using System;

namespace aitividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareArea square = new SquareArea();
            square.setSide(8);
            square.calculatedArea();
            Console.WriteLine(square.getResult());
        }
    }

    public class SquareArea {
        private double side;
        private double result;

        public void setSide(float s) {
            side = s;
        }

        public double getResult() {
            return result;
        }
        
        public void calculatedArea() {
            double squareArea = side*side;
            double circunference = 3.14 * (side/2)*(side/2);
            result = squareArea - circunference;
        }
    }
}
