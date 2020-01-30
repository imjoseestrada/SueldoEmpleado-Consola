using System;
using System.Collections.Generic;
using System.Text;

namespace Escuela
{
    public abstract class Empleado
        // Se agrega public abstract para referir al polimorfismo donde debe existir al menos un método abstracto que podrá ser calculado de forma distinta alguna clase hija.
    {
        // protected se refiere al encapsulamiento, este protege las variables para que no puedan ser modificadas en otras clases.
        protected String nombreEmp, deptoEmp, puestoEmp;
        protected double sueldoQna;

        public void establecerNombreEmp(String nom)
        {
            nombreEmp = nom;
        }

        public void establecerDeptoEmp(String dep)
        {
            deptoEmp = dep;
        }

        public void establecerPuestoEmpo(String pue)
        {
            puestoEmp = pue;
        }

        public abstract Double calcularSueldoQna();

        public String obtenerNombreEmp()
        {
            return nombreEmp;
        }

        public String obtenerDeptoEmp()
        {
            return deptoEmp;
        }

        public String obtenerPuestoEmp()
        {
            return puestoEmp;
        }

        public double obtenerSueldoQna()
        {
            return sueldoQna;
        }
    }
}
