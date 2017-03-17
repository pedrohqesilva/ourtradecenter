namespace ControlaEstoque
{
    partial class frmEstoqueIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoqueIngrediente));
            this.lblEstoqueIngrediente = new System.Windows.Forms.Label();
            this.pnlEstoqueIngrediente = new System.Windows.Forms.Panel();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterarEstoqueIngrediente = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.pnlEstoqueIngrediente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstoqueIngrediente
            // 
            this.lblEstoqueIngrediente.AutoSize = true;
            this.lblEstoqueIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoqueIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEstoqueIngrediente.Location = new System.Drawing.Point(24, 12);
            this.lblEstoqueIngrediente.Name = "lblEstoqueIngrediente";
            this.lblEstoqueIngrediente.Size = new System.Drawing.Size(199, 16);
            this.lblEstoqueIngrediente.TabIndex = 1;
            this.lblEstoqueIngrediente.Text = "Alterar Estoque de Ingredientes:";
            // 
            // pnlEstoqueIngrediente
            // 
            this.pnlEstoqueIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.pnlEstoqueIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstoqueIngrediente.Controls.Add(this.txtIngrediente);
            this.pnlEstoqueIngrediente.Controls.Add(this.cbxMedida);
            this.pnlEstoqueIngrediente.Controls.Add(this.lblIngrediente);
            this.pnlEstoqueIngrediente.Controls.Add(this.btnLimpar);
            this.pnlEstoqueIngrediente.Controls.Add(this.btnAlterarEstoqueIngrediente);
            this.pnlEstoqueIngrediente.Controls.Add(this.txtQuantidade);
            this.pnlEstoqueIngrediente.Controls.Add(this.lblQuantidade);
            this.pnlEstoqueIngrediente.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlEstoqueIngrediente.Location = new System.Drawing.Point(12, 20);
            this.pnlEstoqueIngrediente.Name = "pnlEstoqueIngrediente";
            this.pnlEstoqueIngrediente.Size = new System.Drawing.Size(362, 122);
            this.pnlEstoqueIngrediente.TabIndex = 0;
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Enabled = false;
            this.txtIngrediente.Location = new System.Drawing.Point(88, 14);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(246, 20);
            this.txtIngrediente.TabIndex = 3;
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
            this.cbxMedida.Location = new System.Drawing.Point(166, 40);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(168, 21);
            this.cbxMedida.TabIndex = 6;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Location = new System.Drawing.Point(17, 18);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(63, 13);
            this.lblIngrediente.TabIndex = 2;
            this.lblIngrediente.Text = "Ingrediente:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(14, 85);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarEstoqueIngrediente
            // 
            this.btnAlterarEstoqueIngrediente.Font = new System.Drawing.Font("Papyrus", 10.75F);
            this.btnAlterarEstoqueIngrediente.Location = new System.Drawing.Point(159, 77);
            this.btnAlterarEstoqueIngrediente.Name = "btnAlterarEstoqueIngrediente";
            this.btnAlterarEstoqueIngrediente.Size = new System.Drawing.Size(75, 31);
            this.btnAlterarEstoqueIngrediente.TabIndex = 9;
            this.btnAlterarEstoqueIngrediente.Text = "Alterar";
            this.btnAlterarEstoqueIngrediente.UseVisualStyleBackColor = true;
            this.btnAlterarEstoqueIngrediente.Click += new System.EventHandler(this.btnAlterarEstoqueIngrediente_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(88, 41);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(72, 20);
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
            // frmEstoqueIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 153);
            this.Controls.Add(this.lblEstoqueIngrediente);
            this.Controls.Add(this.pnlEstoqueIngrediente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoqueIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlEstoqueIngrediente.ResumeLayout(false);
            this.pnlEstoqueIngrediente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstoqueIngrediente;
        private System.Windows.Forms.Panel pnlEstoqueIngrediente;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterarEstoqueIngrediente;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.TextBox txtIngrediente;
    }
}