using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_211494
{
    public partial class Form1 : Form
    {
        double adicionar;
        double total_compra;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQuant.Text);
            double valor_uni = double.Parse(txtValor.Text);
            adicionar = quantidade * valor_uni;

            listProdutos.Items.Add(produto + "/" + quantidade + "/" + "R$ " + adicionar);
            total_compra = total_compra + adicionar;
            txtProduto.Clear();
            txtQuant.Clear();
            txtValor.Clear();

            lblTotal.Text = "R$" + total_compra.ToString("F");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQuant.Clear();
            txtValor.Clear();
            listProdutos.Items.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
