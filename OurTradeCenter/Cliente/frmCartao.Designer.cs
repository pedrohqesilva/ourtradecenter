namespace ControlaEstoque
{
    partial class frmCartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCartao));
            this.pnlCartao = new System.Windows.Forms.Panel();
            this.mskCodCartao = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskCodSeguranca = new System.Windows.Forms.MaskedTextBox();
            this.txtSalvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.mskValidade = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxBandeira = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCartao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCartao
            // 
            this.pnlCartao.BackColor = System.Drawing.Color.Transparent;
            this.pnlCartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCartao.Controls.Add(this.mskCodCartao);
            this.pnlCartao.Controls.Add(this.btnLimpar);
            this.pnlCartao.Controls.Add(this.mskCodSeguranca);
            this.pnlCartao.Controls.Add(this.txtSalvar);
            this.pnlCartao.Controls.Add(this.label11);
            this.pnlCartao.Controls.Add(this.mskValidade);
            this.pnlCartao.Controls.Add(this.label10);
            this.pnlCartao.Controls.Add(this.txtNome);
            this.pnlCartao.Controls.Add(this.label9);
            this.pnlCartao.Controls.Add(this.cbxBandeira);
            this.pnlCartao.Controls.Add(this.label8);
            this.pnlCartao.Controls.Add(this.label12);
            this.pnlCartao.Location = new System.Drawing.Point(12, 18);
            this.pnlCartao.Name = "pnlCartao";
            this.pnlCartao.Size = new System.Drawing.Size(371, 220);
            this.pnlCartao.TabIndex = 10;
            // 
            // mskCodCartao
            // 
            this.mskCodCartao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCodCartao.Location = new System.Drawing.Point(18, 77);
            this.mskCodCartao.Mask = "0000 0000 0000 0000";
            this.mskCodCartao.Name = "mskCodCartao";
            this.mskCodCartao.Size = new System.Drawing.Size(219, 20);
            this.mskCodCartao.TabIndex = 4;
            this.mskCodCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCodCartao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 185);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(62, 23);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mskCodSeguranca
            // 
            this.mskCodSeguranca.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCodSeguranca.Location = new System.Drawing.Point(254, 125);
            this.mskCodSeguranca.Mask = "000";
            this.mskCodSeguranca.Name = "mskCodSeguranca";
            this.mskCodSeguranca.Size = new System.Drawing.Size(98, 20);
            this.mskCodSeguranca.TabIndex = 7;
            this.mskCodSeguranca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCodSeguranca.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtSalvar
            // 
            this.txtSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalvar.Location = new System.Drawing.Point(97, 175);
            this.txtSalvar.Name = "txtSalvar";
            this.txtSalvar.Size = new System.Drawing.Size(200, 33);
            this.txtSalvar.TabIndex = 20;
            this.txtSalvar.Text = "Salvar e voltar";
            this.txtSalvar.UseVisualStyleBackColor = true;
            this.txtSalvar.Click += new System.EventHandler(this.txtSalvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cód de Segurança:";
            // 
            // mskValidade
            // 
            this.mskValidade.Location = new System.Drawing.Point(255, 77);
            this.mskValidade.Mask = "00/0000";
            this.mskValidade.Name = "mskValidade";
            this.mskValidade.Size = new System.Drawing.Size(97, 20);
            this.mskValidade.TabIndex = 6;
            this.mskValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Validade do Cartão:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nome igual no Cartão:";
            // 
            // cbxBandeira
            // 
            this.cbxBandeira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBandeira.FormattingEnabled = true;
            this.cbxBandeira.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "Elo",
            "Ticket"});
            this.cbxBandeira.Location = new System.Drawing.Point(18, 125);
            this.cbxBandeira.Name = "cbxBandeira";
            this.cbxBandeira.Size = new System.Drawing.Size(219, 21);
            this.cbxBandeira.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bandeira do Cartão:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Código do Cartão:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dados do Cartão:";
            // 
            // frmCartao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCartao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCartao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlCartao.ResumeLayout(false);
            this.pnlCartao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCartao;
        private System.Windows.Forms.MaskedTextBox mskCodCartao;
        private System.Windows.Forms.MaskedTextBox mskCodSeguranca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskValidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxBandeira;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button txtSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
    }
}