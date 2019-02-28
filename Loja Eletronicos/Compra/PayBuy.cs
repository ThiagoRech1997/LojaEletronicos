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
    public partial class PayBuy : UserControl
    {
        private static PayBuy _instance;
        public static PayBuy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PayBuy();
                return _instance;
            }
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        public PayBuy()
        {
            InitializeComponent();
            ListaCarrega();
        }
        public void ListaCarrega()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from vi_notaFornecedor";
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            while (ret.Read())
            {
                ListViewItem item = new ListViewItem(ret["vnot_codigo"].ToString());
                item.SubItems.Add(ret["vnot_cliNome"].ToString());
                item.SubItems.Add(ret["vnot_CNPJ"].ToString());
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
            var payBuy = new PayBuy1(txbCod.Text);
            payBuy.Show();
        }
    }
}
