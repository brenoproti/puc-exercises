using System;

namespace conversortemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion temp = new Conversion();
            temp.setTC(32);
            temp.convertF();
            Console.WriteLine(temp.getTF());
            Console.WriteLine(temp.getTC());

        }
    }
    

    public class Conversion {
        private double TF;
        private double TC;

        public void setTF(double t) {
            TF = t;
        }

        public void setTC(double c) {
            TC = c;
        }

        public double getTF() {
            return TF;
        }

        public double getTC() {
            return TC;
        }

        public void convertC() {
            TC = (TF-32)* 5 / 9;
        }

        public void convertF() {
            TF = TC * 9 / 5 + 32;
        }

    }
}
