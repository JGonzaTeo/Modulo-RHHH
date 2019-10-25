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
    public partial class Frm_mantPuesto : Form
    {
        ToolTip ayuda_tp = new ToolTip();
        string sususario;
        public Frm_mantPuesto(string user)
        {
            InitializeComponent();
            sususario = user;

            string[] alias = { "Codigo Puesto:", "Area:", "Nombre:", "Descripción:","Sueldo:","Estado" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            navegador1.asignarColorFondo(Color.LightBlue);
            navegador1.asignarColorFuente(Color.BlueViolet);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tbl_puestos");
            navegador1.asignarComboConTabla("tbl_areas", "KidArea");
            navegador1.asignarNombreForm("Puestos");
            ayuda_tp.IsBalloon = true;
        }

        private void Frm_mantPuesto_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(sususario);
            navegador1.botonesYPermisosInicial(sususario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
