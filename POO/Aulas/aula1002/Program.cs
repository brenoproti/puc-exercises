using System;

namespace aula1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.setTime(5, 10, 20);

            t1.print();
            t1.printAmericanFormat();

            Time t2 = new Time();
            t2.setTime(18, 25, 20);

            t2.print();
            t2.printAmericanFormat();

            Time t3 = new Time();
            t3.setTime(16, 50, 20);
             
            t3.print();
            t3.printAmericanFormat();
        }
    }

    public class Time {

        private int hour;
        private int minute;
        private int second;

        public void setTime(int h, int m, int s) {
            setHour(h);
            setMinute(m);
            setSecond(s);
        }

        public void setHour(int h) {
            hour = (h<0 || h>23) ? 0 : h;
        }
        
        public void setMinute(int m) {
            minute = (m<0 || m>59) ? 0 : m;
        }

        public void setSecond(int s) {
            second = (s<0 || s>59) ? 0 : s;
        }

        public void print() {
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second));
        }

        public void printAmericanFormat() {
            int auxH;

            if(hour == 12)
                auxH = 12;
            else
                if (hour > 12)
                    auxH = hour % 12;
                else 
                    auxH = hour;

            string ampm = (hour < 12) ? "AM" : "PM";
            Console.WriteLine(String.Format("{0:D2}:{1:D2}:{2:D2} {3:D2}", auxH, minute, second, ampm));
        }
    }
}
