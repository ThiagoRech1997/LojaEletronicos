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
    public partial class Compra : UserControl
    {
        private static Compra _instance;
        public static Compra Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Compra();
                return _instance;
            }
        }
        public Compra()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(MakeBuy.Instance))
            {
                pCliWindow.Controls.Add(MakeBuy.Instance);
                MakeBuy.Instance.Dock = DockStyle.Fill;
                MakeBuy.Instance.BringToFront();
            }
            else
            {
                MakeBuy.Instance.BringToFront();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!pCliWindow.Controls.Contains(PayBuy.Instance))
            {
                pCliWindow.Controls.Add(PayBuy.Instance);
                PayBuy.Instance.Dock = DockStyle.Fill;
                PayBuy.Instance.BringToFront();
            }
            else
            {
                PayBuy.Instance.BringToFront();
            }
        }
    }
}
