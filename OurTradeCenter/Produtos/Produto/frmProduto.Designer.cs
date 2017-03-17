namespace ControlaEstoque
{
    partial class frmProduto
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
            System.Windows.Forms.Label lblQuantidade;
            System.Windows.Forms.Label lblMedida;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.cbxIngrediente = new System.Windows.Forms.ComboBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.lblCustoTotal = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtgIngredientes = new System.Windows.Forms.DataGridView();
            this.ColunaIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCustoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCustoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdicionarIngrediente = new System.Windows.Forms.Button();
            this.btnAlterarFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCadastrarProduto = new System.Windows.Forms.Panel();
            this.btnProdutosCadastrados = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.lblValorProduto = new System.Windows.Forms.Label();
            this.pnlValor = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.btnAdicionarGrupo = new System.Windows.Forms.Button();
            this.pnlIngredientes = new System.Windows.Forms.Panel();
            this.btnAdicionarIng = new System.Windows.Forms.Button();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.ofdAlterarFoto = new System.Windows.Forms.OpenFileDialog();
            lblQuantidade = new System.Windows.Forms.Label();
            lblMedida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.pnlCadastrarProduto.SuspendLayout();
            this.pnlValor.SuspendLayout();
            this.pnlIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new System.Drawing.Point(259, 24);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new System.Drawing.Size(65, 13);
            lblQuantidade.TabIndex = 15;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblMedida
            // 
            lblMedida.AutoSize = true;
            lblMedida.Location = new System.Drawing.Point(334, 24);
            lblMedida.Name = "lblMedida";
            lblMedida.Size = new System.Drawing.Size(45, 13);
            lblMedida.TabIndex = 17;
            lblMedida.Text = "Medida:";
            // 
            // cbxIngrediente
            // 
            this.cbxIngrediente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIngrediente.FormattingEnabled = true;
            this.cbxIngrediente.Items.AddRange(new object[] {
            "Selecione o Ingrediente"});
            this.cbxIngrediente.Location = new System.Drawing.Point(23, 39);
            this.cbxIngrediente.Name = "cbxIngrediente";
            this.cbxIngrediente.Size = new System.Drawing.Size(201, 21);
            this.cbxIngrediente.TabIndex = 4;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Location = new System.Drawing.Point(23, 24);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(63, 13);
            this.lblIngrediente.TabIndex = 300;
            this.lblIngrediente.Text = "Ingrediente:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(17, 53);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(39, 13);
            this.lblGrupo.TabIndex = 2;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(42, 49);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(83, 13);
            this.lblValor.TabIndex = 500;
            this.lblValor.Text = "Valor de Venda:";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(62, 49);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(299, 21);
            this.cbxGrupo.TabIndex = 2;
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.AutoSize = true;
            this.lblCustoTotal.Location = new System.Drawing.Point(24, 23);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(101, 13);
            this.lblCustoTotal.TabIndex = 6;
            this.lblCustoTotal.Text = "Custo de Produção:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(299, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // dtgIngredientes
            // 
            this.dtgIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIngredientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaIngrediente,
            this.ColunaQuantidade,
            this.ColunaMedida,
            this.ColunaCustoUni,
            this.ColunaCustoTotal});
            this.dtgIngredientes.Location = new System.Drawing.Point(22, 64);
            this.dtgIngredientes.Name = "dtgIngredientes";
            this.dtgIngredientes.Size = new System.Drawing.Size(557, 125);
            this.dtgIngredientes.TabIndex = 21;
            this.dtgIngredientes.TabStop = false;
            this.dtgIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIngredientes_CellContentClick);
            // 
            // ColunaIngrediente
            // 
            this.ColunaIngrediente.HeaderText = "Ingrediente";
            this.ColunaIngrediente.Name = "ColunaIngrediente";
            this.ColunaIngrediente.ReadOnly = true;
            // 
            // ColunaQuantidade
            // 
            this.ColunaQuantidade.HeaderText = "Qtd.";
            this.ColunaQuantidade.Name = "ColunaQuantidade";
            this.ColunaQuantidade.ReadOnly = true;
            // 
            // ColunaMedida
            // 
            this.ColunaMedida.HeaderText = "Medida";
            this.ColunaMedida.Name = "ColunaMedida";
            this.ColunaMedida.ReadOnly = true;
            // 
            // ColunaCustoUni
            // 
            this.ColunaCustoUni.HeaderText = "Custo Uni";
            this.ColunaCustoUni.Name = "ColunaCustoUni";
            this.ColunaCustoUni.ReadOnly = true;
            // 
            // ColunaCustoTotal
            // 
            this.ColunaCustoTotal.HeaderText = "Custo Total";
            this.ColunaCustoTotal.Name = "ColunaCustoTotal";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(477, 16);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(83, 13);
            this.lblFoto.TabIndex = 1008;
            this.lblFoto.Text = "Foto do Produto";
            // 
            // pcbFoto
            // 
            this.pcbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbFoto.Location = new System.Drawing.Point(416, 23);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(204, 149);
            this.pcbFoto.TabIndex = 1009;
            this.pcbFoto.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnAdicionarIngrediente
            // 
            this.btnAdicionarIngrediente.Location = new System.Drawing.Point(488, 38);
            this.btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            this.btnAdicionarIngrediente.Size = new System.Drawing.Size(91, 23);
            this.btnAdicionarIngrediente.TabIndex = 9;
            this.btnAdicionarIngrediente.Text = "Adicionar";
            this.btnAdicionarIngrediente.UseVisualStyleBackColor = true;
            this.btnAdicionarIngrediente.Click += new System.EventHandler(this.btnAdicionarIngrediente_Click);
            // 
            // btnAlterarFoto
            // 
            this.btnAlterarFoto.Enabled = false;
            this.btnAlterarFoto.Location = new System.Drawing.Point(481, 178);
            this.btnAlterarFoto.Name = "btnAlterarFoto";
            this.btnAlterarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFoto.TabIndex = 10;
            this.btnAlterarFoto.Text = "Alterar";
            this.btnAlterarFoto.UseVisualStyleBackColor = true;
            this.btnAlterarFoto.Click += new System.EventHandler(this.btnAlterarFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 1007;
            this.label1.Text = "Cadastro de Produtos:";
            // 
            // pnlCadastrarProduto
            // 
            this.pnlCadastrarProduto.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastrarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastrarProduto.Controls.Add(this.btnProdutosCadastrados);
            this.pnlCadastrarProduto.Controls.Add(this.btnLimpar);
            this.pnlCadastrarProduto.Controls.Add(this.label3);
            this.pnlCadastrarProduto.Controls.Add(this.btnCadastrarProduto);
            this.pnlCadastrarProduto.Controls.Add(this.lblValorProduto);
            this.pnlCadastrarProduto.Controls.Add(this.pnlValor);
            this.pnlCadastrarProduto.Controls.Add(this.btnAdicionarGrupo);
            this.pnlCadastrarProduto.Controls.Add(this.lblGrupo);
            this.pnlCadastrarProduto.Controls.Add(this.lblFoto);
            this.pnlCadastrarProduto.Controls.Add(this.pcbFoto);
            this.pnlCadastrarProduto.Controls.Add(this.cbxGrupo);
            this.pnlCadastrarProduto.Controls.Add(this.txtNome);
            this.pnlCadastrarProduto.Controls.Add(this.btnAlterarFoto);
            this.pnlCadastrarProduto.Controls.Add(this.lblNome);
            this.pnlCadastrarProduto.Controls.Add(this.pnlIngredientes);
            this.pnlCadastrarProduto.Location = new System.Drawing.Point(12, 17);
            this.pnlCadastrarProduto.Name = "pnlCadastrarProduto";
            this.pnlCadastrarProduto.Size = new System.Drawing.Size(646, 485);
            this.pnlCadastrarProduto.TabIndex = 1001;
            // 
            // btnProdutosCadastrados
            // 
            this.btnProdutosCadastrados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutosCadastrados.BackgroundImage")));
            this.btnProdutosCadastrados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProdutosCadastrados.Location = new System.Drawing.Point(365, 22);
            this.btnProdutosCadastrados.Name = "btnProdutosCadastrados";
            this.btnProdutosCadastrados.Size = new System.Drawing.Size(23, 23);
            this.btnProdutosCadastrados.TabIndex = 1010;
            this.btnProdutosCadastrados.TabStop = false;
            this.btnProdutosCadastrados.UseVisualStyleBackColor = true;
            this.btnProdutosCadastrados.Click += new System.EventHandler(this.btnProdutosCadastrados_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 451);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingredientes do Produto:";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Papyrus", 10.75F);
            this.btnCadastrarProduto.Location = new System.Drawing.Point(233, 438);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(176, 36);
            this.btnCadastrarProduto.TabIndex = 24;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // lblValorProduto
            // 
            this.lblValorProduto.AutoSize = true;
            this.lblValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblValorProduto.Location = new System.Drawing.Point(44, 86);
            this.lblValorProduto.Name = "lblValorProduto";
            this.lblValorProduto.Size = new System.Drawing.Size(112, 16);
            this.lblValorProduto.TabIndex = 100;
            this.lblValorProduto.Text = "Valor do Produto:";
            // 
            // pnlValor
            // 
            this.pnlValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlValor.Controls.Add(this.txtValor);
            this.pnlValor.Controls.Add(this.txtCusto);
            this.pnlValor.Controls.Add(this.lblCustoTotal);
            this.pnlValor.Controls.Add(this.lblValor);
            this.pnlValor.Location = new System.Drawing.Point(20, 95);
            this.pnlValor.Name = "pnlValor";
            this.pnlValor.Size = new System.Drawing.Size(367, 77);
            this.pnlValor.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(131, 45);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(209, 20);
            this.txtValor.TabIndex = 10;
            this.txtValor.Text = "R$ ";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(131, 19);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.ReadOnly = true;
            this.txtCusto.Size = new System.Drawing.Size(209, 20);
            this.txtCusto.TabIndex = 10;
            this.txtCusto.TabStop = false;
            this.txtCusto.Text = "R$ 0";
            // 
            // btnAdicionarGrupo
            // 
            this.btnAdicionarGrupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarGrupo.BackgroundImage")));
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(365, 48);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarGrupo.TabIndex = 3;
            this.btnAdicionarGrupo.UseVisualStyleBackColor = true;
            this.btnAdicionarGrupo.Click += new System.EventHandler(this.btnAdicionarGrupo_Click);
            // 
            // pnlIngredientes
            // 
            this.pnlIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIngredientes.Controls.Add(this.btnAdicionarIng);
            this.pnlIngredientes.Controls.Add(this.cbxMedida);
            this.pnlIngredientes.Controls.Add(lblMedida);
            this.pnlIngredientes.Controls.Add(this.txtQuantidade);
            this.pnlIngredientes.Controls.Add(lblQuantidade);
            this.pnlIngredientes.Controls.Add(this.dtgIngredientes);
            this.pnlIngredientes.Controls.Add(this.btnAdicionarIngrediente);
            this.pnlIngredientes.Controls.Add(this.lblIngrediente);
            this.pnlIngredientes.Controls.Add(this.cbxIngrediente);
            this.pnlIngredientes.Location = new System.Drawing.Point(20, 211);
            this.pnlIngredientes.Name = "pnlIngredientes";
            this.pnlIngredientes.Size = new System.Drawing.Size(603, 208);
            this.pnlIngredientes.TabIndex = 12;
            // 
            // btnAdicionarIng
            // 
            this.btnAdicionarIng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarIng.BackgroundImage")));
            this.btnAdicionarIng.Location = new System.Drawing.Point(230, 38);
            this.btnAdicionarIng.Name = "btnAdicionarIng";
            this.btnAdicionarIng.Size = new System.Drawing.Size(23, 23);
            this.btnAdicionarIng.TabIndex = 5;
            this.btnAdicionarIng.UseVisualStyleBackColor = true;
            this.btnAdicionarIng.Click += new System.EventHandler(this.btnAdicionarIng_Click);
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
            this.cbxMedida.Location = new System.Drawing.Point(334, 39);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(148, 21);
            this.cbxMedida.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(259, 40);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(68, 20);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // ofdAlterarFoto
            // 
            this.ofdAlterarFoto.InitialDirectory = "C:";
            this.ofdAlterarFoto.Title = "Adicionar foto do produto";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCadastrarProduto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.Activated += new System.EventHandler(this.frmProduto_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.pnlCadastrarProduto.ResumeLayout(false);
            this.pnlCadastrarProduto.PerformLayout();
            this.pnlValor.ResumeLayout(false);
            this.pnlValor.PerformLayout();
            this.pnlIngredientes.ResumeLayout(false);
            this.pnlIngredientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxIngrediente;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.Label lblCustoTotal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dtgIngredientes;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAdicionarIngrediente;
        private System.Windows.Forms.Button btnAlterarFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCadastrarProduto;
        private System.Windows.Forms.Label lblValorProduto;
        private System.Windows.Forms.Panel pnlValor;
        private System.Windows.Forms.Button btnAdicionarGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlIngredientes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.Button btnAdicionarIng;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCustoUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCustoTotal;
        private System.Windows.Forms.OpenFileDialog ofdAlterarFoto;
        private System.Windows.Forms.Button btnProdutosCadastrados;
    }
}