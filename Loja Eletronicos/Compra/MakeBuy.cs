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
    public partial class MakeBuy : UserControl
    {
        public int codFor;
        public int codFun;
        public int codPro;
        private static MakeBuy _instance;
        public static MakeBuy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MakeBuy();
                return _instance;
            }
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        public MakeBuy()
        {
            InitializeComponent();
            ListaFuncionario();
            ListaProduto();
            ListaFornecedor();
        }
        public void ListaFuncionario()
        {
            login.Open();
            OracleCommand lcom = new OracleCommand();
            lcom.Connection = login;
            lcom.CommandText = "select fun_nome from tb_funcionario";
            lcom.CommandType = CommandType.Text;
            OracleDataReader ret = lcom.ExecuteReader();
            while (ret.Read())
            {
                cbxFuncionario.Items.Add(ret["fun_nome"].ToString());
            }
            ret.Close();
            login.Close();
        }
        public void ListaProduto()
        {
            login.Open();
            OracleCommand lcom = new OracleCommand();
            lcom.Connection = login;
            lcom.CommandText = "select pro_descricao from tb_produto";
            lcom.CommandType = CommandType.Text;
            OracleDataReader ret = lcom.ExecuteReader();
            while (ret.Read())
            {
                cbxProduto.Items.Add(ret["pro_descricao"].ToString());
            }
            ret.Close();
            login.Close();
        }
        public void ListaFornecedor()
        {
            login.Open();
            OracleCommand lcom = new OracleCommand();
            lcom.Connection = login;
            lcom.CommandText = "select for_nome from tb_fornecedor";
            lcom.CommandType = CommandType.Text;
            OracleDataReader ret = lcom.ExecuteReader();
            while (ret.Read())
            {
                cbxFornecedor.Items.Add(ret["for_nome"].ToString());
            }
            ret.Close();
            login.Close();
        }
        public void Fornecedor()
        {
            login.Open();
            OracleCommand ret = new OracleCommand();
            ret.Connection = login;
            ret.CommandText = "select for_codigo from tb_fornecedor where for_nome = '" + cbxFornecedor.Text + "'";
            ret.CommandType = CommandType.Text;
            OracleDataReader cli = ret.ExecuteReader();
            if (cli.Read())
            {
                codFor = cli.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado");
            }
            cli.Close();
            login.Close();
        }
        public void Produto()
        {
            login.Open();
            OracleCommand ret = new OracleCommand();
            ret.Connection = login;
            ret.CommandText = "select pro_codigo from tb_produto where pro_descricao = '" + cbxProduto.Text + "'";
            ret.CommandType = CommandType.Text;
            OracleDataReader pro = ret.ExecuteReader();
            if (pro.Read())
            {
                codPro = pro.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado");
            }
            pro.Close();
            login.Close();
        }
        public void Funcionario()
        {
            login.Open();
            OracleCommand ret = new OracleCommand();
            ret.Connection = login;
            ret.CommandText = "select fun_codigo from tb_funcionario where fun_nome = '" + cbxFuncionario.Text + "'";
            ret.CommandType = CommandType.Text;
            OracleDataReader fun = ret.ExecuteReader();
            if (fun.Read())
            {
                codFun = fun.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Funcionario não encontrado");
            }
            fun.Close();
            login.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbxFornecedor.Text = "";
            cbxFuncionario.Text = "";
            txbQuantidade.Text = "";
            txbValorUnit.Text = "";
            cbxProduto.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Compra();
            ItemCompra();
            ContaPagar();
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "update tb_contaPagar set cop_valorPrincipal = func_valorTotalCompra((select max(com_codigo) from tb_compra)) where cop_codigo = (select max(cop_codigo) from tb_contaPagar)";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
        public void Compra()
        {
            Fornecedor();
            Funcionario();
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "insert into tb_compra values(seq_compra.nextval, " + codFor + ", " + codFun + ", sysdate)";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
        public void ItemCompra()
        {
            Produto();
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "insert into tb_itemCompra values (seq_compra.currval, " + codPro + ", " + txbQuantidade.Text + ", " + txbValorUnit.Text + ")";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
        public void ContaPagar()
        {
            int qt = Convert.ToInt32(txbQuantidade.Text);
            float vl = (float)Convert.ToDouble(txbValorUnit.Text);
            float total = qt * vl;
            login.Open();
            string query = "(cop_codigo, cop_dataEmicao, cop_dataVencimento, cop_valorPrincipal, cop_valorJuro, cop_comCodigo, cop_numParcela, cop_situacao)";
            string query1 = "(seq_contaPagar.nextval, sysdate, sysdate+30, 0, 0, seq_compra.currval, 1, 'ABERTO')";
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "insert into tb_contaPagar" + query + "values" + query1;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            login.Open();
            OracleCommand pre = new OracleCommand();
            pre.Connection = login;
            pre.CommandText = "select pro_valorUnit from tb_produto where pro_descricao = '" + cbxProduto.Text + "'";
            pre.CommandType = CommandType.Text;
            OracleDataReader pret = pre.ExecuteReader();
            if (pret.Read())
            {
                txbValorUnit.Text = pret["pro_valorUnit"].ToString();
            }
            pret.Close();
            login.Close();
        }
    }
}
