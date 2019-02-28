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
    public partial class Funcionario : UserControl
    {
        private static Funcionario _instance;
        public static Funcionario Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Funcionario();
                return _instance;
            }
        }
        public Funcionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(FunInsert.Instance))
            {
                pCliWindow.Controls.Add(FunInsert.Instance);
                FunInsert.Instance.Dock = DockStyle.Fill;
                FunInsert.Instance.BringToFront();
            }
            else
            {
                FunInsert.Instance.BringToFront();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(FunUpdate.Instance))
            {
                pCliWindow.Controls.Add(FunUpdate.Instance);
                FunUpdate.Instance.Dock = DockStyle.Fill;
                FunUpdate.Instance.BringToFront();
            }
            else
            {
                FunUpdate.Instance.BringToFront();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(FunDelete.Instance))
            {
                pCliWindow.Controls.Add(FunDelete.Instance);
                FunDelete.Instance.Dock = DockStyle.Fill;
                FunDelete.Instance.BringToFront();
            }
            else
            {
                FunDelete.Instance.BringToFront();
            }
        }
    }
}
