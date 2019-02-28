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
    public partial class Venda : UserControl
    {
        private static Venda _instance;
        public static Venda Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Venda();
                return _instance;
            }
        }
        public Venda()
        {
            InitializeComponent();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(MakeSell.Instance))
            {
                pCliWindow.Controls.Add(MakeSell.Instance);
                MakeSell.Instance.Dock = DockStyle.Fill;
                MakeSell.Instance.BringToFront();
            }
            else
            {
                MakeSell.Instance.BringToFront();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(PaySell.Instance))
            {
                pCliWindow.Controls.Add(PaySell.Instance);
                PaySell.Instance.Dock = DockStyle.Fill;
                PaySell.Instance.BringToFront();
            }
            else
            {
                PaySell.Instance.BringToFront();
            }
        }
    }
}
