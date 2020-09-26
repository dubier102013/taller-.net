using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tallernet
{
    public class Valor
    {
        private double Kilogramos, Salario,Antiguedad;
        private Int32 Valor1,Valor2;

        

        public double getKilogramos()
        {
            return this.Kilogramos;
        }

        public void setKilogramos(double valor)
        {
            this.Kilogramos = valor;
        }

        public double getSalario()
        {
            return this.Salario;
        }
        public void setSalario(double valor)
        {
            this.Salario = valor;
        }
        public double getAntiguedad()
        {
            return this.Antiguedad;
        }
        public void setAntiguedad(double valor)
        {
            this.Antiguedad = valor;
        }

        public Int32 getValor1()
        {
            return this.Valor1;
        }
        public void setValor1(Int32 valor)
        {
            this.Valor1 = valor;
        }
        public Int32 getValor2()
        {
            return this.Valor2;
        }
        public void setValor2(Int32 valor)
        {
            this.Valor2 = valor;
        }

    }
}
