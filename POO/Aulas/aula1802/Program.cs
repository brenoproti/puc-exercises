using System;

namespace aula1802
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee professor = new Employee("José Wilson", "Costa", 18, 3, 1962, 1, 3, 1989, 18, 30, 00);

            Console.WriteLine(professor.getInfo());
            /*
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
            */
        }
    }

    public class Employee {
        private string name;
        private string surname;
        private Date birthday;
        private Date hiring;
        private Time birthdayHour;

        //Constructors
        public Employee(string n, string sn, int dB, int mB, int yB, int dH, int mH, int yH, int hour, int min, int sec) {

            name = n;
            surname = sn;   
            birthday = new Date(dB, mB, yB);
            hiring = new Date(dH, mH, yH);
            birthdayHour = new Time(hour, min, sec);
        }   

        public void setName(string n) {
            name = n;
        }

        public string getName() {
            return name;
        }

        public void setSurname(string sn) {
            surname = sn;
        }

        public string getSurname() {
            return surname;
        }

        public string getInfo() {
            return "Funcionário: " + name + " " + surname + " contrado em " + hiring.getDate() + " , faz aniversário em " + birthday.getDate() + ", festa de aniversário será às " + birthdayHour.printAmericanFormat();
        }
    }

    public class Date {
        private int month;
        private int day;
        private int year;

        //Constructor 

        public Date() {
            setDate(1,1,2021);
        }

        public Date(int d, int m, int y) {
            setDate(d,m,y);
        }

        //Get and set
        public void setDate(int d, int m, int y) {
            if (m > 0 && m <= 12)
                month = m;
            else
                month = 1;

            year = y;

            day = verifyDay(d);
        }

        public int verifyDay(int d) {
            //Vetor com com os dias de cada mês (jan à dez)
            int[] daysOfMonth = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            int di = 1;
            if (d > 0 && d<= daysOfMonth[month]){
                di = d;
                if  ((month == 2) && (d == 29) && ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))) 
            {
                return di = d;
            }
            }
                

            //Verificar se o ano é bissexto 
            
            else {
                Console.WriteLine("Dia inválido!");
            }

            return di;

            
        }

        public string getDate() {
            return day + "/" + month + "/" + year;
        }

        

    }

    public class Time {

        private int hour;
        private int minute;
        private int second;

        public Time(int h, int m, int s) {
            setTime(h,m,s);
        }

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

        public string printAmericanFormat() {
            int auxH;

            if(hour == 12)
                auxH = 12;
            else
                if (hour > 12)
                    auxH = hour % 12;
                else 
                    auxH = hour;

            string ampm = (hour < 12) ? "AM" : "PM";
          return (String.Format("{0:D2}:{1:D2}:{2:D2} {3:D2}", auxH, minute, second, ampm));
        }
    }
}
