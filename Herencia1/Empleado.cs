using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Empleado : PersonaFísica
    {
    string numeroDeEmpleado, nss;

    public string NumeroDeEmpleado
    {
        get { return numeroDeEmpleado; }
        set { numeroDeEmpleado = value; }
    }

    public string  Nss
    {
        get { return nss; }
        set { nss = value; }
    }



}
