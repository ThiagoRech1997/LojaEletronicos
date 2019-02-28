using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace Loja_Eletronicos
{
    public partial class CliInsert : UserControl
    {
        public int cod_end;
        public int cod_bai;
        public int cod_cid;

        private static CliInsert _instance;
        public static CliInsert Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CliInsert();
                return _instance;
            }
        }
        public CliInsert()
        {
            InitializeComponent();
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            endereco();
            bairro();
            cidade();
            login.Open();
            string query = "insert into tb_cliente values (seq_cliente.nextval, '" + txbNome.Text + "', '" + txbRG.Text + "', '" + txbCPF.Text + "', '" + txbTelefone.Text + "', '" + txbCelular.Text + "', " + cod_end + ", " + txbNum.Text + ", " + cod_bai + ", " + cod_cid + ")";
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbRG.Text = "";
            txbCPF.Text = "";
            txbTelefone.Text = "";
            txbCelular.Text = "";
            txbEndereco.Text = "";
            txbNum.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            txbUF.Text = "";
        }
    }
}
