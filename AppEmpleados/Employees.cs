using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmpleados
{
    public abstract class Employees
    {
        private string codigo;
        private string nombre;
        private string apellido;
        private int cedula;
        private string email;
        private int telefono;
        private string departamento;
        private string cargo;
        private double horasLaboradas;
        private double precioXhora;
        private double bono;
        private double salario;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public double HorasLaboradas { get => horasLaboradas; set => horasLaboradas = value; }
        public double PrecioXhora { get => precioXhora; set => precioXhora = value; }
        public double Bono { get => bono; set => bono = value; }
        public double Salario { get => salario; set => salario = value; }

        public abstract void Crear();
        public abstract void Visualizar();
        public abstract void Cobrar();
        public abstract void Recibo();
        public abstract void Menu();

    }
}
