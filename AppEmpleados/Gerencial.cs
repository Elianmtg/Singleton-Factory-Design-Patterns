using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmpleados
{
    class Gerencial : Employees
    {
        private static Gerencial gerencial;

        List<Gerencial> listagerencial = new List<Gerencial>();

        private Gerencial(/*string codig,*/ string nombre, string apellido, int cedula, string email, int telefono, string departamento, 
            string cargo, double horasLaboradas, double precioXhora, double bono, double salario)
        {
            //this.codig = codig;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cedula = Cedula;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Departamento = Departamento;
            this.Cargo = Cargo;
            this.HorasLaboradas = HorasLaboradas;
            this.PrecioXhora = PrecioXhora;
            this.Bono = Bono;
            this.Salario = Salario;
        }

        public Gerencial()
        {
        }

        public static Gerencial GetGerencial(/*string codig,*/ string nombre, string apellido, int cedula, string email, int telefono, string departamento, string cargo, double horasLaboradas, double precioXhora, double bono, double salario)
        {
            if (gerencial == null)
            {
                gerencial = new Gerencial(/*codd,*/ nombre, apellido, cedula, email, telefono, departamento, cargo, horasLaboradas, precioXhora, bono, salario); //Crea la instancia

            }

            return gerencial;
        }
        
        public override void Crear()
        {
            Random aleatorio = new Random();
            int numaleat;
            numaleat = aleatorio.Next(1000, 10000);
            string codg = ("OPE-" + numaleat);
            Codigo = codg;

            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Creacion de Empleado Gerencial: \n");
            Console.WriteLine("Ingrese el Nombre:");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido:");
            string Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la Cedula:");
            int Cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Ingrese el Telefono:");
            int Telefono = Convert.ToInt32(Console.ReadLine());
            string Departamento = "Gerencial";
            string Cargo = "Gerente";
            Console.WriteLine("Ingrese el Precio por las horas:");
            double PrecioXhora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese las Horas Trabajadas:");
            double HorasLaboradas = Convert.ToInt32(Console.ReadLine());

            Gerencial gerencial = Gerencial.GetGerencial(Nombre, Apellido, Cedula, Email, Telefono, Departamento, Cargo, HorasLaboradas, PrecioXhora, Bono, Salario);
            
            listagerencial.Add(gerencial);

            Console.WriteLine("\n¡¡¡EMPLEADO CREADO Y GUARDADO CON EXITO!!! ");
        }
        public override void Menu()
        {
            int opc;
            do
            {

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Menu de Empleado Gerencial: \n");
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
        public override void Visualizar()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Lista de Empleados Gerenciales: \n");
            foreach (Gerencial z in listagerencial)
            {
                Console.WriteLine($"Codigo: {z.Codigo}");
                Console.WriteLine($"Nombre: {z.Nombre}");
                Console.WriteLine($"Apellido: {z.Apellido}");
                Console.WriteLine($"Cedula: {z.Cedula}");
                Console.WriteLine($"Email: {z.Email}");
                Console.WriteLine($"Telefono: {z.Telefono}");
                Console.WriteLine($"Departamento: {z.Departamento}");
                Console.WriteLine($"Cargo: {z.Cargo}");
                Console.WriteLine($"Horas Laboradas: {z.HorasLaboradas}");
                Console.WriteLine($"Precio por Hora: {z.PrecioXhora}");
                Console.WriteLine($"Bono: {z.Bono}");
                Console.WriteLine($"Salario: {+z.HorasLaboradas * z.PrecioXhora}\n");
            }
        }

        public override void Cobrar()
        {
            Recibo();
        }

        public override void Recibo()
        {
            Console.WriteLine("\nIngrese el codigo a cobrar:");
            string codgcobra = Console.ReadLine();

            foreach (Gerencial g in listagerencial)
            {
                if (g.Codigo == codgcobra)
                {
                    Bono = 1.50;
                    Salario = HorasLaboradas * PrecioXhora * Bono;

                    Console.WriteLine("\nRECIBO DE PAGO");
                    Console.WriteLine("Puerto Plata, R.D. | 809-970-3222");
                    Console.WriteLine($"Fecha: {DateTime.Now}\n");
                    Console.WriteLine($"Codigo del Empleado: {g.Codigo}");
                    Console.WriteLine($"Nombre del Empleado: {g.Nombre}");
                    Console.WriteLine($"Departamento del Empleado: {g.Departamento}\n");
                    Console.WriteLine($"Horas laboradas del Empleado: {g.HorasLaboradas}");
                    Console.WriteLine($"Precio por Horas del Empleado: {g.PrecioXhora}");
                    Console.WriteLine($"Total a Pagar al Empleado: {g.Salario}");
                }
                    
            }
        }

    }
}
