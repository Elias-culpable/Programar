using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecuacion_de_segundo_grado__3_coeficientes_
{
    internal class Funciones
    {
        static public double Ecuacion1(double num1, double num2, double num3)
        {
            double Resultado = 0;

            Resultado = ((-num2)+ (Math.Sqrt(((num2 * num2) - (4 * num1 * num3))))) / (2*num1);

            return Resultado;
        }

        static public double Ecuacion2(double num1, double num2, double num3)
        {
            double Resultado = 0;
            Resultado = ((-num2) - (Math.Sqrt(((num2 * num2) - (4 * num1 * num3))))) / (2 * num1);

            return Resultado;
        }

    }
}
