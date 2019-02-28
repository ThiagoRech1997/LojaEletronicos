using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Loja_Eletronicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Janela.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            Janela.Show();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Vendas";
        }

        private void pboxHome_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Início";
        }

        private void pboxCliente_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Clientes";
        }

        private void pboxCompra_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Compras";
        }

        private void pboxFuncionario_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Funcionarios";
        }

        private void pboxProduto_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Produtos";
        }

        private void pboxCaixa_MouseMove(object sender, MouseEventArgs e)
        {
            lblHader.Text = "Caixa";
        }

        private void pboxHome_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(HomePage.Instance))
            {
                panel2.Controls.Add(HomePage.Instance);
                HomePage.Instance.Dock = DockStyle.Fill;
                HomePage.Instance.BringToFront();
            }
            else
            {
                HomePage.Instance.BringToFront();
            }
        }

        private void pboxCliente_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Cliente.Instance))
            {
                panel2.Controls.Add(Cliente.Instance);
                Cliente.Instance.Dock = DockStyle.Fill;
                Cliente.Instance.BringToFront();
            }
            else
            {
                Cliente.Instance.BringToFront();
            }
        }

        private void pboxVenda_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Venda.Instance))
            {
                panel2.Controls.Add(Venda.Instance);
                Venda.Instance.Dock = DockStyle.Fill;
                Venda.Instance.BringToFront();
            }
            else
            {
                Venda.Instance.BringToFront();
            }
        }

        private void pboxCompra_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Compra.Instance))
            {
                panel2.Controls.Add(Compra.Instance);
                Compra.Instance.Dock = DockStyle.Fill;
                Compra.Instance.BringToFront();
            }
            else
            {
                Compra.Instance.BringToFront();
            }
        }

        private void pboxFuncionario_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Funcionario.Instance))
            {
                panel2.Controls.Add(Funcionario.Instance);
                Funcionario.Instance.Dock = DockStyle.Fill;
                Funcionario.Instance.BringToFront();
            }
            else
            {
                Funcionario.Instance.BringToFront();
            }
        }

        private void pboxProduto_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Produto.Instance))
            {
                panel2.Controls.Add(Produto.Instance);
                Produto.Instance.Dock = DockStyle.Fill;
                Produto.Instance.BringToFront();
            }
            else
            {
                Produto.Instance.BringToFront();
            }
        }

        private void pboxCaixa_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(Caixa.Instance))
            {
                panel2.Controls.Add(Caixa.Instance);
                Caixa.Instance.Dock = DockStyle.Fill;
                Caixa.Instance.BringToFront();
            }
            else
            {
                Caixa.Instance.BringToFront();
            }
        }

        private void pboxHome_Click(object sender, MouseEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
