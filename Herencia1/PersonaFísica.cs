using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PersonaFísica
    {
        string apellidoPaterno, apellidoMaterno, nombre, municipioDeNacimiento, entidadFederativaDeNacimiento, curp, rfc;
        DateTime fechaDeNacimiento;

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string MunicipioDeNacimiento
        {
            get { return municipioDeNacimiento; }
            set { municipioDeNacimiento = value; }
        }
        public string EntidadFederativaDeNacimiento
        {
            get { return entidadFederativaDeNacimiento; }
            set { entidadFederativaDeNacimiento = value; }
        }
        public string Curp
        {
            get { return curp; }
            set { curp = value; }
        }
        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public void CrearRfc()
        {
            string yearString = FechaDeNacimiento.Year.ToString();
            Rfc = ApellidoPaterno[0].ToString();
        for (int elemento = 1; elemento < ApellidoPaterno.Length; elemento++)
        {
            if ((ApellidoPaterno[elemento] == 'A') || (ApellidoPaterno[elemento] == 'E') || (ApellidoPaterno[elemento] == 'I') || (ApellidoPaterno[elemento] == 'O') || (ApellidoPaterno[elemento] == 'U'))
            {
                Rfc = Rfc + ApellidoPaterno[elemento].ToString();
                break;
            }
          }
            Rfc = Rfc + ApellidoMaterno[0].ToString();
            Rfc = Rfc + Nombre[0].ToString();//En este punto revisa si se creó una palabra no conveniente, si es asi,
                                             //se sustituye Nombre[0].ToSrtring(); por 'X'.ToString
        if (FechaDeNacimiento.Month>9)
        {
            Rfc = Rfc + yearString[2].ToString() + yearString[3].ToString() + FechaDeNacimiento.Month.ToString() + FechaDeNacimiento.Day.ToString();
        } else
            Rfc = Rfc + yearString[2].ToString() + yearString[3].ToString() + 0.ToString() + FechaDeNacimiento.Month.ToString() + FechaDeNacimiento.Day.ToString();

    }
        
        public void crearCurp()
        {

        }
    }

