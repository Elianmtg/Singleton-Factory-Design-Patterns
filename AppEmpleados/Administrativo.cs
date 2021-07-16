using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmpleados
{
    class Administrativo : Employees
    {
        List<Administrativo> lista_administrativo = new List<Administrativo>();

        public override void Crear()
        {
            Administrativo admin = new Administrativo();

            Random aleatorio = new Random();
            int numaleat;
            numaleat = aleatorio.Next(1000, 10000);
            string codg = ("ADM-" + numaleat);
            admin.Codigo = codg;

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Creacion de Empleado Administrativo: \n");
            Console.WriteLine("Ingrese el Nombre:");
            admin.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            admin.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la Cedula:");
            admin.Cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Email:");
            admin.Email = Console.ReadLine();
            Console.WriteLine("Ingrese el Telefono:");
            admin.Telefono = Convert.ToInt32(Console.ReadLine());
            admin.Departamento = "Administrativo";
            admin.Cargo = "Administrador";
            Console.WriteLine("Ingrese el Precio por las horas:");
            admin.PrecioXhora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las Horas Trabajadas:");
            admin.HorasLaboradas = Convert.ToInt32(Console.ReadLine());

            lista_administrativo.Add(admin);

            Console.WriteLine("\n¡¡¡EMPLEADO CREADO Y GUARDADO CON EXITO!!! ");
        }

        public override void Menu()
        {
            int opc;
            do
            {
                Menu_E Menu = new Menu_E();

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Menu de Empleado Administrativo: \n");
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
        public override void Cobrar()
        {
            //Console.WriteLine("\nIngrese el codigo a cobrar:");
            //string codgcobra = Console.ReadLine();
            Recibo();
        }

        public override void Recibo()
        {
            Console.WriteLine("\nIngrese el codigo a cobrar:");
            string codgcobra = Console.ReadLine();

            foreach (Administrativo a in lista_administrativo)
            {
                if(a.Codigo == codgcobra)
                {
                    a.Bono = 0.75;
                    a.Salario = a.HorasLaboradas * a.PrecioXhora * a.Bono;

                    Console.WriteLine("\nRECIBO DE PAGO");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Codigo del Empleado: {a.Codigo}");
                    Console.WriteLine($"Nombre del Empleado: {a.Nombre}");
                    Console.WriteLine($"Departamento del Empleado: {a.Departamento}\n");
                    Console.WriteLine($"Horas laboradas del Empleado: {a.HorasLaboradas}");
                    Console.WriteLine($"Precio por Horas del Empleado: {a.PrecioXhora}");
                    Console.WriteLine($"Salario Total a Pagar al Empleado: {a.Salario}");
                }
                //else
                //{
                //    Console.WriteLine(" \n ¡¡¡OPCION INGRESADA INCORRECTA, INGRESE UNA OPCION VALIDA!!! \n");
                //}

                //a.Bono = 0.75;
                //a.Salario = a.HorasLaboradas * a.PrecioXhora * a.Bono;

                //Console.WriteLine("\nRECIBO DE PAGO");
                //Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                //Console.WriteLine($"Fecha: {DateTime.Now}\n");
                //Console.WriteLine($"Codigo del Empleado: {a.Codigo}");
                //Console.WriteLine($"Nombre del Empleado: {a.Nombre}");
                //Console.WriteLine($"Departamento del Empleado: {a.Departamento}\n");
                //Console.WriteLine($"Horas laboradas del Empleado: {a.HorasLaboradas}");
                //Console.WriteLine($"Precio por Horas del Empleado: {a.PrecioXhora}");
                //Console.WriteLine($"Total a Pagar al Empleado: {a.Salario}");
            }
        }

        public override void Visualizar()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Lista de Empleados Administrativo: \n");
            foreach (Administrativo a in lista_administrativo)
            {
                Console.WriteLine($"Codigo: {a.Codigo}");
                Console.WriteLine($"Nombre: {a.Nombre}");
                Console.WriteLine($"Apellido: {a.Apellido}");
                Console.WriteLine($"Cedula: {a.Cedula}");
                Console.WriteLine($"Email: {a.Email}");
                Console.WriteLine($"Telefono: {a.Telefono}");
                Console.WriteLine($"Departamento: {a.Departamento}");
                Console.WriteLine($"Cargo: {a.Cargo}");
                Console.WriteLine($"Horas Laboradas: {a.HorasLaboradas}");
                Console.WriteLine($"Precio por Hora: {a.PrecioXhora}");
                Console.WriteLine($"Bono: {a.Bono}");
                Console.WriteLine($"Salario: {a.HorasLaboradas * a.PrecioXhora}\n");
            }
        }
    }
}
