using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tallernet
{
   public  class Aumento : Valor

    {
        private double descuento = 0;
        public double RAumento(double antiguedad)
        {
           

            if(antiguedad ==5)
            {
                descuento=0.30;
            }
            else
            {
                if (antiguedad == 7)
                {
                    descuento = 0.40;
                }
                else
                {
                    if (antiguedad == 10)
                    {
                        descuento = 0.45;
                    }
                    else
                    {
                        if (antiguedad > 10)
                        {
                            descuento = 0.50;
                        }
                        else
                        {
                            descuento = 0;
                        }
                    }
                }


        }
            return descuento;
    }

        public double calcularTotalAumento()
        {
            return ((this.getSalario() * descuento)+this.getSalario());
        }


    }
}
