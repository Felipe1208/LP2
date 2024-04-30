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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btn_compara_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtpalavra1.Text, txtpalavra2.Text, true) == 0)
            {
                MessageBox.Show("são iguais");
            }
            else
            {
                MessageBox.Show("são diferentes");
            }
        }

        private void btn_insere1_Click(object sender, EventArgs e)
        {
            int meio = txtpalavra2.Text.Length / 2;
            txtpalavra2.Text = txtpalavra2.Text.Substring(0, meio) +
                txtpalavra1.Text + txtpalavra2.Text.Substring(meio,
            txtpalavra2.Text.Length - meio);
        }

        private void btn_insere2_Click(object sender, EventArgs e)
        {
            int meio = txtpalavra1.Text.Length / 2;
            txtpalavra2.Text = txtpalavra1.Text.Insert(meio, "**");
            
        }
    }
}
