using System;

namespace atividade01
{
    /**
    *
    * @author BrenoProti
    *
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            int horas = 190;
            double salario = 12.00, salarioFinal;
            //Criar um objeto do tipo Empregado
            Empregado fulano = new Empregado();

            //Definir o valor salario-hora e horas trabalhadas
            fulano.setSalarioHora(salario);
            fulano.setHrsTrabalhadas(horas);

            //Calcular o salario final 
            salarioFinal = fulano.calcularSalario();

            //Exibir o resultado na tela
            Console.WriteLine("Salario-hora: R$ {0:F} \nHoras trabalhadas: {1}\nSalario final: R$ {2:F}", fulano.getSalarioHora(), fulano.getHrsTrabalhadas(), salarioFinal);
        }
    }

    class Empregado {
        private double salarioHora;
        private int hrsTrabalhadas;

        //Constructors
        public Empregado() { 
            setSalario(0,0);
        }

        public Empregado(double salario) { 
            setSalarioHora(salario);
        } 

        public Empregado(int horas) { 
            setHrsTrabalhadas(horas);
        } 

        //GET and SET 
        public double getSalarioHora() {
            return salarioHora;
        }

        public double getHrsTrabalhadas() {
            return hrsTrabalhadas;
        }

        public void  setSalarioHora(double salario) {
            if(salario < 0)
                salarioHora = 0;
            else
                salarioHora = salario;
        }

        public void setHrsTrabalhadas(int horas) {
            if (horas < 0)
                hrsTrabalhadas = 0;
            else
                hrsTrabalhadas = horas;
        }

        public void setSalario(double salario, int hora) {
            setSalarioHora(salario);
            setHrsTrabalhadas(hora);
        }

        //Methods

        public double calcularSalario() {
            double INSS;
            double salarioFinal;
            
            //Calcular o salario final
            salarioFinal = salarioHora * hrsTrabalhadas;
            INSS = (salarioFinal *  11) / 100;

            salarioFinal -= INSS;

            return salarioFinal;
        }
        
    }
}
