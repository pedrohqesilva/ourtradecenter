namespace ControlaEstoque
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pnlDadosCliente = new System.Windows.Forms.Panel();
            this.btnCartao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarClinte = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlSexo = new System.Windows.Forms.Panel();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.pnlDadosCliente.SuspendLayout();
            this.pnlSexo.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(170, 27);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(131, 22);
            this.mskTelefone.TabIndex = 3;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pnlDadosCliente
            // 
            this.pnlDadosCliente.BackColor = System.Drawing.Color.Transparent;
            this.pnlDadosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadosCliente.Controls.Add(this.btnCartao);
            this.pnlDadosCliente.Controls.Add(this.label2);
            this.pnlDadosCliente.Controls.Add(this.mskDataNascimento);
            this.pnlDadosCliente.Controls.Add(this.btnLimpar);
            this.pnlDadosCliente.Controls.Add(this.btnCadastrarClinte);
            this.pnlDadosCliente.Controls.Add(this.label17);
            this.pnlDadosCliente.Controls.Add(this.pnlSexo);
            this.pnlDadosCliente.Controls.Add(this.lblEndereco);
            this.pnlDadosCliente.Controls.Add(this.pnlEndereco);
            this.pnlDadosCliente.Controls.Add(this.mskCpf);
            this.pnlDadosCliente.Controls.Add(this.lblCpf);
            this.pnlDadosCliente.Controls.Add(this.lblNascimento);
            this.pnlDadosCliente.Controls.Add(this.label5);
            this.pnlDadosCliente.Controls.Add(this.txtEmail);
            this.pnlDadosCliente.Controls.Add(this.lblEmail);
            this.pnlDadosCliente.Controls.Add(this.txtNome);
            this.pnlDadosCliente.Controls.Add(this.lblNome);
            this.pnlDadosCliente.Controls.Add(this.mskTelefone);
            this.pnlDadosCliente.Controls.Add(this.label1);
            this.pnlDadosCliente.Location = new System.Drawing.Point(12, 14);
            this.pnlDadosCliente.Name = "pnlDadosCliente";
            this.pnlDadosCliente.Size = new System.Drawing.Size(475, 495);
            this.pnlDadosCliente.TabIndex = 1;
            // 
            // btnCartao
            // 
            this.btnCartao.Location = new System.Drawing.Point(367, 453);
            this.btnCartao.Name = "btnCartao";
            this.btnCartao.Size = new System.Drawing.Size(75, 23);
            this.btnCartao.TabIndex = 303;
            this.btnCartao.Text = "Cartão";
            this.btnCartao.UseVisualStyleBackColor = true;
            this.btnCartao.Click += new System.EventHandler(this.btnCartao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 302;
            this.label2.Text = "Adicionar Cartão";
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(246, 115);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimento.TabIndex = 9;
            this.mskDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 453);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarClinte
            // 
            this.btnCadastrarClinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.btnCadastrarClinte.Location = new System.Drawing.Point(151, 440);
            this.btnCadastrarClinte.Name = "btnCadastrarClinte";
            this.btnCadastrarClinte.Size = new System.Drawing.Size(176, 36);
            this.btnCadastrarClinte.TabIndex = 32;
            this.btnCadastrarClinte.Text = "Cadastrar Cliente";
            this.btnCadastrarClinte.UseVisualStyleBackColor = true;
            this.btnCadastrarClinte.Click += new System.EventHandler(this.btnCadastrarClinte_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Sexo:";
            // 
            // pnlSexo
            // 
            this.pnlSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSexo.Controls.Add(this.rdbFem);
            this.pnlSexo.Controls.Add(this.rdbMasc);
            this.pnlSexo.Location = new System.Drawing.Point(156, 154);
            this.pnlSexo.Name = "pnlSexo";
            this.pnlSexo.Size = new System.Drawing.Size(159, 38);
            this.pnlSexo.TabIndex = 13;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(89, 11);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(67, 17);
            this.rdbFem.TabIndex = 15;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.Location = new System.Drawing.Point(10, 11);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(73, 17);
            this.rdbMasc.TabIndex = 14;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(31, 207);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 16);
            this.lblEndereco.TabIndex = 301;
            this.lblEndereco.Text = "Endereço:";
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.BackColor = System.Drawing.Color.Transparent;
            this.pnlEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEndereco.Controls.Add(this.cbxCidade);
            this.pnlEndereco.Controls.Add(this.cbxEstado);
            this.pnlEndereco.Controls.Add(this.mskCep);
            this.pnlEndereco.Controls.Add(this.lblCep);
            this.pnlEndereco.Controls.Add(this.lblEstado);
            this.pnlEndereco.Controls.Add(this.lblCidade);
            this.pnlEndereco.Controls.Add(this.txtBairro);
            this.pnlEndereco.Controls.Add(this.lblBairro);
            this.pnlEndereco.Controls.Add(this.txtComplemento);
            this.pnlEndereco.Controls.Add(this.lblComplemento);
            this.pnlEndereco.Controls.Add(this.txtNumero);
            this.pnlEndereco.Controls.Add(this.lblNumero);
            this.pnlEndereco.Controls.Add(this.txtLogradouro);
            this.pnlEndereco.Controls.Add(this.lblLogradouro);
            this.pnlEndereco.Location = new System.Drawing.Point(21, 216);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(436, 205);
            this.pnlEndereco.TabIndex = 16;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(124, 72);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(188, 21);
            this.cbxCidade.TabIndex = 21;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(88, 26);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(153, 21);
            this.cbxEstado.TabIndex = 17;
            this.cbxEstado.TextChanged += new System.EventHandler(this.cbxEstado_TextChanged);
            // 
            // mskCep
            // 
            this.mskCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(247, 25);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(99, 22);
            this.mskCep.TabIndex = 19;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(281, 10);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 18;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(143, 11);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 300;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(197, 56);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 20;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(196, 172);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(224, 20);
            this.txtBairro.TabIndex = 29;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(196, 156);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 28;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(100, 172);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(79, 20);
            this.txtComplemento.TabIndex = 27;
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(100, 156);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 26;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(17, 172);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 20);
            this.txtNumero.TabIndex = 25;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 156);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(17, 126);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(403, 20);
            this.txtLogradouro.TabIndex = 23;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(14, 107);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 22;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // mskCpf
            // 
            this.mskCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCpf.Location = new System.Drawing.Point(357, 115);
            this.mskCpf.Mask = "000-000-000.00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 11;
            this.mskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(357, 99);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 10;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(246, 99);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(66, 13);
            this.lblNascimento.TabIndex = 8;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(18, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(21, 5);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(115, 16);
            this.lblDadosCliente.TabIndex = 0;
            this.lblDadosCliente.Text = "Dados do Cliente:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 522);
            this.Controls.Add(this.lblDadosCliente);
            this.Controls.Add(this.pnlDadosCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlDadosCliente.ResumeLayout(false);
            this.pnlDadosCliente.PerformLayout();
            this.pnlSexo.ResumeLayout(false);
            this.pnlSexo.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Panel pnlDadosCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDadosCliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlSexo;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Button btnCadastrarClinte;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Button btnCartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCidade;

    }
}