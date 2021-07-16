using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmpleados
{
    class Menu_E
    {
        public void Menu1()
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Menu de Empleados: \n");
            Console.WriteLine("1: Gerencial");
            Console.WriteLine("2: Administrativo");
            Console.WriteLine("3: Operativo");
            //Console.WriteLine("4: Cerrar Programa\n");

            Console.WriteLine("Seleccione la opcion:");
            int opc = Convert.ToInt32(Console.ReadLine());

            Employees emplead = Fabrica.GetEmployees(opc);
            emplead.Menu();

            Console.ReadKey();
        }
    }
}
