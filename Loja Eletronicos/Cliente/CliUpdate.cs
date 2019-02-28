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
    public partial class CliUpdate : UserControl
    {
        private static CliUpdate _instance;
        public static CliUpdate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CliUpdate();
                return _instance;
            }
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");

        public void ListaCarrega()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from vi_cliente";
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            while (ret.Read())
            {
                ListViewItem item = new ListViewItem(ret["vcli_codigo"].ToString());
                item.SubItems.Add(ret["vcli_nome"].ToString());
                item.SubItems.Add(ret["vcli_RG"].ToString());
                item.SubItems.Add(ret["vcli_CPF"].ToString());
                item.SubItems.Add(ret["vcli_telefone"].ToString());
                item.SubItems.Add(ret["vcli_celular"].ToString());
                item.SubItems.Add(ret["vcli_endereco"].ToString());
                item.SubItems.Add(ret["vcli_num"].ToString());
                item.SubItems.Add(ret["vcli_bairro"].ToString());
                item.SubItems.Add(ret["vcli_cidade"].ToString());
                lvCliUpdate.Items.Add(item);
            }
            login.Close();
        }
        public CliUpdate()
        {
            InitializeComponent();

            ListaCarrega();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvCliUpdate.Items.Clear();
            ListaCarrega();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var cliUpdate = new CliUpdate1(txbCod.Text);
            cliUpdate.Show();
        }
    }
}
