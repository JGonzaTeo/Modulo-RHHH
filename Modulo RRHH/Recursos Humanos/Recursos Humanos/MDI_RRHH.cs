using Recursos_Humanos.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursos_Humanos
{
    public partial class MDI_RRHH : Form
    {
        private int childFormNumber = 0;

        public MDI_RRHH()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        bool ventanaNomina = false;
        Frm_nominas nomina = new Frm_nominas();
        private void NóminasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_nominas);
            if (ventanaNomina == false || frmC == null)
            {
                if (frmC == null)
                {
                    nomina = new Frm_nominas();
                }

                nomina.MdiParent = this;
                nomina.Show();
                Application.DoEvents();
                ventanaNomina = true;
            }
            else
            {
                nomina.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCapacitacion = false;
        Frm_capacitaciones capacitacion = new Frm_capacitaciones();
        private void CapacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_capacitaciones);
            if (ventanaCapacitacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    capacitacion = new Frm_capacitaciones();
                }

                capacitacion.MdiParent = this;
                capacitacion.Show();
                Application.DoEvents();
                ventanaCapacitacion = true;
            }
            else
            {
                capacitacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaEmpleado = false;
        Frm_mantEmpleado empleado = new Frm_mantEmpleado();
        private void EmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantEmpleado);
            if (ventanaEmpleado == false || frmC == null)
            {
                if (frmC == null)
                {
                    empleado = new Frm_mantEmpleado();
                }

                empleado.MdiParent = this;
                empleado.Show();
                Application.DoEvents();
                ventanaEmpleado = true;
            }
            else
            {
                empleado.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaPuesto = false;
        Frm_mantPuesto puesto = new Frm_mantPuesto();
        private void PuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantPuesto);
            if (ventanaPuesto == false || frmC == null)
            {
                if (frmC == null)
                {
                    puesto = new Frm_mantPuesto();
                }

                puesto.MdiParent = this;
                puesto.Show();
                Application.DoEvents();
                ventanaPuesto = true;
            }
            else
            {
                puesto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaDepartamento = false;
        Frm_mantDepartamento departamento = new Frm_mantDepartamento();
        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mantDepartamento);
            if (ventanaDepartamento == false || frmC == null)
            {
                if (frmC == null)
                {
                    departamento = new Frm_mantDepartamento();
                }

                departamento.MdiParent = this;
                departamento.Show();
                Application.DoEvents();
                ventanaDepartamento = true;
            }
            else
            {
                departamento.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
