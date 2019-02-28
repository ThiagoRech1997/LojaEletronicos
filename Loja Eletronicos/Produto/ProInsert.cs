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
    public partial class ProInsert : UserControl
    {
        private static ProInsert _instance;
        public static ProInsert Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProInsert();
                return _instance;
            }
        }
        public ProInsert()
        {
            InitializeComponent();
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbDescricao.Text = "";
            txbMarca.Text = "";
            txbQuantidade.Text = "";
            txbValor.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "Insert into tb_produto values (seq_produto.nextval, '" + txbDescricao.Text + "', '" + txbMarca.Text + "', " + txbQuantidade.Text + ", " + txbValor.Text + ")";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
    }
}
