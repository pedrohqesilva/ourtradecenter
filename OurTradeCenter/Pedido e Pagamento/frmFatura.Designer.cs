namespace ControlaEstoque
{
    partial class frmFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFatura));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.pnlDinheiro = new System.Windows.Forms.Panel();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mskCodCartao = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskCodSeguranca = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarFatura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxMetodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBranco = new System.Windows.Forms.Panel();
            this.pnlCartao = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.mskValidade = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxBandeira = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxParcelas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDinheiro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCartao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Finalizar Pedido:";
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(127, 141);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(178, 34);
            this.txtTroco.TabIndex = 7;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTroco
            // 
            this.lblTroco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.Location = new System.Drawing.Point(128, 118);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(178, 20);
            this.lblTroco.TabIndex = 100;
            this.lblTroco.Text = "Falta:";
            this.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorPago
            // 
            this.txtValorPago.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPago.Location = new System.Drawing.Point(127, 35);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(178, 41);
            this.txtValorPago.TabIndex = 5;
            this.txtValorPago.Text = "R$ ";
            this.txtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlDinheiro
            // 
            this.pnlDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDinheiro.Controls.Add(this.btnCalc);
            this.pnlDinheiro.Controls.Add(this.txtTroco);
            this.pnlDinheiro.Controls.Add(this.lblTroco);
            this.pnlDinheiro.Controls.Add(this.txtValorPago);
            this.pnlDinheiro.Controls.Add(this.label5);
            this.pnlDinheiro.Location = new System.Drawing.Point(18, 68);
            this.pnlDinheiro.Name = "pnlDinheiro";
            this.pnlDinheiro.Size = new System.Drawing.Size(431, 208);
            this.pnlDinheiro.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnCalc.Location = new System.Drawing.Point(127, 78);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(179, 24);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "VALOR PAGO:";
            // 
            // mskCPF
            // 
            this.mskCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.Location = new System.Drawing.Point(21, 34);
            this.mskCPF.Mask = "000.000.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(167, 20);
            this.mskCPF.TabIndex = 1;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCPF.TextChanged += new System.EventHandler(this.mskCPF_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "CPF do Titular do Cartão:";
            // 
            // mskCodCartao
            // 
            this.mskCodCartao.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskCodCartao.Location = new System.Drawing.Point(200, 91);
            this.mskCodCartao.Mask = "0000 0000 0000 0000";
            this.mskCodCartao.Name = "mskCodCartao";
            this.mskCodCartao.ReadOnly = true;
            this.mskCodCartao.Size = new System.Drawing.Size(209, 20);
            this.mskCodCartao.TabIndex = 4;
            this.mskCodCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCodCartao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Código do Cartão:";
            // 
            // mskCodSeguranca
            // 
            this.mskCodSeguranca.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskCodSeguranca.Location = new System.Drawing.Point(311, 141);
            this.mskCodSeguranca.Mask = "000";
            this.mskCodSeguranca.Name = "mskCodSeguranca";
            this.mskCodSeguranca.ReadOnly = true;
            this.mskCodSeguranca.Size = new System.Drawing.Size(98, 20);
            this.mskCodSeguranca.TabIndex = 7;
            this.mskCodSeguranca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCodSeguranca.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnCadastrarFatura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 469);
            this.panel1.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(17, 432);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFatura
            // 
            this.btnCadastrarFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.btnCadastrarFatura.Location = new System.Drawing.Point(177, 424);
            this.btnCadastrarFatura.Name = "btnCadastrarFatura";
            this.btnCadastrarFatura.Size = new System.Drawing.Size(151, 31);
            this.btnCadastrarFatura.TabIndex = 11;
            this.btnCadastrarFatura.Text = "Finalizar Pedido";
            this.btnCadastrarFatura.UseVisualStyleBackColor = true;
            this.btnCadastrarFatura.Click += new System.EventHandler(this.btnCadastrarFatura_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pagamento:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(164, 37);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(178, 41);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "VALOR TOTAL DO PEDIDO:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxMetodo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pnlBranco);
            this.panel2.Controls.Add(this.pnlDinheiro);
            this.panel2.Controls.Add(this.pnlCartao);
            this.panel2.Location = new System.Drawing.Point(18, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 301);
            this.panel2.TabIndex = 1;
            // 
            // cbxMetodo
            // 
            this.cbxMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMetodo.FormattingEnabled = true;
            this.cbxMetodo.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cbxMetodo.Location = new System.Drawing.Point(174, 31);
            this.cbxMetodo.Name = "cbxMetodo";
            this.cbxMetodo.Size = new System.Drawing.Size(121, 21);
            this.cbxMetodo.TabIndex = 4;
            this.cbxMetodo.SelectedIndexChanged += new System.EventHandler(this.cbxMetodo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Método:";
            // 
            // pnlBranco
            // 
            this.pnlBranco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBranco.Location = new System.Drawing.Point(18, 68);
            this.pnlBranco.Name = "pnlBranco";
            this.pnlBranco.Size = new System.Drawing.Size(431, 208);
            this.pnlBranco.TabIndex = 23;
            // 
            // pnlCartao
            // 
            this.pnlCartao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCartao.Controls.Add(this.mskCPF);
            this.pnlCartao.Controls.Add(this.label13);
            this.pnlCartao.Controls.Add(this.mskCodCartao);
            this.pnlCartao.Controls.Add(this.mskCodSeguranca);
            this.pnlCartao.Controls.Add(this.label11);
            this.pnlCartao.Controls.Add(this.mskValidade);
            this.pnlCartao.Controls.Add(this.label10);
            this.pnlCartao.Controls.Add(this.txtNome);
            this.pnlCartao.Controls.Add(this.label9);
            this.pnlCartao.Controls.Add(this.cbxBandeira);
            this.pnlCartao.Controls.Add(this.label8);
            this.pnlCartao.Controls.Add(this.cbxParcelas);
            this.pnlCartao.Controls.Add(this.label7);
            this.pnlCartao.Controls.Add(this.label12);
            this.pnlCartao.Location = new System.Drawing.Point(18, 68);
            this.pnlCartao.Name = "pnlCartao";
            this.pnlCartao.Size = new System.Drawing.Size(431, 208);
            this.pnlCartao.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cód de Segurança:";
            // 
            // mskValidade
            // 
            this.mskValidade.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskValidade.Location = new System.Drawing.Point(200, 141);
            this.mskValidade.Mask = "00/0000";
            this.mskValidade.Name = "mskValidade";
            this.mskValidade.ReadOnly = true;
            this.mskValidade.Size = new System.Drawing.Size(97, 20);
            this.mskValidade.TabIndex = 6;
            this.mskValidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskValidade.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Validade do Cartão:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(167, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 75);
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
            this.cbxBandeira.Location = new System.Drawing.Point(21, 141);
            this.cbxBandeira.Name = "cbxBandeira";
            this.cbxBandeira.Size = new System.Drawing.Size(167, 21);
            this.cbxBandeira.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bandeira do Cartão:";
            // 
            // cbxParcelas
            // 
            this.cbxParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParcelas.FormattingEnabled = true;
            this.cbxParcelas.Location = new System.Drawing.Point(200, 34);
            this.cbxParcelas.Name = "cbxParcelas";
            this.cbxParcelas.Size = new System.Drawing.Size(209, 21);
            this.cbxParcelas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Parcelas:";
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(532, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlDinheiro.ResumeLayout(false);
            this.pnlDinheiro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlCartao.ResumeLayout(false);
            this.pnlCartao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Panel pnlDinheiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskCodCartao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskCodSeguranca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarFatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxMetodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCartao;
        private System.Windows.Forms.Panel pnlBranco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskValidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxBandeira;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxParcelas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalc;
    }
}