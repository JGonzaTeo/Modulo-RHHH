using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDiseno;
using CapaDiseno;

namespace Recursos_Humanos.Mantenimientos
{
    public partial class Frm_mantRolespago : Form
    {
        ToolTip ayuda_tp = new ToolTip();
        string ususario;
        public Frm_mantRolespago(string user)
        {
            InitializeComponent();
            ususario = user;
            string[] alias = { "Rol de pago:", "Año:", "Mes:", "Quincena:", "Fecha de elaboracion:", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_roles_de_pago");
            navegador1.asignarNombreForm("Roles de pago");
            ayuda_tp.IsBalloon = true;
        }

        private void Frm_mantRolespago_Load(object sender, EventArgs e)
        {
          
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(ususario);
            navegador1.botonesYPermisosInicial(ususario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
