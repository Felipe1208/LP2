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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (txtpalavra1.Text == "" || txtpalavra2.Text == "")
                MessageBox.Show("palavras não podem ser vazias");
            else
            {
                txtpalavra1.Text = txtpalavra1.Text.ToUpper();
                txtpalavra2.Text = txtpalavra2.Text.ToUpper();
            }
            txtpalavra2.Text = txtpalavra2.Text.Replace(txtpalavra1.Text,"");
        }

        private void btn_inverte_Click(object sender, EventArgs e)
        {
            char[] vetor = txtpalavra1.Text.ToCharArray();
            Array.Reverse(vetor); //inverte legal

            string auxiliar = new string(vetor);
            txtpalavra2.Text = auxiliar;
        }
    }
}
