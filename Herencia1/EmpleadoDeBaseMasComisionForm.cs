using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia1
{
    public partial class EmpleadoDeBaseMasComisionForm : Form
    {
        EmpleadoDeBaseMasComision elEmpleado = new EmpleadoDeBaseMasComision();
        public EmpleadoDeBaseMasComisionForm()
        {
            InitializeComponent();
        }

        private void fechaDeNacimiento_monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            elEmpleado.FechaDeNacimiento = fechaDeNacimiento_monthCalendar.SelectionStart.Date;
        }

        private void generarRfc_Btn_Click(object sender, EventArgs e)
        {
            elEmpleado.Nombre = nombre_Tbx.Text.ToUpper();
            elEmpleado.ApellidoPaterno = apellidoPaterno_Tbx.Text.ToUpper();
            elEmpleado.ApellidoMaterno = apellidoMaterno_Tbx.Text.ToUpper();

            elEmpleado.CrearRfc();
            rfc_Tbx.Text = elEmpleado.Rfc;
        }
    }
}
