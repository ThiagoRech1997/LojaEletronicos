namespace Loja_Eletronicos
{
    partial class Venda
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
            this.pCliWindow = new System.Windows.Forms.Panel();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pCliWindow
            // 
            this.pCliWindow.Location = new System.Drawing.Point(3, 35);
            this.pCliWindow.Name = "pCliWindow";
            this.pCliWindow.Size = new System.Drawing.Size(718, 526);
            this.pCliWindow.TabIndex = 4;
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.ForeColor = System.Drawing.Color.Blue;
            this.btnVenda.Location = new System.Drawing.Point(204, 6);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(75, 23);
            this.btnVenda.TabIndex = 6;
            this.btnVenda.Text = "Venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.Blue;
            this.btnPay.Location = new System.Drawing.Point(445, 6);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.pCliWindow);
            this.Name = "Venda";
            this.Size = new System.Drawing.Size(724, 565);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pCliWindow;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnPay;
    }
}
