namespace Loja_Eletronicos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Login Janela;

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

        public Form1(Login nJanela)
        {
            Janela = nJanela;
            InitializeComponent();
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboxCaixa = new System.Windows.Forms.PictureBox();
            this.pboxProduto = new System.Windows.Forms.PictureBox();
            this.pboxFuncionario = new System.Windows.Forms.PictureBox();
            this.pboxCliente = new System.Windows.Forms.PictureBox();
            this.pboxCompra = new System.Windows.Forms.PictureBox();
            this.pboxHome = new System.Windows.Forms.PictureBox();
            this.pboxVenda = new System.Windows.Forms.PictureBox();
            this.panelHandle2 = new System.Windows.Forms.Panel();
            this.lblHader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pWindowView = new System.Windows.Forms.Panel();
            this.dragControl1 = new Loja_Eletronicos.DragControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVenda)).BeginInit();
            this.panelHandle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.pWindowView);
            this.panel1.Controls.Add(this.pboxCaixa);
            this.panel1.Controls.Add(this.pboxProduto);
            this.panel1.Controls.Add(this.pboxFuncionario);
            this.panel1.Controls.Add(this.pboxCliente);
            this.panel1.Controls.Add(this.pboxCompra);
            this.panel1.Controls.Add(this.pboxHome);
            this.panel1.Controls.Add(this.pboxVenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 600);
            this.panel1.TabIndex = 0;
            // 
            // pboxCaixa
            // 
            this.pboxCaixa.Image = global::Loja_Eletronicos.Properties.Resources.cash_register;
            this.pboxCaixa.Location = new System.Drawing.Point(5, 395);
            this.pboxCaixa.Name = "pboxCaixa";
            this.pboxCaixa.Size = new System.Drawing.Size(50, 50);
            this.pboxCaixa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCaixa.TabIndex = 6;
            this.pboxCaixa.TabStop = false;
            this.pboxCaixa.Click += new System.EventHandler(this.pboxCaixa_Click);
            this.pboxCaixa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCaixa_MouseMove);
            // 
            // pboxProduto
            // 
            this.pboxProduto.Image = global::Loja_Eletronicos.Properties.Resources.box;
            this.pboxProduto.Location = new System.Drawing.Point(5, 335);
            this.pboxProduto.Name = "pboxProduto";
            this.pboxProduto.Size = new System.Drawing.Size(50, 50);
            this.pboxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxProduto.TabIndex = 5;
            this.pboxProduto.TabStop = false;
            this.pboxProduto.Click += new System.EventHandler(this.pboxProduto_Click);
            this.pboxProduto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxProduto_MouseMove);
            // 
            // pboxFuncionario
            // 
            this.pboxFuncionario.Image = global::Loja_Eletronicos.Properties.Resources.customer_service;
            this.pboxFuncionario.Location = new System.Drawing.Point(5, 275);
            this.pboxFuncionario.Name = "pboxFuncionario";
            this.pboxFuncionario.Size = new System.Drawing.Size(50, 50);
            this.pboxFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFuncionario.TabIndex = 4;
            this.pboxFuncionario.TabStop = false;
            this.pboxFuncionario.Click += new System.EventHandler(this.pboxFuncionario_Click);
            this.pboxFuncionario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxFuncionario_MouseMove);
            // 
            // pboxCliente
            // 
            this.pboxCliente.Image = global::Loja_Eletronicos.Properties.Resources.network;
            this.pboxCliente.Location = new System.Drawing.Point(5, 95);
            this.pboxCliente.Name = "pboxCliente";
            this.pboxCliente.Size = new System.Drawing.Size(50, 50);
            this.pboxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCliente.TabIndex = 3;
            this.pboxCliente.TabStop = false;
            this.pboxCliente.Click += new System.EventHandler(this.pboxCliente_Click);
            this.pboxCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCliente_MouseMove);
            // 
            // pboxCompra
            // 
            this.pboxCompra.Image = global::Loja_Eletronicos.Properties.Resources.cart;
            this.pboxCompra.Location = new System.Drawing.Point(5, 215);
            this.pboxCompra.Name = "pboxCompra";
            this.pboxCompra.Size = new System.Drawing.Size(50, 50);
            this.pboxCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCompra.TabIndex = 2;
            this.pboxCompra.TabStop = false;
            this.pboxCompra.Click += new System.EventHandler(this.pboxCompra_Click);
            this.pboxCompra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxCompra_MouseMove);
            // 
            // pboxHome
            // 
            this.pboxHome.Image = global::Loja_Eletronicos.Properties.Resources.house;
            this.pboxHome.Location = new System.Drawing.Point(5, 35);
            this.pboxHome.Name = "pboxHome";
            this.pboxHome.Size = new System.Drawing.Size(50, 50);
            this.pboxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxHome.TabIndex = 1;
            this.pboxHome.TabStop = false;
            this.pboxHome.Click += new System.EventHandler(this.pboxHome_Click);
            this.pboxHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pboxHome_MouseMove);
            // 
            // pboxVenda
            // 
            this.pboxVenda.Image = global::Loja_Eletronicos.Properties.Resources.get_money;
            this.pboxVenda.Location = new System.Drawing.Point(5, 155);
            this.pboxVenda.Name = "pboxVenda";
            this.pboxVenda.Size = new System.Drawing.Size(50, 50);
            this.pboxVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxVenda.TabIndex = 0;
            this.pboxVenda.TabStop = false;
            this.pboxVenda.Click += new System.EventHandler(this.pboxVenda_Click);
            this.pboxVenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // panelHandle2
            // 
            this.panelHandle2.BackColor = System.Drawing.Color.DarkGray;
            this.panelHandle2.Controls.Add(this.lblHader);
            this.panelHandle2.Controls.Add(this.pictureBox1);
            this.panelHandle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHandle2.Location = new System.Drawing.Point(60, 0);
            this.panelHandle2.Name = "panelHandle2";
            this.panelHandle2.Size = new System.Drawing.Size(724, 35);
            this.panelHandle2.TabIndex = 1;
            // 
            // lblHader
            // 
            this.lblHader.AutoSize = true;
            this.lblHader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHader.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHader.Location = new System.Drawing.Point(9, 4);
            this.lblHader.Name = "lblHader";
            this.lblHader.Size = new System.Drawing.Size(60, 27);
            this.lblHader.TabIndex = 2;
            this.lblHader.Text = "Início";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loja_Eletronicos.Properties.Resources.close_white;
            this.pictureBox1.Location = new System.Drawing.Point(689, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pWindowView
            // 
            this.pWindowView.Location = new System.Drawing.Point(60, 35);
            this.pWindowView.Name = "pWindowView";
            this.pWindowView.Size = new System.Drawing.Size(724, 565);
            this.pWindowView.TabIndex = 2;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panelHandle2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(60, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 565);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.pboxHome_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pboxHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHandle2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVenda)).EndInit();
            this.panelHandle2.ResumeLayout(false);
            this.panelHandle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHandle2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pboxVenda;
        private System.Windows.Forms.Label lblHader;
        private System.Windows.Forms.PictureBox pboxCaixa;
        private System.Windows.Forms.PictureBox pboxProduto;
        private System.Windows.Forms.PictureBox pboxFuncionario;
        private System.Windows.Forms.PictureBox pboxCliente;
        private System.Windows.Forms.PictureBox pboxCompra;
        private System.Windows.Forms.PictureBox pboxHome;
        private DragControl dragControl1;
        private System.Windows.Forms.Panel pWindowView;
        private System.Windows.Forms.Panel panel2;
    }
}

