using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class EmpleadoDeBaseMasComision: EmpleadoDeBase
    {
    private float comision,sueldoMasComision, comisionTotal, tasaDeProductividad ;

    public float Comision
    {
        get { return comision ; }
        set { comision= value; }
    }
    public float SueldoMasComision
    {
        get { return sueldoMasComision; }
        set { sueldoMasComision = value; }
    }
    public float ComisionTotal
    {
        get { return comisionTotal; }
        set { comisionTotal = value; }
    }
    public float TasaDeProductividad
    {
        get { return tasaDeProductividad; }
        set { tasaDeProductividad = value; }
    }
    public void CalcularComision()
    {
        ComisionTotal = Comision * TasaDeProductividad;
    }
    public void CalcularSueldoTotal()
    {
        SueldoMasComision = Sueldo + ComisionTotal;
    }


}

