using System;
using System.Collections.Generic;
using System.Text;

namespace AppEmpleados
{
    class Fabrica
    {
        public static Employees GetEmployees(int opc)
        {
            if(opc == 1)
            {
                return new Gerencial();
            }
            if(opc == 2)
            {
                return new Administrativo();
            }
            if(opc == 3)
            {
                return new Operativo();
            }
            else
            {
                return null;
            }
        }
    }
}
