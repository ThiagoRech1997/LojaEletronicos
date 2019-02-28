namespace Loja_Eletronicos
{
    partial class PaySell
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbCod = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lvCliUpdate = new System.Windows.Forms.ListView();
            this.chCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEndereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVendedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Vendas em Aberto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código Venda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(600, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Efetuar Pagamento";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(615, 8);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(100, 20);
            this.txbCod.TabIndex = 20;
            this.txbCod.TextChanged += new System.EventHandler(this.txbCod_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(3, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Recarregar Lista";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvCliUpdate
            // 
            this.lvCliUpdate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chNome,
            this.chCPF,
            this.chEndereco,
            this.chNum,
            this.chBairro,
            this.chCidade,
            this.chVendedor,
            this.chEmissao,
            this.chVencimento,
            this.chProduto,
            this.chTotal});
            this.lvCliUpdate.Location = new System.Drawing.Point(3, 63);
            this.lvCliUpdate.Name = "lvCliUpdate";
            this.lvCliUpdate.Size = new System.Drawing.Size(712, 455);
            this.lvCliUpdate.TabIndex = 18;
            this.lvCliUpdate.UseCompatibleStateImageBehavior = false;
            this.lvCliUpdate.View = System.Windows.Forms.View.Details;
            this.lvCliUpdate.SelectedIndexChanged += new System.EventHandler(this.lvCliUpdate_SelectedIndexChanged);
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "Codigo";
            this.chCodigo.Width = 45;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 124;
            // 
            // chCPF
            // 
            this.chCPF.Text = "CPF";
            this.chCPF.Width = 72;
            // 
            // chEndereco
            // 
            this.chEndereco.Text = "Endereço";
            this.chEndereco.Width = 72;
            // 
            // chNum
            // 
            this.chNum.Text = "Num";
            this.chNum.Width = 38;
            // 
            // chBairro
            // 
            this.chBairro.Text = "Bairro";
            this.chBairro.Width = 69;
            // 
            // chCidade
            // 
            this.chCidade.Text = "Cidade";
            this.chCidade.Width = 85;
            // 
            // chVendedor
            // 
            this.chVendedor.Text = "Vendedor";
            // 
            // chEmissao
            // 
            this.chEmissao.Text = "Emissao";
            // 
            // chVencimento
            // 
            this.chVencimento.Text = "Vencimento";
            this.chVencimento.Width = 68;
            // 
            // chProduto
            // 
            this.chProduto.Text = "Produto";
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            // 
            // PaySell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvCliUpdate);
            this.Name = "PaySell";
            this.Size = new System.Drawing.Size(718, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbCod;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvCliUpdate;
        private System.Windows.Forms.ColumnHeader chCodigo;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chCPF;
        private System.Windows.Forms.ColumnHeader chEndereco;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chBairro;
        private System.Windows.Forms.ColumnHeader chCidade;
        private System.Windows.Forms.ColumnHeader chVendedor;
        private System.Windows.Forms.ColumnHeader chEmissao;
        private System.Windows.Forms.ColumnHeader chVencimento;
        private System.Windows.Forms.ColumnHeader chProduto;
        private System.Windows.Forms.ColumnHeader chTotal;
    }
}
