using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CalculadoraConHistorial
{
    public partial class Form1 : Form
    {
        double n1, n2;
        string operador;

        List<string> Resultado = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        operaciones op = new operaciones();

        //metodos clear,operaciones

        private void btn_C_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
            operador = "div";
        }

        private void btn_por_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
            operador = "por";
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
            operador = "res";
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
            operador = "sum";
        }

        //metodos numeros y punto

        private void btn_punto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        //metodo pantalla

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        //metodo igual
        private void btn_igual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(Pantalla.Text);
            
            double sum, rest, product, divisio;

            switch (operador) {
                case "sum": sum = op.suma(n1, n2);
                    Pantalla.Text = Convert.ToString(sum);
                    Resultado.Add(System.DateTime.Now + " --- " + Convert.ToString(n1) + "+" + Convert.ToString(n2) + "=" + Convert.ToString(sum));
                    
                    break;
                case "res": rest = op.resta(n1, n2);
                    Pantalla.Text = Convert.ToString(rest);
                    Resultado.Add(System.DateTime.Now + " --- " + Convert.ToString(n1) + "+" + Convert.ToString(n2) + "=" + Convert.ToString(rest));
                    
                    break;
                case "por": product = op.producto(n1, n2);
                    Pantalla.Text = Convert.ToString(product);
                    Resultado.Add(System.DateTime.Now + " --- " + Convert.ToString(n1) + "+" + Convert.ToString(n2) + "=" + Convert.ToString(product));
                    
                    break;
                case "div": divisio = op.division(n1, n2);
                    Pantalla.Text = Convert.ToString(divisio);
                    Resultado.Add(System.DateTime.Now + " --- " + Convert.ToString(n1) + "+" + Convert.ToString(n2) + "=" + Convert.ToString(divisio));
                    
                    break;
            }


            Historial.DataSource = null;
            Historial.DataSource = Resultado;

        }

        //metodo historial
        private void Historial_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
