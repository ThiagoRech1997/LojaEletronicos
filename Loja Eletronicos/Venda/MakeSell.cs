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
    public partial class MakeSell : UserControl
    {
        public int codCli;
        public int codFun;
        public int codPro;
        private static MakeSell _instance;
        public static MakeSell Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MakeSell();
                return _instance;
            }
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        public MakeSell()
        {
            InitializeComponent();
            ListaFuncionario();
            ListaProduto();
            ListaCliente();
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
        public void ListaCliente()
        {
            login.Open();
            OracleCommand lcom = new OracleCommand();
            lcom.Connection = login;
            lcom.CommandText = "select cli_nome from tb_cliente";
            lcom.CommandType = CommandType.Text;
            OracleDataReader ret = lcom.ExecuteReader();
            while (ret.Read())
            {
                cbxCliente.Items.Add(ret["cli_nome"].ToString());
            }
            ret.Close();
            login.Close();
        }
        public void Cliente()
        {
            login.Open();
            OracleCommand ret = new OracleCommand();
            ret.Connection = login;
            ret.CommandText = "select cli_codigo from tb_cliente where cli_nome = '" + cbxCliente.Text + "'";
            ret.CommandType = CommandType.Text;
            OracleDataReader cli = ret.ExecuteReader();
            if (cli.Read())
            {
                codCli = cli.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Cliente não encontrado");
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
            cbxCliente.Text = "";
            cbxFuncionario.Text = "";
            txbQuantidade.Text = "";
            txbValorUnit.Text = "";
            cbxProduto.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Venda();
            ItemVenda();
            ContaReceber();
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "update tb_contaReceber set cor_valorPrincipal = func_valorTotalVenda((select max(ven_codigo) from tb_venda)) where cor_codigo = (select max(cor_codigo) from tb_contaReceber)";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }

        public void Venda()
        {
            Cliente();
            Funcionario();
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "insert into tb_venda values(seq_venda.nextval, " + codCli + ", " + codFun + ", sysdate)";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
        public void ItemVenda()
        {
            Produto();
            login.Open();
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "insert into tb_itemVenda values (seq_venda.currval, " + codPro + ", " + txbQuantidade.Text + ", " + txbValorUnit.Text + ")";
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
        public void ContaReceber()
        {
            int qt = Convert.ToInt32(txbQuantidade.Text);
            float vl = (float)Convert.ToDouble(txbValorUnit.Text);
            float total = qt * vl;
            login.Open();
            string query = "(cor_codigo, cor_dataEmicao, cor_dataVencimento, cor_valorPrincipal, cor_valorJuro, cor_venCodigo, cor_numParcela, cor_situacao)";
            string query1 = "(seq_contaReceber.nextval, sysdate, sysdate+30, 0, 0, seq_venda.currval, 1, 'ABERTO')";
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = "insert into tb_contaReceber" + query + "values" + query1;
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
