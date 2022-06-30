using Microsoft.JScript;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Convert = Microsoft.JScript.Convert;

namespace ProjetoInicial
{

    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }
       
        private void title_Click(object sender, EventArgs e)
        {

        }

        private void n0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void virgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Por Favor, Insira um valor");
            }

                
            if (operacao == "SOMA") { 
                txtResultado.Text = Convert.ToString((double)(valor1 + valor2));
            }
            
            else if(operacao == "SUB"){
                txtResultado.Text = Convert.ToString((double)(valor1 - valor2));
            }
            else if(operacao == "DIV"){
                txtResultado.Text = Convert.ToString((double)(valor1 / valor2));
            }
            else if(operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString((double)(valor1 * valor2));
            }
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != ""){
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Por Favor, Insira um valor");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Por Favor, Insira um valor");
            }
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Por Favor, Insira um valor");
            }
            
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Por Favor, Insira um valor");
            }
            
        }

        private void limparRegistro_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

    }
}