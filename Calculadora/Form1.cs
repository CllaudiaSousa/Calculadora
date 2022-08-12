using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        int contVisor;
        double valor1 = 0;
        double memAux;
        string operador;


        private void btn0_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '0';
                contVisor++;
            }
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            contVisor = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '1';
                contVisor++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '2';
                contVisor++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '3';
                contVisor++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '4';
                contVisor++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '5';
                contVisor++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '6';
                contVisor++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '7';
                contVisor++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '8';
                contVisor++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contVisor != 9)
            {
                txtVisor.Text += '9';
                contVisor++;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "+";
                txtVisor.Clear();
                contVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "-";
                txtVisor.Clear();
                contVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "X";
                txtVisor.Clear();
                contVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                valor1 = Convert.ToDouble(txtVisor.Text);

                operador = "/";
                txtVisor.Clear();
                contVisor = 0;

                btnSomar.Enabled = false;
                btnSub.Enabled = false;
                btnMulti.Enabled = false;
                btnDiv.Enabled = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(txtVisor.Text != "")
            {
                memAux = Convert.ToDouble(txtVisor.Text);
                
                switch(operador)
                {
                    case "+":
                        valor1 += memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "-":
                        valor1 -= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "X":
                        valor1 *= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;

                    case "/":
                        if(valor1 != 0 && memAux != 0 )
                        {
                            valor1 = valor1 / memAux;
                            txtVisor.Text = Convert.ToString(valor1);
                            valor1 = 0;
                        }
                        else
                        {
                            MessageBox.Show("IMPOSSÍVEL REALIZAR DIVISÃO POR 0!", "ERRO DE EXECUÇÃO");
                            valor1 = 0;
                            memAux =  0;
                            txtVisor.Clear();
                        }
                        break;
                    default:
                        break;
                 }
                contVisor = 0;

                btnSomar.Enabled = true;
                btnSub.Enabled = true;
                btnMulti.Enabled = true;
                btnDiv.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = contVisor = 0;

            btnSomar.Enabled = true;
            btnSub.Enabled = true;
            btnMulti.Enabled = true;
            btnDiv.Enabled = true;
        }
    }
}
