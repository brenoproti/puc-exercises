/**
*
* @author BrenoProti
*
*
* Instructions:
*   Rectangle >
*       To change the base and height values, just 
*       change the numbers in line 30 (double base, double height)
*   Circle >
*       To change the circle radius, just 
*       change the number in line 27
*/


using System;

namespace atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            double cylinderVolume;
  
            //Instance circle with radius = 3
            Circle circle = new Circle(3);

            //Instance rectangle with base = 30 and height = 18.85
            Rectangle rectangle = new Rectangle(30, 18.85);

            //Cylinder Volume = circle-area * heigth
            cylinderVolume = circle.circleArea() * rectangle.getSideHeight();

            //Shows the result on the screen
            Console.WriteLine("----------------------");
            Console.WriteLine("  Volume do cilindro  ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Raio {0:F2} \nAltura: {1:F2}", circle.getRadius(), rectangle.getSideHeight());
            Console.WriteLine("--------------");
            Console.WriteLine("Volume: {0:F2}", cylinderVolume);
        }
    }
    class Rectangle {
        private double sideBase; //Base
        private double sideHeight; //Height

        //Constructors - Begin =======
        public Rectangle(){
            setBaseHeight(0, 0);
        }

        public Rectangle(double sideBase) {
            setBaseHeight(sideBase, 0);
        }

        public Rectangle(double sideBase, double sideHeight) {
            setBaseHeight(sideBase, sideHeight);
        }
        //Constructors - End =======

        //Get and Set - Begin =======

        public void setSideBase(double side) {
            this.sideBase = side;
        }

        public void setSideHeight(double side) {
            this.sideHeight = side;
        }

        public void setBaseHeight(double sideBase, double sideHeight) {
            setSideBase(sideBase);
            setSideHeight(sideHeight);
        }

        public double getSideBase() {
            return this.sideBase;
        }

        public double getSideHeight() {
            return this.sideHeight;
        }

        //Get and set - End =========

        //Method to calculate area of ​​the rectangle

        public double rectangleArea() {
            return sideBase * sideHeight;
        }

        //Method to calculating rectangle perimeter

        public double rectanglePerimeter() {
            double perimeter;

            perimeter = 2 * (sideBase + sideHeight);

            return perimeter;
        }
    }

    class Circle {
        private double radius;

        //Constructors - Begin =======

        public Circle() {
            setRadius(0);
        }

        public Circle(double radius) {
            setRadius(radius);
        }

        //Constructors - End =======

        //Get and set - Begin ======

        public void setRadius(double radius) {
            this.radius = radius;
        }

        public double getRadius() {
            return this.radius;
        }
        //Get and set - End =======

        //Method to calculate area of ​​the circle

        public double circleArea() {
            double area;
            double pi = Math.PI;

            area = pi * Math.Pow(this.radius, 2);

            return area;
        }

        //Method to calculated the circle perimeter

        public double circlePerimeter() {
            double pi = Math.PI;
            double perimeter;

            perimeter = 2*pi*this.radius; 

            return perimeter;
        }
    }
}
