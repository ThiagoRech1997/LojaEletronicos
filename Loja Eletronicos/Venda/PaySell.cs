using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Loja_Eletronicos
{
    public partial class PaySell : UserControl
    {
        private static PaySell _instance;
        public static PaySell Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PaySell();
                return _instance;
            }
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        public PaySell()
        {
            InitializeComponent();
            ListaCarrega();
        }
        public void ListaCarrega()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from vi_notaCliente";
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            while (ret.Read())
            {
                ListViewItem item = new ListViewItem(ret["vnot_codigo"].ToString());
                item.SubItems.Add(ret["vnot_cliNome"].ToString());
                item.SubItems.Add(ret["vnot_CPF"].ToString());
                item.SubItems.Add(ret["vnot_endereco"].ToString());
                item.SubItems.Add(ret["vnot_num"].ToString());
                item.SubItems.Add(ret["vnot_bairro"].ToString());
                item.SubItems.Add(ret["vnot_cidade"].ToString());
                item.SubItems.Add(ret["vnot_funNome"].ToString());
                item.SubItems.Add(ret["vnot_data"].ToString());
                item.SubItems.Add(ret["vnot_vencimento"].ToString());
                item.SubItems.Add(ret["vnot_produto"].ToString());
                item.SubItems.Add(ret["vnot_valorTotal"].ToString());
                lvCliUpdate.Items.Add(item);
            }
            login.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvCliUpdate.Items.Clear();
            ListaCarrega();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var paySell = new PaySell1(txbCod.Text);
            paySell.Show();
        }

        private void lvCliUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
