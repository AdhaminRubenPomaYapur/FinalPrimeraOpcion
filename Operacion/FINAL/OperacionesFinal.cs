using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FINAL
{
    public static class OperacionesFinal
    {
        public static string NumeroALetras(this decimal numberAsString)
        {
            var entero = Convert.ToInt64(Math.Truncate(numberAsString));
            var decimales = Convert.ToInt32(Math.Round((numberAsString - entero) * 100, 2));
            var res = NumeroALetras(Convert.ToDouble(entero));
            return res;
        }
        private static string NumeroALetras(double value)
        {
            string num2Text; value = Math.Truncate(value);
            if (value < 0) num2Text = "ERROR";
            else if (value == 0) num2Text = "REALIZADO POR ADHAMIN RUBEN POMA YAPUR";
            else if (value > 0) num2Text = "USTED DIGITO EL NUMERO " + value;
            else
            {
                num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0)
                {
                    num2Text = num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
                }
            }
            return num2Text;
        }
    }
}
