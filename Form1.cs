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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(BtnRaiz, " Substitua o α (alpha) para calcular a Raíz Quadrada da expressão. Ex.: " +
                                         "Math.Sqrt(4) = √4 = 2.");

            toolTip1.SetToolTip(BtnPot2, " Substitua o α (alpha) para calcular o quadrado da expressão. Ex.: " +
                                         "Math.Pow(4) = 4² = 16.");

            toolTip1.SetToolTip(BtnPot, " Substitua o α (alpha) e o β (beta) para calcular potência desejada da expressão. Ex.: " +
                                         "Math.Pow(2, 3) = 2³ = 8.");

            toolTip1.SetToolTip(BtnEuller, " Substitua o α (alpha) para calcular a potência desejada de Euller. Ex.: " +
                                         "Math.EXP(2) = e² ~ 7,389.");

            toolTip1.SetToolTip(BtnLn, " Substitua o α (alpha) e o β (beta) para calcular o LN da expressão. Ex.: " +
                                         "Math.Log(2) = Ln(2) ~ 0,693.");

            toolTip1.SetToolTip(BtnLog, " Substitua o α (alpha) para calcular o LOG na base 10 da expressão. Ex.: " +
                                         "Math.Log10(2) = Log(2) ~ 0,301.");

            toolTip1.SetToolTip(BtnCos, " Substitua o α (alpha) para calcular o COSSENO da expressão. Ex.: " +
                                         "Math.Cos(0) = Cos(0) = 1.");

            toolTip1.SetToolTip(BtnSen, " Substitua o α (alpha) para calcular o SENO da expressão. Ex.: " +
                                        "Math.Sen(0) = Sen(0) = 0.");

            toolTip1.SetToolTip(BtnTan, " Substitua o α (alpha) para calcular o TANGENTE da expressão. Ex.: " +
                                        "Math.Tan(0) = Tan(0) = 0.");

            toolTip1.SetToolTip(BtnPI, " Valor de π (3,14159265...).");


        }

        public List<string> Lista = new List<string>();
        public List<string> Raizes = new List<string>();
        public bool messagebox = true;
        public string formulaFinal;
        public static double Evaluate(string formulaFinal)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("formulaFinal", string.Empty.GetType(), formulaFinal);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["formulaFinal"]);
        }
        

        
        //***************************************************************************************************                                 
        // Botões de Numéricos!          
        #region 

        // Botão "1"
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "1";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "1";
            }
            else
            {
                Lista.Add("1");
                Display.Text += "1";                       
            }
        }
        
        // Botão "2"
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "2";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "2";
            }
            else
            {
                Lista.Add("2");
                Display.Text += "2";
            }
        }
        
        // Botão "3"
        private void Btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "3";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "3";
            }
            else
            {
                Lista.Add("3");
                Display.Text += "3";
            }
        }
        
        // Botão "4"
        private void Btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "4";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "4";
            }
            else
            {
                Lista.Add("4");
                Display.Text += "4";
            }
        }
        
        // Botão "5"
        private void Btn5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "5";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "5";
            }
            else
            {
                Lista.Add("5");
                Display.Text += "5";
            }
        }
        
        // Botão "6
        private void Btn6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "6";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "6";
            }
            else
            {
                Lista.Add("6");
                Display.Text += "6";
            }
        }
        
        // Botão "7"
        private void Btn7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "7";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "7";
            }
            else
            {
                Lista.Add("7");
                Display.Text += "7";
            }
        }
        
        // Botão "8"
        private void Btn8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "8";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "8";
            }
            else
            {
                Lista.Add("8");
                Display.Text += "8";
            }
        }
        
        // Botão "9"
        private void Btn9_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "9";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "9";
            }
            else
            {
                Lista.Add("9");
                Display.Text += "9";
            }
        }
        
        // Botão "0"
        private void Btn0_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "0";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "0";
            }
            else
            {
                Lista.Add("0");
                Display.Text += "0";
            }
        }
        
        // Botão "π"
        private void BtnPI_Click(object sender, EventArgs e)
        {
            double aux = Math.Round(Math.PI, 5);

            if (textBox1.Enabled == true)
            {
                textBox1.Text += "π";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "π";
            }
            else
            {

                Lista.Add("π");
                Display.Text += $"{aux}";
            }
        }

        // Botão "X"
        private void BtnX_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "(X)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "(X)";
            }
            else
            {
                Lista.Add("(X)");
                Display.Text += "(X)";
            }
        }
        #endregion ## //                       
        //***************************************************************************************************


        //***************************************************************************************************
        // Botões de Cálculo básico
        #region

        // Botão "÷"
        private void BtnDivide_Click(object sender, EventArgs e)

        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "/";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "/";
            }
            else
            {
                Lista.Add("/");
                Display.Text += "/";
            }
        }
       
        // Botão "*"
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "*";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "*";
            }
            else
            {
                Lista.Add("*");
                Display.Text += "*";
            }
        }
       
        // Botão "-"
        private void ButtonMen_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "-";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "-";
            }
            else
            {
                Lista.Add("-");
                Display.Text += "-";
            }
        }
       
        // Botão "+"
        private void Btnmais_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "+";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "+";
            }
            else
            {
                Lista.Add("+");
                Display.Text += "+";
            }
        }
        #endregion
        //***************************************************************************************************


        //***************************************************************************************************
        // Botões de formatação
        #region

        // Botão "."
        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += ".";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += ".";
            }
            else
            {
                Lista.Add(".");
                Display.Text += ".";
            }
        }

        // Botão "("
        private void BtnP1_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "(";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "(";
            }
            else
            {
                Lista.Add("(");
                Display.Text += "(";
            }
        }

        // Botão ")"
        private void BtnP2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += ")";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += ")";
            }
            else
            {
                Lista.Add(")");
                Display.Text += ")";
            }
        }

        // Botão "C"
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        // Botão "DEL"
        private void BtnDel_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length - 1);
        }

        #endregion
        //***************************************************************************************************


        //***************************************************************************************************
        // Botões de Cálculo avançado
        #region

        // Botão "√"
        private void BtnRaiz_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Sqrt(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Sqrt(α)";
            }
            else
            {
                Display.Text += "Math.Sqrt(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;
               
                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                     "     " + "(Math.Sqrt( X*Math.Sqrt(2) ), por exemplo), é necessário escrever a" +
                                    " função no formato C#, caso contrário, não será possível finalizar " +
                                    "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                    "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    messagebox = false;
                }

                Display.Enabled = false;
            }        
        }

        // Botão "Ln"
        private void BtnLn_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Log(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Log(α)";
            }
            else
            {
                Display.Text += "Math.Log(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Log( X*Math.Log(2) ), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        // Botão "SEN (X)"
        private void BtnSen_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Sin(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Sin(α)";
            }
            else
            {
                Display.Text += "Math.Sin(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Sen( X*Math.Sen(0) ), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }

                Display.Enabled = false;
            }
        }
        
        // Botão "COS (X)"
        private void BtnCos_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Cos(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Cos(α)";
            }
            else
            {
                Display.Text += "Math.Cos(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Cos( X*Math.Cos(0) ), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        // Botão "TAN (X)"
        private void BtnTan_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Tan(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Tan(α)";
            }
            else
            {
                Display.Text += "Math.Tan(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " +      "(Math.Tan( X*Math.Tan(0)), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }

        // Botão "x²"
        private void BtnPot2_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Pow(α, 2)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Pow(α, 2)";
            }
            else
            {
                Display.Text += "Math.Pow(α, 2)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Pow( X*Math.Pow(α, 2), 2), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Display.Enabled = false;
                    messagebox = false;
                }
            }
        }

        // Botão "e^x"
        private void BtnEuller_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Exp(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Exp(α)";
            }
            else
            {
                Display.Text += "Math.Exp(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " +      "(Math.Pow( X*Math.Exp(Math.Exp(α)), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }

                    Display.Enabled = false;
                
                }
            }
        
        // Botão "LOG10"
        private void BtnLog_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Log10(α)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Log10(α)";
            }
            else
            {
                Display.Text += "Math.Log10(α)";
                groupBox2.Enabled = true;
                textBox2.Enabled = false;

                if (messagebox == true)
                {
                    MessageBox.Show(" Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + "(Math.Log10( X*Math.Exp(Math.Log10(α)), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar " +
                                "o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a " +
                                "estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }

                Display.Enabled = false;
            }
        }

        // Botão "POT"
        private void BtnPot_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true)
            {
                textBox1.Text += "Math.Pow(α, β)";
            }
            else if (textBox2.Enabled == true)
            {
                textBox2.Text += "Math.Pow(α, β)";
            }
            else
            {
                Display.Text += "Math.Pow(α, β)";
                groupBox2.Enabled = true;
                textBox2.Enabled = true;

                if (messagebox == true)
                {
                    MessageBox.Show("  Caso você queira substituir α (alpha) por uma outra função" +
                 "     " + " (Math.Pow(Math.Pow(α, β), X), por exemplo), é necessário escrever a" +
                                " função no formato C#, caso contrário, não será possível finalizar" +
                                " o cálculo. Qualquer dúvida, clicar no botão de ajuda para entender a" +
                                " estrutura.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    messagebox = false;
                }
                Display.Enabled = false;
            }
        }
        #endregion
        //***************************************************************************************************


        //***************************************************************************************************
        // Botões de Tomada de decisão
        #region
        private void BtnSubstituicao_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Replace("α", textBox1.Text);

            if (Display.Text.IndexOf("β") != 1)
            {
                Display.Text = Display.Text.Replace("β", textBox2.Text);
            }

            textBox1.Text = "";
            textBox2.Text = "";

            groupBox2.Enabled = false;
            Display.Enabled = true;

        }

        private void BtnBolzano_Click(object sender, EventArgs e)
        {
            BtnBolzano.UseWaitCursor = true;

            try
            {
                double E = Double.Parse(comboBox2.Text);
                label7.Visible = true;
                double a = double.Parse(textBox3.Text.Replace(",", "."));
                double b = double.Parse(textBox4.Text.Replace(",", "."));
                double i = a + E;

                do
                {
                    string x = i.ToString().Replace(",", ".");
                    string y = (i - E).ToString().Replace(",", ".");

                    string alfa = Display.Text.Replace("X", x);
                    string beta = Display.Text.Replace("X", y);

                    double aux1a, aux1b;

                     aux1a = Convert.ToDouble(EvalCSCode.Eval(alfa));
                     aux1b = Convert.ToDouble(EvalCSCode.Eval(beta));
                    

                    if (aux1a >= 0 && aux1b < 0)
                    {
                        Raizes.Add($"{i - E}; {i}");
                    }
                    else if (aux1a < 0 && aux1b >= 0)
                    {
                        Raizes.Add($"{i}; {i - E}");
                    }

                    i += E;
                } while (i <= b);

                for (int j = 0; j < Raizes.Count; j++)
                    comboBox1.Items.Add(Raizes.ElementAt(j));

                label7.Visible = false;
                BtnBolzano.UseWaitCursor = false;

                BtnTabela.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Digite um valor válido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {    
            if (Display.Text.IndexOf("X") == -1 && Display.Text.IndexOf("x") == -1)
            {
                double aux = Convert.ToDouble(EvalCSCode.Eval(Display.Text));
                aux = Math.Round(aux, 6);
                Display.Text = aux.ToString();
            }
            else
            {
                groupBox3.Enabled = true;
            }

            DadosCompartilhados.formula = Display.Text;

        }
       
        private void BtnTabela_Click(object sender, EventArgs e)
        {
            Form3 tabela = new Form3();
            string[] Raizes1 = Raizes.ToArray();
            DadosCompartilhados.raizes = Raizes1;
            Hide();
            tabela.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 ajuda = new Form2();
            this.Hide();
            ajuda.Show();
        }
        #endregion
        //***************************************************************************************************
    }

}
