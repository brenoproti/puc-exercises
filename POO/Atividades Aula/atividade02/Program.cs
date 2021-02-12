using System;

namespace atividade02
{
    class Program
    {

        //Dado 3 números em qualquer ordem, ordeda-los 
        static void Main(string[] args)
        {
            string ordem;
            Nums numeros = new Nums(3, 2, 1);
            ordem = numeros.Order(numeros);
            Console.WriteLine(ordem);
        }
    }

    class Nums {
        private int num1, num2, num3;
        
        //Constructors
        public Nums() {
            setNums(0,0,0);
        }

        public Nums(int a, int b, int c){
            setNums(a,b,c);
        }

        //Get and Set
        public int getNum1() {
            return num1;
        }

        public int getNum2() {
            return num2;
        }

        public int getNum3() {
            return num3;
        }

        public void setNum1(int num) {
            num1 = num;
        }

        public void setNum2(int num) {
            num2 = num;
        }

        public void setNum3(int num) {
            num3 = num;
        }

        public void setNums(int a, int b, int c) {
            num1 = a;
            num2 = b;
            num3 = c;
        }

        //Order Method
        public String Order(Nums n) {
            string result = "";
            
            if (n.num1 < n.num2 && n.num1 < n.num3){
                if (n.num2 < n.num3)
                    result += n.num1 + ", " + n.num2 + ", " + n.num3;
                else
                    result += n.num1 + ", " + n.num3 + ", " + n.num2;
            } else if (n.num2 < n.num1 && n.num2 < n.num3){
                if (n.num1 < n.num3)
                    result += n.num2 + ", " + n.num1 + ", " + n.num3;
                else
                    result += n.num2 + ", " + n.num3 + ", " + n.num1;
            } else if (n.num3 < n.num1 && n.num3 < n.num2) {
                if (n.num1 < n.num2)
                    result += n.num3 + ", " + n.num1 + ", " + n.num2;
                else
                    result += n.num3 + ", " + n.num2 + ", " + n.num1;
            }
            return result;
        }
    }
}
