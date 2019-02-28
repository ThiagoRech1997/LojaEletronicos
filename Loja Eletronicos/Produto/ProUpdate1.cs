using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Eletronicos
{
    public partial class ProUpdate1 : Form
    {
        string codRev;
        public ProUpdate1(string cod)
        {
            InitializeComponent();
            codRev = cod;
            RecebeDados();
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        private void RecebeDados()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from tb_produto where pro_codigo = " + codRev;
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            if (ret.Read())
            {
                txbDescricao.Text = ret["pro_descricao"].ToString();
                txbMarca.Text = ret["pro_marca"].ToString();
                txbQuantidade.Text = ret["pro_quantidade"].ToString();
                txbValor.Text = ret["pro_valorUnit"].ToString();
            }
            else
            {
                MessageBox.Show("Não foi possivel recuperar dados");
            }
            ret.Close();
            login.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            login.Open();
            OracleCommand update = new OracleCommand();
            update.Connection = login;
            update.CommandText = "update tb_produto set pro_descricao = '" + txbDescricao.Text + "', pro_marca = '" + txbMarca.Text + "', pro_quantidade = " + txbQuantidade.Text + ", pro_valorUnit = " + txbValor.Text + " where pro_codigo = " + codRev;
            update.CommandType = CommandType.Text;
            update.ExecuteNonQuery();
            login.Close();
        }
    }
}
