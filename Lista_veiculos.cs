using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                txt_veiculo.Focus();
                return;
            }
            txt_lista.Text += txt_veiculo.Text + ", ";

            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_lista.Clear();
            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }
    }
}
