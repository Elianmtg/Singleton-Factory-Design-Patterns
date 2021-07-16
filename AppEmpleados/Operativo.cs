using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmpleados
{
    class Operativo : Employees
    {
        List<Operativo> lista_operativo = new List<Operativo>();
        public override void Crear()
        {
            Operativo oper = new Operativo();

            Random aleatorio = new Random();
            int numaleat;
            numaleat = aleatorio.Next(1000, 10000);
            string codg = ("OPE-" + numaleat);
            oper.Codigo = codg;

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Creacion de Empleado Operativo: \n");
            Console.WriteLine("Ingrese el Nombre:");
            oper.Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el Apellido:");
            oper.Apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese la Cedula:");
            oper.Cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Email:");
            oper.Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el Telefono:");
            oper.Telefono = Convert.ToInt32(Console.ReadLine());
            oper.Departamento = "Operativo";
            oper.Cargo = "Operador";
            Console.WriteLine("Ingrese el Precio por las horas:");
            oper.PrecioXhora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las Horas Trabajadas:");
            oper.HorasLaboradas = Convert.ToInt32(Console.ReadLine());

            lista_operativo.Add(oper);

            Console.WriteLine("\n¡¡¡EMPLEADO CREADO Y GUARDADO CON EXITO!!! ");
        }

        public override void Menu()
        {
            int opc;
            do
            {
                Menu_E Menu = new Menu_E();

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Menu de Empleado Operativo: \n");
                Console.WriteLine("1: Crear Empleado");
                Console.WriteLine("2: Visualizar Empleado");
                Console.WriteLine("3: Cobrar");
                Console.WriteLine("4: Regresar <=\n");

                Console.WriteLine("Seleccione la opcion:");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Crear();
                }
                else if (opc == 2)
                {
                    Visualizar();
                }
                else if (opc == 3)
                {
                    Cobrar();
                }
                else if (opc == 4)
                {
                    Menu_E men = new Menu_E();
                    men.Menu1();
                }
                else
                {
                    Console.WriteLine(" \n ¡¡¡OPCION INGRESADA INCORRECTA, INGRESE UNA OPCION VALIDA!!! \n");
                }

            } while (opc != 4);
        }
        public void GeneradorCodigo()
        {
            Random aleatorio = new Random();
            int numaleat;
            numaleat = aleatorio.Next(1000, 10000);
            string codg = ("GER-" + numaleat);
            Codigo = codg;
        }
        public override void Cobrar()
        {
            Recibo();
        }

        public override void Recibo()
        {
            Console.WriteLine("\nIngrese el codigo a cobrar:");
            string codgcobra = Console.ReadLine();

            foreach (Operativo o in lista_operativo)
            {
                if (o.Codigo == codgcobra)
                {
                    o.Bono = 0.10;
                    o.Salario = o.HorasLaboradas * o.PrecioXhora * o.Bono;
                    Console.WriteLine("\nRECIBO DE PAGO");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Codigo del Empleado: {o.Codigo}");
                    Console.WriteLine($"Nombre del Empleado: {o.Nombre}");
                    Console.WriteLine($"Departamento del Empleado: {o.Departamento}\n");
                    Console.WriteLine($"Horas laboradas del Empleado: {o.HorasLaboradas}");
                    Console.WriteLine($"Precio por Horas del Empleado: {o.PrecioXhora}");
                    Console.WriteLine($"Salario Total a Pagar al Empleado: {o.Salario}");
                }
            }
        }

        public override void Visualizar()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Lista de Empleados Operativos: \n");
            foreach (Operativo o in lista_operativo)
            {
                Console.WriteLine($"Codigo: {o.Codigo}");
                Console.WriteLine($"Nombre: {o.Nombre}");
                Console.WriteLine($"Apellido: {o.Apellido}");
                Console.WriteLine($"Cedula: {o.Cedula}");
                Console.WriteLine($"Email: {o.Email}");
                Console.WriteLine($"Telefono: {o.Telefono}");
                Console.WriteLine($"Departamento: {o.Departamento}");
                Console.WriteLine($"Cargo: {o.Cargo}");
                Console.WriteLine($"Horas Laboradas: {o.HorasLaboradas}");
                Console.WriteLine($"Precio por Hora: {o.PrecioXhora}");
                Console.WriteLine($"Bono: {o.Bono}");
                Console.WriteLine($"Salario: {o.HorasLaboradas * o.PrecioXhora}\n");
            }
        }

    }
}
