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
    public partial class CliUpdate1 : Form
    {
        public string codRev;
        public int cod_end;
        public int cod_bai;
        public int cod_cid;
        public CliUpdate1(string cod)
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
            con.CommandText = "Select * from vi_cliente where vcli_codigo = " + codRev;
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            if (ret.Read())
            {
                txbNome.Text = ret["vcli_nome"].ToString();
                txbRG.Text = ret["vcli_RG"].ToString();
                txbCPF.Text = ret["vcli_cpf"].ToString();
                txbTelefone.Text = ret["vcli_telefone"].ToString();
                txbCelular.Text = ret["vcli_celular"].ToString();
                txbEndereco.Text = ret["vcli_endereco"].ToString();
                txbNum.Text = ret["vcli_num"].ToString();
                txbBairro.Text = ret["vcli_bairro"].ToString();
                txbCidade.Text = ret["vcli_cidade"].ToString();
            }
            else
            {
                MessageBox.Show("Não foi possivel recuperar dados");
            }
            ret.Close();
            login.Close();
            /**-------------------------------------------------------**/
            login.Open();
            OracleCommand cuf = new OracleCommand();
            cuf.Connection = login;
            cuf.CommandText = "select cid_uf from tb_cidade where cid_descricao = '" + txbCidade.Text + "'";
            cuf.CommandType = CommandType.Text;
            OracleDataReader retu = cuf.ExecuteReader();
            if (retu.Read())
            {
                txbUF.Text = retu["cid_uf"].ToString();
            }
            retu.Close();
            login.Close();
        }
        public void endereco()
        {
            login.Close();
            string query = "select end_codigo from tb_endereco where end_descricao = '" + txbEndereco.Text + "'";
            login.Open();
            OracleCommand comEnd = new OracleCommand();
            comEnd.Connection = login;
            comEnd.CommandText = query;
            comEnd.CommandType = CommandType.Text;
            OracleDataReader end = comEnd.ExecuteReader();
            if (end.Read())
            {
                cod_end = end.GetInt32(0);
            }
            else
            {
                login.Close();
                login.Open();
                query = "insert into tb_endereco values (seq_endereco.nextval, '" + txbEndereco.Text + "')";
                OracleCommand insert = new OracleCommand();
                insert.Connection = login;
                insert.CommandText = query;
                insert.CommandType = CommandType.Text;
                insert.ExecuteNonQuery();
                endereco();
            }
            end.Close();
            login.Close();
        }
        public void bairro()
        {
            login.Close();
            string query = "select bai_codigo from tb_bairro where bai_descricao = '" + txbBairro.Text + "'";
            login.Open();
            OracleCommand comBai = new OracleCommand();
            comBai.Connection = login;
            comBai.CommandText = query;
            comBai.CommandType = CommandType.Text;
            OracleDataReader bai = comBai.ExecuteReader();
            if (bai.Read())
            {
                cod_bai = bai.GetInt32(0);
            }
            else
            {
                login.Close();
                login.Open();
                query = "insert into tb_bairro values (seq_bairro.nextval, '" + txbBairro.Text + "')";
                OracleCommand insert = new OracleCommand();
                insert.Connection = login;
                insert.CommandText = query;
                insert.CommandType = CommandType.Text;
                insert.ExecuteNonQuery();
                bairro();
            }
            bai.Close();
            login.Close();
        }
        public void cidade()
        {
            login.Close();
            string query = "select cid_codigo from tb_cidade where cid_descricao = '" + txbCidade.Text + "' and cid_UF = '" + txbUF.Text + "'";
            login.Open();
            OracleCommand comCid = new OracleCommand();
            comCid.Connection = login;
            comCid.CommandText = query;
            comCid.CommandType = CommandType.Text;
            OracleDataReader cid = comCid.ExecuteReader();
            if (cid.Read())
            {
                cod_cid = cid.GetInt32(0);
            }
            else
            {
                login.Close();
                login.Open();
                query = "insert into tb_cidade values (seq_cidade.nextval, '" + txbCidade.Text + "', '" + txbUF.Text + "')";
                OracleCommand insert = new OracleCommand(query, login);
                insert.Connection = login;
                insert.CommandText = query;
                insert.CommandType = CommandType.Text;
                insert.ExecuteNonQuery();
                cidade();
            }
            cid.Close();
            login.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            endereco();
            bairro();
            cidade();
            login.Open();
            string query = "update tb_cliente set cli_nome = '" + txbNome.Text + "', cli_RG = '" + txbRG.Text + 
                "', cli_CPF = '" + txbCPF.Text + "', cli_telefone = '" + txbTelefone.Text + "', cli_celular = '" + txbCelular.Text + 
                "', cli_endCodigo = " + cod_end + ", cli_num = " + txbNum.Text + ", cli_baiCodigo = " + cod_bai + ", cli_cidCodigo = " + cod_cid + " where cli_codigo = " + codRev;
            OracleCommand update = new OracleCommand();
            update.Connection = login;
            update.CommandText = query;
            update.CommandType = CommandType.Text;
            update.ExecuteNonQuery();
            login.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
