﻿using System;
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
    public partial class ProDelete : UserControl
    {
        private static ProDelete _instance;
        public static ProDelete Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProDelete();
                return _instance;
            }
        }
        public ProDelete()
        {
            InitializeComponent();
            ListaCarrega();
        }
        OracleConnection login = new OracleConnection("data source = " + Usuraio.BancoNome + "; user id = " + Usuraio.UserID + "; password =" + Usuraio.Password + ";");
        public void ListaCarrega()
        {
            login.Open();
            OracleCommand con = new OracleCommand();
            con.Connection = login;
            con.CommandText = "Select * from tb_produto";
            con.CommandType = CommandType.Text;
            OracleDataReader ret = con.ExecuteReader();
            while (ret.Read())
            {
                ListViewItem item = new ListViewItem(ret["pro_codigo"].ToString());
                item.SubItems.Add(ret["pro_descricao"].ToString());
                item.SubItems.Add(ret["pro_marca"].ToString());
                item.SubItems.Add(ret["pro_quantidade"].ToString());
                item.SubItems.Add(ret["pro_valorUnit"].ToString());
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
            login.Open();
            OracleCommand del = new OracleCommand();
            del.Connection = login;
            del.CommandText = "delete from tb_produto where pro_codigo = " + txbCod.Text;
            del.CommandType = CommandType.Text;
            del.ExecuteNonQuery();
            login.Close();
            lvCliUpdate.Items.Clear();
            ListaCarrega();
            MessageBox.Show("Produto excluído com sucesso!");
        }
    }
}
