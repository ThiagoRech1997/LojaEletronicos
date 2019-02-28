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
    public partial class FunUpdate : UserControl
    {
        private static FunUpdate _instance;
        public static FunUpdate Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FunUpdate();
                return _instance;
            }
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        public FunUpdate()
        {
            InitializeComponent();
            ListaCarrega();
        }
        public void ListaCarrega()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from vi_funcionario";
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            while (ret.Read())
            {
                ListViewItem item = new ListViewItem(ret["vfun_codigo"].ToString());
                item.SubItems.Add(ret["vfun_nome"].ToString());
                item.SubItems.Add(ret["vfun_RG"].ToString());
                item.SubItems.Add(ret["vfun_CPF"].ToString());
                item.SubItems.Add(ret["vfun_telefone"].ToString());
                item.SubItems.Add(ret["vfun_celular"].ToString());
                item.SubItems.Add(ret["vfun_endereco"].ToString());
                item.SubItems.Add(ret["vfun_num"].ToString());
                item.SubItems.Add(ret["vfun_bairro"].ToString());
                item.SubItems.Add(ret["vfun_cidade"].ToString());
                item.SubItems.Add(ret["vfun_cargo"].ToString());
                item.SubItems.Add(ret["vfun_salario"].ToString());
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
            var funUpdate = new FunUpdate1(txbCod.Text);
            funUpdate.Show();
        }
    }
}
