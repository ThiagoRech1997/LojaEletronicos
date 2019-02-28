namespace Loja_Eletronicos
{
    partial class ProDelete
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
            this.chDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Produtos Cadastrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código Produto:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(604, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Excluir Produto";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbCod
            // 
            this.txbCod.Location = new System.Drawing.Point(615, 8);
            this.txbCod.Name = "txbCod";
            this.txbCod.Size = new System.Drawing.Size(100, 20);
            this.txbCod.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(3, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Recarregar Lista";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvCliUpdate
            // 
            this.lvCliUpdate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodigo,
            this.chDescricao,
            this.chMarca,
            this.chQuantidade,
            this.chValor});
            this.lvCliUpdate.Location = new System.Drawing.Point(3, 63);
            this.lvCliUpdate.Name = "lvCliUpdate";
            this.lvCliUpdate.Size = new System.Drawing.Size(712, 455);
            this.lvCliUpdate.TabIndex = 12;
            this.lvCliUpdate.UseCompatibleStateImageBehavior = false;
            this.lvCliUpdate.View = System.Windows.Forms.View.Details;
            // 
            // chCodigo
            // 
            this.chCodigo.Text = "Código";
            // 
            // chDescricao
            // 
            this.chDescricao.Text = "Descrição";
            this.chDescricao.Width = 354;
            // 
            // chMarca
            // 
            this.chMarca.Text = "Marca";
            this.chMarca.Width = 142;
            // 
            // chQuantidade
            // 
            this.chQuantidade.Text = "Quantidade";
            this.chQuantidade.Width = 69;
            // 
            // chValor
            // 
            this.chValor.Text = "Valor Unitário";
            this.chValor.Width = 82;
            // 
            // ProDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txbCod);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvCliUpdate);
            this.Name = "ProDelete";
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
        private System.Windows.Forms.ColumnHeader chDescricao;
        private System.Windows.Forms.ColumnHeader chMarca;
        private System.Windows.Forms.ColumnHeader chQuantidade;
        private System.Windows.Forms.ColumnHeader chValor;
    }
}
