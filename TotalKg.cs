using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tallernet
{
    public class TotalKg : Valor

    {
        private double Cantidad = 0;
        public string realizarConversion(string convercion)

        {
            if(convercion=="MILIGRAMOS")
            {
                Cantidad = 1000000;
            }
            else
            {
                if (convercion == "GRAMOS")
                {
                    Cantidad = 1000;
                }
                else
                {
                    if(convercion == "DECAGRAMOS")
                {
                        Cantidad = 100;
                    }
                    else
                    {
                        Cantidad = 0;
                    }
                }
            }

            return convercion;
        }
        public double calcularTotalConversion()
        {
            return (this.getKilogramos()* Cantidad);
        }

    }
}
