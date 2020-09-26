using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tallernet
{
   public class TotalEntero : Valor
    {
        private Int32 dato= 0;
        public string realizarOperacion(string operacion)

        {

            if (operacion =="SUMA")
            {
                dato =( this.getValor1() + this.getValor2());
            }
            else
            {
                if (operacion == "RESTA")
                {
                    dato=(this.getValor1() - this.getValor2());
                }
                else
                {
                    if (operacion == "MULTIPLICACION")
                    {
                        dato = (this.getValor1() * this.getValor2());
                    }
                    else
                    {
                        if (operacion == "DIVISION")
                        {
                            dato = (this.getValor1() / this.getValor2());
                        }
                        else
                        {
                            dato = 0;
                        }
                    }
                }


            }

            return ""; 
        }

        public double calcularTotaloperacion()
        {
            return (dato );
        }

    }
}
