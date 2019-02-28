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
    public partial class PayBuy1 : Form
    {
        public int codigo;
        public float novoValor;
        public PayBuy1(string cod)
        {
            InitializeComponent();
            codigo = Convert.ToInt32(cod);

            login.Open();
            OracleCommand ret = new OracleCommand();
            ret.Connection = login;
            ret.CommandText = "select cop_valorPrincipal from tb_contaPagar where cop_comCodigo = " + codigo;
            ret.CommandType = CommandType.Text;
            OracleDataReader res = ret.ExecuteReader();
            if (res.Read())
            {
                lblAtual.Text = res["cop_valorPrincipal"].ToString();
            }
            res.Close();
            login.Close();
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "update tb_contaPagar set cop_valorPago = " + txbVall.Text + " where cop_comCodigo = " + codigo;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }

        private void txbVall_TextChanged(object sender, EventArgs e)
        {
            novoValor = (float)Convert.ToDouble(lblAtual.Text) - (float)Convert.ToDouble(txbVall.Text);
            lblNovo.Text = Convert.ToString(novoValor);
        }
    }
}
