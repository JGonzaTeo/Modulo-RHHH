using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursos_Humanos.Mantenimientos
{
    public partial class Frm_mantDepartamento : Form
    {

        ToolTip ayuda_tp = new ToolTip();
        public Frm_mantDepartamento()
        {
            InitializeComponent();

            string[] alias = { "Cod Departamento", "Nombre Departamento", "No. Departamento", "Direccion", "Telefono", "Cod Area","Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_departamentos");
            navegador1.asignarComboConTabla("tbl_areas", "KidArea");
            navegador1.asignarNombreForm("Formulaio de Departamentos");
            ayuda_tp.IsBalloon = true;
        }

        private void Frm_mantDepartamento_Load(object sender, EventArgs e)
        {
            //        frm_login login = new frm_login();
            // login.ShowDialog();
            string aplicacionActiva = "1";
            //navegador1.ObtenerIdUsuario(login.obtenerNombreUsuario());
            navegador1.ObtenerIdUsuario("adm");
            //navegador1.botonesYPermisosInicial(login.obtenerNombreUsuario(), aplicacionActiva);
            navegador1.botonesYPermisosInicial("adm", aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
