using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trabalho_Marcio
{
    public partial class Form3 : Form
    {
        

        public Form3()
        {

            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.ShowDialog();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] Raizes = new string [DadosCompartilhados.raizes.Length];
            Raizes = DadosCompartilhados.raizes;
            for (int i = 0; i < Raizes.Length; i++)
            {
                cmb1.Items.Add(Raizes[i]);
            }
        }
    }
}
