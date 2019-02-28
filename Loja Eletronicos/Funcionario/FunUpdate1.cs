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
    public partial class FunUpdate1 : Form
    {
        public int cod_end;
        public int cod_bai;
        public int cod_cid;
        public int cod_car;
        string codFun;
        public FunUpdate1(string cod)
        {
            InitializeComponent();
            codFun = cod;
            RecebeDados();
            ListaCargo();
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
        public void cargo()
        {
            login.Close();
            login.Open();
            OracleCommand comCar = new OracleCommand();
            comCar.Connection = login;
            comCar.CommandText = "select car_codigo from tb_cargo where car_descricao = '" + cbxCargo.Text + "'";
            comCar.CommandType = CommandType.Text;
            OracleDataReader car = comCar.ExecuteReader();
            if (car.Read())
            {
                cod_car = car.GetInt32(0);
            }
            car.Close();
            login.Close();
        }
        public void ListaCargo()
        {
            login.Open();
            OracleCommand lcom = new OracleCommand();
            lcom.Connection = login;
            lcom.CommandText = "select car_descricao from tb_cargo";
            lcom.CommandType = CommandType.Text;
            OracleDataReader ret = lcom.ExecuteReader();
            while (ret.Read())
            {
                cbxCargo.Items.Add(ret["car_descricao"].ToString());
            }
            ret.Close();
            login.Close();
        }
        private void RecebeDados()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from vi_funcionario where vfun_codigo = " + codFun;
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            if (ret.Read())
            {
                txbNome.Text = ret["vfun_nome"].ToString();
                txbRG.Text = ret["vfun_RG"].ToString();
                txbCPF.Text = ret["vfun_CPF"].ToString();
                txbTelefone.Text = ret["vfun_telefone"].ToString();
                txbCelular.Text = ret["vfun_celular"].ToString();
                txbEndereco.Text = ret["vfun_endereco"].ToString();
                txbNum.Text = ret["vfun_num"].ToString();
                txbBairro.Text = ret["vfun_bairro"].ToString();
                txbCidade.Text = ret["vfun_cidade"].ToString();
                cbxCargo.Text = ret["vfun_cargo"].ToString();
                txbSalario.Text = ret["vfun_salario"].ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            endereco();
            bairro();
            cidade();
            cargo();
            login.Open();
            string query = "update tb_funcionario set fun_nome = '" + txbNome.Text + "', fun_rg = '" + txbRG.Text + "', fun_cpf = '" + txbCPF.Text + "', fun_telefone = '" + txbTelefone.Text + "', fun_celular = '" + txbCelular.Text + "', fun_endCodigo = " + cod_end + ", fun_num = " + txbNum.Text + ", fun_baiCodigo = " + cod_bai + ", fun_cidCodigo = " + cod_cid + ", fun_carCodigo = " + cod_car + ", fun_salario = " + txbSalario.Text + " where fun_codigo = " + codFun;
            OracleCommand com = new OracleCommand();
            com.Connection = login;
            com.CommandText = query;
            com.CommandType = CommandType.Text;
            com.ExecuteNonQuery();
            login.Close();
        }
    }
}
