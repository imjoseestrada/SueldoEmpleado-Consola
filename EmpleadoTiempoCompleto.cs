using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela
{
    class EmpleadoTiempoCompleto: Empleado
    {
        double sueldoMensual;

        public void establecerSueldoMensual(double sue)
        {
            sueldoMensual = sue;
        }

        public override double calcularSueldoQna()
        {
            sueldoQna = sueldoMensual / 2;
            return sueldoQna;
        }
    }
}
