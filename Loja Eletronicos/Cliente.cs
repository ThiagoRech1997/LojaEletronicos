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
    public partial class Cliente : UserControl
    {
        private static Cliente _instance;
        public static Cliente Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new Cliente();
                return _instance;
            }
        }
        public Cliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(CliInsert.Instance))
            {
                pCliWindow.Controls.Add(CliInsert.Instance);
                CliInsert.Instance.Dock = DockStyle.Fill;
                CliInsert.Instance.BringToFront();
            }
            else
            {
                CliInsert.Instance.BringToFront();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(CliUpdate.Instance))
            {
                pCliWindow.Controls.Add(CliUpdate.Instance);
                CliUpdate.Instance.Dock = DockStyle.Fill;
                CliUpdate.Instance.BringToFront();
            }
            else
            {
                CliUpdate.Instance.BringToFront();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(CliDelete.Instance))
            {
                pCliWindow.Controls.Add(CliDelete.Instance);
                CliDelete.Instance.Dock = DockStyle.Fill;
                CliDelete.Instance.BringToFront();
            }
            else
            {
                CliDelete.Instance.BringToFront();
            }
        }
    }
}
