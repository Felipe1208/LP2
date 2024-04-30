using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Copiar!");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Colar!");
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                Application.OpenForms["frmExercicios2"].BringToFront();

            }
            else
            {

                frmExercicio2 objFrm2 = new frmExercicio2();
                objFrm2.MdiParent = this;
                objFrm2.WindowState = FormWindowState.Maximized;
                objFrm2.Show();
            }
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
                {
                    Application.OpenForms["frmExercicios3"].BringToFront();

                }
                else
                {

                    frmExercicio3 objFrm3 = new frmExercicio3();
                    objFrm3.MdiParent = this;
                    objFrm3.WindowState = FormWindowState.Maximized;
                    objFrm3.Show();
                }
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
                {
                    Application.OpenForms["frmExercicios4"].BringToFront();

                }
                else
                {

                    frmExercicio4 objFrm4 = new frmExercicio4();
                    objFrm4.MdiParent = this;
                    objFrm4.WindowState = FormWindowState.Maximized;
                    objFrm4.Show();
                }
            }
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
                {
                    Application.OpenForms["frmExercicios5"].BringToFront();

                }
                else
                {

                    frmExercicio5 objFrm5 = new frmExercicio5();
                    objFrm5.MdiParent = this;
                    objFrm5.WindowState = FormWindowState.Maximized;
                    objFrm5.Show();
                }
            }
        }
    }
}