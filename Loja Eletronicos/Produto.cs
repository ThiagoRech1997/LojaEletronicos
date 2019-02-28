using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Eletronicos
{
    public partial class Produto : UserControl
    {
        private static Produto _instance;
        public static Produto Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Produto();
                return _instance;
            }
        }
        public Produto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(ProInsert.Instance))
            {
                pCliWindow.Controls.Add(ProInsert.Instance);
                ProInsert.Instance.Dock = DockStyle.Fill;
                ProInsert.Instance.BringToFront();
            }
            else
            {
                ProInsert.Instance.BringToFront();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(ProUpdate.Instance))
            {
                pCliWindow.Controls.Add(ProUpdate.Instance);
                ProUpdate.Instance.Dock = DockStyle.Fill;
                ProUpdate.Instance.BringToFront();
            }
            else
            {
                ProUpdate.Instance.BringToFront();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(ProDelete.Instance))
            {
                pCliWindow.Controls.Add(ProDelete.Instance);
                ProDelete.Instance.Dock = DockStyle.Fill;
                ProDelete.Instance.BringToFront();
            }
            else
            {
                ProDelete.Instance.BringToFront();
            }
        }
    }
}
