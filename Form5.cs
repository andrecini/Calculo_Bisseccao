using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Marcio
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            imageList1 = new ImageList();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        public int cont = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont < 9)
            {
                cont++;
                pictureBox1.Image = imageList1.Images[cont];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cont > 0)
            {
                cont--;
                pictureBox1.Image = imageList1.Images[cont];
            }
        }
    }
}
