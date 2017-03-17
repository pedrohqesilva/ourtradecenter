namespace ControlaEstoque
{
    partial class frmEstoqueProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueProduto));
            this.lblEstoqueProdutos = new System.Windows.Forms.Label();
            this.pnlEstoqueProdutos = new System.Windows.Forms.Panel();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterarEstoqueProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.pnlEstoqueProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstoqueProdutos
            // 
            this.lblEstoqueProdutos.AutoSize = true;
            this.lblEstoqueProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoqueProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEstoqueProdutos.Location = new System.Drawing.Point(24, 13);
            this.lblEstoqueProdutos.Name = "lblEstoqueProdutos";
            this.lblEstoqueProdutos.Size = new System.Drawing.Size(179, 16);
            this.lblEstoqueProdutos.TabIndex = 3;
            this.lblEstoqueProdutos.Text = "Alterar Estoque de Produtos:";
            // 
            // pnlEstoqueProdutos
            // 
            this.pnlEstoqueProdutos.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstoqueProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstoqueProdutos.Controls.Add(this.txtProduto);
            this.pnlEstoqueProdutos.Controls.Add(this.cbxMedida);
            this.pnlEstoqueProdutos.Controls.Add(this.lblProduto);
            this.pnlEstoqueProdutos.Controls.Add(this.btnLimpar);
            this.pnlEstoqueProdutos.Controls.Add(this.btnAlterarEstoqueProduto);
            this.pnlEstoqueProdutos.Controls.Add(this.txtQuantidade);
            this.pnlEstoqueProdutos.Controls.Add(this.lblQuantidade);
            this.pnlEstoqueProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlEstoqueProdutos.Location = new System.Drawing.Point(12, 21);
            this.pnlEstoqueProdutos.Name = "pnlEstoqueProdutos";
            this.pnlEstoqueProdutos.Size = new System.Drawing.Size(362, 120);
            this.pnlEstoqueProdutos.TabIndex = 2;
            // 
            // txtProduto
            // 
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(88, 14);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(246, 20);
            this.txtProduto.TabIndex = 3;
            // 
            // cbxMedida
            // 
            this.cbxMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Items.AddRange(new object[] {
            "Quilogramas",
            "Gramas",
            "miliGramas",
            "Litros",
            "miliLitros",
            "Unidade",
            "Colher de Sopa",
            "Colher de Sobremesa",
            "Colher de Chá",
            "Colher de Cafe",
            "Xícara de Chá",
            "Xícara de Café",
            "Copo"});
            this.cbxMedida.Location = new System.Drawing.Point(167, 40);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(167, 21);
            this.cbxMedida.TabIndex = 6;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(17, 18);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 2;
            this.lblProduto.Text = "Produto:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(14, 81);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarEstoqueProduto
            // 
            this.btnAlterarEstoqueProduto.Font = new System.Drawing.Font("Papyrus", 10.75F);
            this.btnAlterarEstoqueProduto.Location = new System.Drawing.Point(159, 73);
            this.btnAlterarEstoqueProduto.Name = "btnAlterarEstoqueProduto";
            this.btnAlterarEstoqueProduto.Size = new System.Drawing.Size(75, 31);
            this.btnAlterarEstoqueProduto.TabIndex = 9;
            this.btnAlterarEstoqueProduto.Text = "Alterar";
            this.btnAlterarEstoqueProduto.UseVisualStyleBackColor = true;
            this.btnAlterarEstoqueProduto.Click += new System.EventHandler(this.btnAlterarEstoqueProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(88, 41);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(73, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(17, 45);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // frmEstoqueProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 153);
            this.Controls.Add(this.lblEstoqueProdutos);
            this.Controls.Add(this.pnlEstoqueProdutos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoqueProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlEstoqueProdutos.ResumeLayout(false);
            this.pnlEstoqueProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstoqueProdutos;
        private System.Windows.Forms.Panel pnlEstoqueProdutos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterarEstoqueProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.TextBox txtProduto;

    }
}