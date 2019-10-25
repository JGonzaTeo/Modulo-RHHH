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
    public partial class Frm_mantAreas : Form
    {

        ToolTip ayuda_tp = new ToolTip();
        string sususario;
        public Frm_mantAreas(string user)
        {
            InitializeComponent();
            sususario = user;
            string[] alias = { "Cod Area", "Nombre", "Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_areas");
            navegador1.asignarNombreForm("Areas");
            ayuda_tp.IsBalloon = true;
        }

        private void Frm_mantAreas_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(sususario);
            navegador1.botonesYPermisosInicial(sususario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
