using System;

namespace atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int x, y;
            double side1, side2, side3, sp, area;

            //Point 01
            Console.WriteLine("==================================");
            Console.WriteLine("          AREA DO TRINGULO        ");
            Console.WriteLine("==================================");
            Console.Write("Digite o valor de X do primeiro ponto: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y do primeiro ponto: ");
            y = Int32.Parse(Console.ReadLine());

            Ponto p1 = new Ponto(x, y);

            //Point 02
            Ponto p2 = new Ponto(0, 3);

            //Point 03
            Ponto p3 = new Ponto();
            p3.setX(4);
            p3.setY(0);


            // Calculated the area of the triangle
            side1 = p1.distancia(p1, p2);
            side2 = p1.distancia(p1, p3);
            side3 = p1.distancia(p2, p3);

            sp = (side1 + side2 + side3) / 2;

            area =  Math.Sqrt(sp*(sp-side1)*(sp-side2)*(sp-side3));
            
            Console.WriteLine("==================================");
            Console.Write(String.Format("Area do triângulo é {0:F2}", area));
        }
    }

    class Ponto {
    private int x, y;

    //Constructor==============
    public Ponto(){
        setXY(0, 0);
    }

    public Ponto(int numX, int numY){
        setXY(numX, numY);
    }

    public Ponto(Ponto P){
        x = P.getX();
        y = P.getY();
    }
        //Constructors - End ==========


        //Get and set==============
        public void setX(int x){
            this.x = x;
        }

        public void setY(int y){
            this.y = y;
        }

        public void setXY(int x, int y){
          setX(x);
          setY(y);
        }

        public int getX(){
          return x;
        }

        public int getY(){
          return y;
        }

        public Ponto getPonto() {
          return this;
        }

        //Get and set - End ==========

        //Method to calculated distancy
        public double distancia(Ponto p1, Ponto p2) {
            double d;
            d = Math.Sqrt(Math.Pow(p1.getX() - p2.getX(), 2) + Math.Pow(p2.getY() - p1.getY(), 2));
            return d;
        }
    }
}
