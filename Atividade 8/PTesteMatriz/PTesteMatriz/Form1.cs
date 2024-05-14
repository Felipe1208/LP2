using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PTesteMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar;
            for (int i = 0; i ‹ vetor.Length; i++) {
                auxiliar = Interaction.InputBox($"Digite un número ((i + 1)°)", "Entrada de dados*);
                if (!int.TryParse(auxiliar, out vetor(i])) {
                    MessageBox.Show("Número inválido");
                    i--;
                }
            }
            Array.Reverse(vetor);
            auxiliar = "";

            foreach (int i in vetor) {
                auxiliar += i + "\n";
            }
            MessageBox.Show(auxiliar);
            
        }
        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            ArrayList Lista = new ArrayList();
            Lista.Add("Ana");
            Lista.Add("André");
            Lista.Add("Débora");
            Lista.Add("Fátima");
            Lista.Add("João");
            Lista.Add("Janete");
            Lista.Add("Otávio");
            Lista.Add("Marcelo");
            Lista.Add("Pedro");
            Lista.Add("Thais");
            Lista.Remove("Otávio");
            string auxiliar = "";
            foreach (string nome in Lista)
            {
                auxiliar += nome + "n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] media = new double[20];
            string auxiliar, auxiliar2 = " Aluno
            Nota 1 Nota 2 Nota 3\n *;
            for (int i = 0;
            i ‹ notas.GetLength(0); i++)
            for (int j = 0; j ‹ notas.GetLength(1); j +)
            auxiliar = Interaction.InputBox($"Digite a nota (j+1) do aluno (i+1)");
            if (!double.TryParse(auxiliar, out notas(i, j)))
                MessageBox.Show("Número inválido");
            else
            if (notas(i, j] ‹ 0 Il notas(i, j] > 10)
            MessageBox.Show("Notas devem estar entre 0 e 10");
            i -;
            if (i ‹ 9)
            auxiliar2 += ($"Aluno Oi + 1}
            " + notas(i, 0]+ "
            " + notas(i, 0] + "
            else
                auxiliar2 += ($"Aluno (1 + 1}
            for (int 1 = 0; 1 < media.GetLength(0); 1H)
                media[i] = (notas[i, 0] + notas(i, 1] + notas(1, 21) / 3;
            auxiliar =
            for (int i = 0; 1 < media.GetLength(e); i + *)
                auxiliar #= (S"Aluno (I+ 1): média: " + medialij. Tostring("129) + Ia);
            MessageBox.Show(auxiliar);
            MessageBox.Show(auxiliar2);
        }
    }
}
