using System;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            String nomEmp, depto, puesto;
            int hrsTrab, tipoEmp, desea;
            double pagoHr, sueldoMeunsual;

            do
            {
                Console.WriteLine("Seleccione el tipo de empleado: " + "\n 1. Empleado por horas. \n 2. Empleado tiempo completo.");
                tipoEmp = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escribe el nombre del empleado:");
                nomEmp = Console.ReadLine();
                Console.WriteLine("Escribe el departamento al que pertenece:");
                depto = Console.ReadLine();
                Console.WriteLine("Escribe el puesto:");
                puesto = Console.ReadLine();

                // creando el objeto según el tipo de empleado seleccionado
                if (tipoEmp == 1)
                {
                    EmpleadoPorHoras objEmpleado = new EmpleadoPorHoras();

                    Console.WriteLine("Empleado por horas");
                    Console.WriteLine("Escribe el número de horas trabajadas:");
                    hrsTrab = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escribe el pago por hora:");
                    pagoHr = Convert.ToDouble(Console.ReadLine());

                    // establecer valores en el objeto
                    objEmpleado.establecerNombreEmp(nomEmp);
                    objEmpleado.establecerDeptoEmp(depto);
                    objEmpleado.establecerPuestoEmpo(puesto);
                    objEmpleado.establecerHorasTrab(hrsTrab);
                    objEmpleado.establecerPagoHora(pagoHr);

                    // invocar el calculo
                    objEmpleado.calcularSueldoQna();

                    // impresiones mediante el objeto
                    Console.WriteLine("Nombre del empleado: " + objEmpleado.obtenerNombreEmp());
                    Console.WriteLine("Departamento: " + objEmpleado.obtenerDeptoEmp());
                    Console.WriteLine("Puesto: " + objEmpleado.obtenerPuestoEmp());
                    Console.WriteLine("Sueldo quincenal: " + objEmpleado.obtenerSueldoQna());
                } // fin del if
                else
                {
                    EmpleadoTiempoCompleto objEmpleado = new EmpleadoTiempoCompleto();

                    Console.WriteLine("Empleado de tiempo completo");
                    Console.WriteLine("Escribe el sueldo mensual:");
                    sueldoMeunsual = Convert.ToDouble(Console.ReadLine());

                    // establecer valores en el objeto
                    objEmpleado.establecerNombreEmp(nomEmp);
                    objEmpleado.establecerDeptoEmp(depto);
                    objEmpleado.establecerPuestoEmpo(puesto);
                    objEmpleado.establecerSueldoMensual(sueldoMeunsual);

                    // invocar el calculo
                    objEmpleado.calcularSueldoQna();

                    // impresiones mediante el objeto
                    Console.WriteLine("Nombre del empleado: " + objEmpleado.obtenerNombreEmp());
                    Console.WriteLine("Departamento: " + objEmpleado.obtenerDeptoEmp());
                    Console.WriteLine("Puesto: " + objEmpleado.obtenerPuestoEmp());
                    Console.WriteLine("Sueldo quincenal: " + objEmpleado.obtenerSueldoQna());
                }

                Console.WriteLine("Escriba 1 si desea procesa otro empleado, cualquier otro valor es no.");
                desea = Convert.ToInt32(Console.ReadLine());
            } // fin del do
            while (desea == 1);
        }
    }
}
