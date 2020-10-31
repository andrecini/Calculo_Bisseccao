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

        DataTable Tbl;
        private void button1_Click(object sender, EventArgs e)
        {
            Tbl = new DataTable();

            Tbl.Columns.Add("Rodada", typeof(double));
            Tbl.Columns.Add("a", typeof(double));
            Tbl.Columns.Add("f(a)", typeof(double));
            Tbl.Columns.Add("b", typeof(double));
            Tbl.Columns.Add("f(b)", typeof(double));
            Tbl.Columns.Add("Xk", typeof(double));
            Tbl.Columns.Add("f(Xk)", typeof(double));
            Tbl.Columns.Add("Precisao", typeof(double));

            DataRow Linha;


            int x = 1;

            double[] valorA = new double[x], valorB = new double[x], valorXk = new double[x];

            double[] rodadas = new double[x], precisao = new double[x], funcaoDeA = new double[x], 
            funcaoDeB = new double[x], funcaoDeXk = new double[x];

            double E = Double.Parse(textBox1.Text);
            string a = cmb1.Text.Substring(0, cmb1.Text.IndexOf(";"));
            string b = cmb1.Text.Substring(cmb1.Text.IndexOf(";") + 1, cmb1.Text.Length - (cmb1.Text.IndexOf(";") + 1));
                      
            double aa = Double.Parse(a);
            double bb = Double.Parse(b);

            valorA[0] = aa;
            valorB[0] = bb;

            string formula = DadosCompartilhados.formula;
            string formulaA = formula.Replace("X", a.Replace(",", "."));
            string formulaB = formula.Replace("X", b.Replace(",", "."));

            if ((Convert.ToDouble(EvalCSCode.Eval(formulaA))) > (Convert.ToDouble(EvalCSCode.Eval(formulaB))))
            {
                funcaoDeA[0] = Convert.ToDouble(EvalCSCode.Eval(formulaA));
                funcaoDeB[0] = Convert.ToDouble(EvalCSCode.Eval(formulaB));
            }
            else
            {
                funcaoDeA[0] = Convert.ToDouble(EvalCSCode.Eval(formulaB));
                funcaoDeB[0] = Convert.ToDouble(EvalCSCode.Eval(formulaA));
                double aux = valorB[0];
                valorB[0] = valorA[0];
                valorA[0] = aux;
            }

                 valorXk[0] = (Convert.ToDouble(valorA[0]) + Convert.ToDouble(valorB[0])) / 2;

            string Xk = valorXk[0].ToString();
            Xk = Xk.Replace(",", ".");

            string formulaXk = formula.Replace("X", Xk);

            funcaoDeXk[0] = Convert.ToDouble(EvalCSCode.Eval(formulaXk));
            rodadas[0] = 0;

            for (x = 1; x > -1; x++)
            {

                precisao[x - 1] = valorXk[x - 1] - valorA[x - 1];

                if (precisao[x - 1] < 0)
                    precisao[x - 1] = -precisao[x - 1];


                if (precisao[x - 1] < E)
                {
                    Linha = Tbl.NewRow();

                    Linha[0] = Math.Round(rodadas[x - 1], 7);
                    Linha["a"] = Math.Round(valorA[x - 1], 7);
                    Linha["f(a)"] = Math.Round(funcaoDeA[x - 1], 7);
                    Linha["b"] = Math.Round(valorB[x - 1], 7);
                    Linha["f(b)"] = Math.Round(funcaoDeB[x - 1], 7);
                    Linha["Xk"] = Math.Round(valorXk[x - 1], 7);
                    Linha["f(Xk)"] = Math.Round(funcaoDeXk[x - 1], 7);
                    Linha["Precisao"] = Math.Round(precisao[x - 1], 7);

                    Tbl.Rows.Add(Linha);

                    break;
                }

                Array.Resize(ref valorA, x + 1);
                Array.Resize(ref valorB, x + 1);
                Array.Resize(ref funcaoDeA, x + 1);
                Array.Resize(ref funcaoDeB, x + 1);
                Array.Resize(ref valorXk, x + 1);
                Array.Resize(ref funcaoDeXk, x + 1);
                Array.Resize(ref rodadas, x + 1);
                Array.Resize(ref precisao, x + 1);


                if (funcaoDeXk[x - 1] > 0)
                {
                    valorA[x] = valorXk[x - 1];
                    valorB[x] = valorB[x - 1];
                }
                else if (funcaoDeXk[x - 1] < 0)
                {
                    valorB[x] = valorXk[x - 1];
                    valorA[x] = valorA[x - 1];
                }
                else
                    break;

                a = valorA[x].ToString();
                a = a.Replace(",", ".");
                b= valorB[x].ToString();
                b= b.Replace(",", ".");

                aa = Double.Parse(a);
                bb = Double.Parse(b);               

                formulaA = formula.Replace("X", a);
                formulaB = formula.Replace("X", b);

                funcaoDeA[x] = Convert.ToDouble(EvalCSCode.Eval(formulaA));
                funcaoDeB[x] = Convert.ToDouble(EvalCSCode.Eval(formulaB));

                valorXk[x] = (valorA[x] + valorB[x]) / 2;
                Xk = valorXk[x].ToString();
                Xk = Xk.Replace(",", ".");

                formulaXk = formula.Replace("X", Xk);

                funcaoDeXk[x] = Convert.ToDouble(EvalCSCode.Eval(formulaXk));

                rodadas[x] = x;

                Linha = Tbl.NewRow();

                Linha[0] = Math.Round(rodadas[x - 1], 7);
                Linha["a"] = Math.Round(valorA[x - 1], 7);
                Linha["f(a)"] = Math.Round(funcaoDeA[x - 1], 7);
                Linha["b"] = Math.Round(valorB[x - 1], 7);
                Linha["f(b)"] = Math.Round(funcaoDeB[x - 1], 7);
                Linha["Xk"] = Math.Round(valorXk[x - 1], 7);
                Linha["f(Xk)"] = Math.Round(funcaoDeXk[x - 1], 7);
                Linha["Precisao"] = Math.Round(precisao[x - 1], 7);

                Tbl.Rows.Add(Linha);
            }


            TabelaBisseccao.DataSource = Tbl;


        }
    }
}
