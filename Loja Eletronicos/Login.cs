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
    public partial class Login : Form
    {
        internal static readonly OracleConnection login;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Usuraio.UserID = tbUser.Text;
            Usuraio.Password = tbSenha.Text;
            OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
            login.Open();

            Form Form1 = new Form1(this);
            Form1.Show();
            this.Hide();
            login.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbSenha_TextChanged(object sender, EventArgs e)
        {
            if ((tbUser.Text != "") && (tbSenha.Text != ""))
            {
                btnConect.Enabled = true;
            }
            else
            {
                btnConect.Enabled = false;
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            if ((tbUser.Text != "") && (tbSenha.Text != ""))
            {
                btnConect.Enabled = true;
            }
            else
            {
                btnConect.Enabled = false;
            }
        }
    }
}
