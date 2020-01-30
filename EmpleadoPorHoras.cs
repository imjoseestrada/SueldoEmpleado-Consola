using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela
{
    class EmpleadoPorHoras: Empleado
        // La herencia se determina cuando la clase termina con dos puntos y el nombre de la clase de la que hereda. Si la clase de la que hereda tiene un método abstracto, forzará a esta clase a incluir un método que sobreescriba.
    {
        int horasTrab;
        double pagoHora;

        public void establecerHorasTrab(int HorasTr)
        {
            horasTrab = HorasTr;
        }

        public void establecerPagoHora(double pagoHr)
        {
            pagoHora = pagoHr;
        }

        public override double calcularSueldoQna()
        {
            sueldoQna = horasTrab * pagoHora;
            return sueldoQna;
        }
    }
}
