namespace ControlaEstoque
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.lblItensPedido = new System.Windows.Forms.Label();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnAdicionarItensPedido = new System.Windows.Forms.Button();
            this.dtgItensPedido = new System.Windows.Forms.DataGridView();
            this.ColunaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaObservacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValorUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.pnlItensPedido = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.lblCadastroPedidos = new System.Windows.Forms.Label();
            this.pnlCadastroPedidos = new System.Windows.Forms.Panel();
            this.chkEntregar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarPedido = new System.Windows.Forms.Button();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.lblCep = new System.Windows.Forms.Label();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSim = new System.Windows.Forms.CheckBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedido)).BeginInit();
            this.pnlItensPedido.SuspendLayout();
            this.pnlCadastroPedidos.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItensPedido
            // 
            this.lblItensPedido.AutoSize = true;
            this.lblItensPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblItensPedido.Location = new System.Drawing.Point(29, 374);
            this.lblItensPedido.Name = "lblItensPedido";
            this.lblItensPedido.Size = new System.Drawing.Size(105, 16);
            this.lblItensPedido.TabIndex = 315;
            this.lblItensPedido.Text = "Itens do Pedido:";
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(14, 30);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(201, 21);
            this.cbxProduto.TabIndex = 18;
            // 
            // mskTelefone
            // 
            this.mskTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.Location = new System.Drawing.Point(156, 27);
            this.mskTelefone.Mask = "(00) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(154, 20);
            this.mskTelefone.TabIndex = 5;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.TextChanged += new System.EventHandler(this.mskTelefone_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(182, 12);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(102, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone do Cliente:";
            // 
            // btnAdicionarItensPedido
            // 
            this.btnAdicionarItensPedido.Location = new System.Drawing.Point(321, 58);
            this.btnAdicionarItensPedido.Name = "btnAdicionarItensPedido";
            this.btnAdicionarItensPedido.Size = new System.Drawing.Size(131, 35);
            this.btnAdicionarItensPedido.TabIndex = 321;
            this.btnAdicionarItensPedido.Text = "Adicionar";
            this.btnAdicionarItensPedido.UseVisualStyleBackColor = true;
            this.btnAdicionarItensPedido.Click += new System.EventHandler(this.btnAdicionarItensPedido_Click);
            // 
            // dtgItensPedido
            // 
            this.dtgItensPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgItensPedido.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaProduto,
            this.ColunaQuantidade,
            this.ColunaObservacoes,
            this.ColunaValorUni,
            this.ColunaValor});
            this.dtgItensPedido.Location = new System.Drawing.Point(14, 110);
            this.dtgItensPedido.Name = "dtgItensPedido";
            this.dtgItensPedido.Size = new System.Drawing.Size(438, 146);
            this.dtgItensPedido.TabIndex = 323;
            this.dtgItensPedido.TabStop = false;
            this.dtgItensPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgItensPedido_CellContentClick);
            // 
            // ColunaProduto
            // 
            this.ColunaProduto.FillWeight = 150F;
            this.ColunaProduto.HeaderText = "Produto";
            this.ColunaProduto.Name = "ColunaProduto";
            this.ColunaProduto.ReadOnly = true;
            // 
            // ColunaQuantidade
            // 
            this.ColunaQuantidade.FillWeight = 75.80373F;
            this.ColunaQuantidade.HeaderText = "Qtd.";
            this.ColunaQuantidade.Name = "ColunaQuantidade";
            this.ColunaQuantidade.ReadOnly = true;
            // 
            // ColunaObservacoes
            // 
            this.ColunaObservacoes.FillWeight = 151.6075F;
            this.ColunaObservacoes.HeaderText = "Observações";
            this.ColunaObservacoes.Name = "ColunaObservacoes";
            this.ColunaObservacoes.ReadOnly = true;
            // 
            // ColunaValorUni
            // 
            this.ColunaValorUni.FillWeight = 90.96447F;
            this.ColunaValorUni.HeaderText = "Valor Unidade";
            this.ColunaValorUni.Name = "ColunaValorUni";
            this.ColunaValorUni.ReadOnly = true;
            // 
            // ColunaValor
            // 
            this.ColunaValor.FillWeight = 90.96447F;
            this.ColunaValor.HeaderText = "Valor Total";
            this.ColunaValor.Name = "ColunaValor";
            this.ColunaValor.ReadOnly = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(228, 16);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 319;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(228, 31);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(81, 20);
            this.txtQuantidade.TabIndex = 19;
            this.txtQuantidade.Text = "1";
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(14, 15);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 318;
            this.lblProduto.Text = "Produto:";
            // 
            // pnlItensPedido
            // 
            this.pnlItensPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItensPedido.Controls.Add(this.label2);
            this.pnlItensPedido.Controls.Add(this.txtValor);
            this.pnlItensPedido.Controls.Add(this.btnAdicionarItensPedido);
            this.pnlItensPedido.Controls.Add(this.txtObservacoes);
            this.pnlItensPedido.Controls.Add(this.lblObservacoes);
            this.pnlItensPedido.Controls.Add(this.dtgItensPedido);
            this.pnlItensPedido.Controls.Add(this.lblQuantidade);
            this.pnlItensPedido.Controls.Add(this.txtQuantidade);
            this.pnlItensPedido.Controls.Add(this.cbxProduto);
            this.pnlItensPedido.Controls.Add(this.lblProduto);
            this.pnlItensPedido.Location = new System.Drawing.Point(17, 383);
            this.pnlItensPedido.Name = "pnlItensPedido";
            this.pnlItensPedido.Size = new System.Drawing.Size(467, 273);
            this.pnlItensPedido.TabIndex = 314;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 325;
            this.label2.Text = "Valor dos produtos:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(321, 30);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(130, 22);
            this.txtValor.TabIndex = 324;
            this.txtValor.TabStop = false;
            this.txtValor.Text = "R$ 0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(14, 73);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(295, 20);
            this.txtObservacoes.TabIndex = 23;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(14, 58);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 320;
            this.lblObservacoes.Text = "Observações:";
            // 
            // lblCadastroPedidos
            // 
            this.lblCadastroPedidos.AutoSize = true;
            this.lblCadastroPedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCadastroPedidos.Location = new System.Drawing.Point(24, 6);
            this.lblCadastroPedidos.Name = "lblCadastroPedidos";
            this.lblCadastroPedidos.Size = new System.Drawing.Size(139, 16);
            this.lblCadastroPedidos.TabIndex = 1;
            this.lblCadastroPedidos.Text = "Cadastro de Pedidos:";
            // 
            // pnlCadastroPedidos
            // 
            this.pnlCadastroPedidos.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastroPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCadastroPedidos.Controls.Add(this.chkEntregar);
            this.pnlCadastroPedidos.Controls.Add(this.label1);
            this.pnlCadastroPedidos.Controls.Add(this.btnLimpar);
            this.pnlCadastroPedidos.Controls.Add(this.btnCadastrarPedido);
            this.pnlCadastroPedidos.Controls.Add(this.pnlCliente);
            this.pnlCadastroPedidos.Controls.Add(this.lblItensPedido);
            this.pnlCadastroPedidos.Controls.Add(this.pnlItensPedido);
            this.pnlCadastroPedidos.Location = new System.Drawing.Point(12, 16);
            this.pnlCadastroPedidos.Name = "pnlCadastroPedidos";
            this.pnlCadastroPedidos.Size = new System.Drawing.Size(505, 717);
            this.pnlCadastroPedidos.TabIndex = 0;
            // 
            // chkEntregar
            // 
            this.chkEntregar.AutoSize = true;
            this.chkEntregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntregar.Location = new System.Drawing.Point(211, 4);
            this.chkEntregar.Name = "chkEntregar";
            this.chkEntregar.Size = new System.Drawing.Size(83, 23);
            this.chkEntregar.TabIndex = 10;
            this.chkEntregar.TabStop = false;
            this.chkEntregar.Text = "Entregar";
            this.chkEntregar.UseVisualStyleBackColor = true;
            this.chkEntregar.CheckedChanged += new System.EventHandler(this.chkEntregar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dados do Cliente:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 683);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 325;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.btnCadastrarPedido.Location = new System.Drawing.Point(182, 670);
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(176, 36);
            this.btnCadastrarPedido.TabIndex = 324;
            this.btnCadastrarPedido.Text = "Cadastrar Pedido";
            this.btnCadastrarPedido.UseVisualStyleBackColor = true;
            this.btnCadastrarPedido.Click += new System.EventHandler(this.btnCadastrarPedido_Click);
            // 
            // pnlCliente
            // 
            this.pnlCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCliente.Controls.Add(this.cbxCliente);
            this.pnlCliente.Controls.Add(this.lblEndereco);
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.pnlEndereco);
            this.pnlCliente.Controls.Add(this.mskTelefone);
            this.pnlCliente.Controls.Add(this.lblTelefone);
            this.pnlCliente.Location = new System.Drawing.Point(16, 29);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(468, 330);
            this.pnlCliente.TabIndex = 2;
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(72, 73);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(323, 21);
            this.cbxCliente.TabIndex = 7;
            this.cbxCliente.TextChanged += new System.EventHandler(this.cbxCliente_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(27, 99);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 16);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço:";
            this.lblEndereco.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblCliente.Location = new System.Drawing.Point(207, 56);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 16);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cliente:";
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEndereco.Controls.Add(this.lblCep);
            this.pnlEndereco.Controls.Add(this.cbxCidade);
            this.pnlEndereco.Controls.Add(this.cbxEstado);
            this.pnlEndereco.Controls.Add(this.panel1);
            this.pnlEndereco.Controls.Add(this.mskCep);
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
            this.pnlEndereco.Location = new System.Drawing.Point(14, 109);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(438, 205);
            this.pnlEndereco.TabIndex = 8;
            this.pnlEndereco.Visible = false;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(341, 9);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 302;
            this.lblCep.Text = "CEP:";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Enabled = false;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "Abdon Batista",
            "Abelardo Luz",
            "Agrolandia",
            "Agronomica",
            "Agua Doce",
            "Aguas Frias",
            "Aguas Mornas",
            "Aguas de Chapeco",
            "Alfredo Wagner",
            "Alto Bela Vista",
            "Anchieta",
            "Angelina",
            "Anita Garibaldi",
            "Anitapolis",
            "Antonio Carlos",
            "Apiuna",
            "Arabuta",
            "Araquari",
            "Ararangua",
            "Armazem",
            "Arroio Trinta",
            "Arvoredo",
            "Ascurra",
            "Atalanta",
            "Aurora",
            "Balneario Arroio do Silva",
            "Balneario Barra do Sul",
            "Balneario Camboriu",
            "Balneario Gaivota",
            "Bandeirante",
            "Barra Bonita",
            "Barra Velha",
            "Bela Vista do Toldo",
            "Belmonte",
            "Benedito Novo",
            "Biguacu",
            "Blumenau",
            "Bocaina do Sul",
            "Bom Jardim da Serra",
            "Bom Jesus do Oeste",
            "Bom Jesus",
            "Bom Retiro",
            "Bombinhas",
            "Botuvera",
            "Braco do Norte",
            "Braco do Trombudo",
            "Brunopolis",
            "Brusque",
            "Cacador",
            "Caibi",
            "Calmon",
            "Camboriu",
            "Campo Alegre",
            "Campo Belo do Sul",
            "Campo Ere",
            "Campos Novos",
            "Canelinha",
            "Canoinhas",
            "Capao Alto",
            "Capinzal",
            "Capivari de Baixo",
            "Catanduvas",
            "Caxambu do Sul",
            "Celso Ramos",
            "Cerro Negro",
            "Chapadao do Lageado",
            "Chapeco",
            "Cocal do Sul",
            "Concordia",
            "Cordilheira Alta",
            "Coronel Freitas",
            "Coronel Martins",
            "Correia Pinto",
            "Corupa",
            "Criciuma",
            "Cunha Pora",
            "Cunhatai",
            "Curitibanos",
            "Descanso",
            "Dionisio Cerqueira",
            "Dona Emma",
            "Doutor Pedrinho",
            "Entre Rios",
            "Ermo",
            "Erval Velho",
            "Faxinal dos Guedes",
            "Flor do Sertao",
            "Florianopolis",
            "Formosa do Sul",
            "Forquilhinha",
            "Fraiburgo",
            "Frei Rogerio",
            "Galvao",
            "Garopaba",
            "Garuva",
            "Gaspar",
            "Governador Celso Ramos",
            "Grao Para",
            "Gravatal",
            "Guabiruba",
            "Guaraciaba",
            "Guaramirim",
            "Guaruja do Sul",
            "Guatambu",
            "Herval d\'Oeste",
            "Ibiam",
            "Ibicare",
            "Ibirama",
            "Icara",
            "Ilhota",
            "Imarui",
            "Imbituba",
            "Imbuia",
            "Indaial",
            "Iomere",
            "Ipira",
            "Ipora do Oeste",
            "Ipuacu",
            "Ipumirim",
            "Iraceminha",
            "Irani",
            "Irati",
            "Irineopolis",
            "Ita",
            "Itaiopolis",
            "Itajai",
            "Itapema",
            "Itapiranga",
            "Itapoa",
            "Ituporanga",
            "Jabora",
            "Jacinto Machado",
            "Jaguaruna",
            "Jaragua do Sul",
            "Jardinopolis",
            "Joacaba",
            "Joinville",
            "Jose Boiteux",
            "Jupia",
            "Lacerdopolis",
            "Lages",
            "Laguna",
            "Lajeado Grande",
            "Laurentino",
            "Lauro Muller",
            "Lebon Regis",
            "Leoberto Leal",
            "Lindoia do Sul",
            "Lontras",
            "Luiz Alves",
            "Luzerna",
            "Macieira",
            "Mafra",
            "Major Gercino",
            "Major Vieira",
            "Maracaja",
            "Maravilha",
            "Marema",
            "Massaranduba",
            "Matos Costa",
            "Meleiro",
            "Mirim Doce",
            "Modelo",
            "Mondai",
            "Monte Carlo",
            "Monte Castelo",
            "Morro Grande",
            "Morro da Fumaca",
            "Navegantes",
            "Nova Erechim",
            "Nova Itaberaba",
            "Nova Trento",
            "Nova Veneza",
            "Novo Horizonte",
            "Orleans",
            "Otacilio Costa",
            "Ouro Verde",
            "Ouro",
            "Paial",
            "Painel",
            "Palhoca",
            "Palma Sola",
            "Palmeira",
            "Palmitos",
            "Papanduva",
            "Paraiso",
            "Passo de Torres",
            "Passos Maia",
            "Paulo Lopes",
            "Pedras Grandes",
            "Penha",
            "Peritiba",
            "Petrolandia",
            "Picarras",
            "Pinhalzinho",
            "Pinheiro Preto",
            "Piratuba",
            "Planalto Alegre",
            "Pomerode",
            "Ponte Alta do Norte",
            "Ponte Alta",
            "Ponte Serrada",
            "Porto Belo",
            "Porto Uniao",
            "Pouso Redondo",
            "Praia Grande",
            "Presidente Castelo Branco",
            "Presidente Getulio",
            "Presidente Nereu",
            "Princesa",
            "Quilombo",
            "Rancho Queimado",
            "Rio Fortuna",
            "Rio Negrinho",
            "Rio Rufino",
            "Rio d\'Oeste",
            "Rio das Antas",
            "Rio do Campo",
            "Rio do Sul",
            "Rio dos Cedros",
            "Riqueza",
            "Rodeio",
            "Romelandia",
            "Salete",
            "Saltinho",
            "Salto Veloso",
            "Sangao",
            "Santa Cecilia",
            "Santa Helena",
            "Santa Rosa de Lima",
            "Santa Rosa do Sul",
            "Santa Terezinha do Progresso",
            "Santa Terezinha",
            "Santiago do Sul",
            "Santo Amaro da Imperatriz",
            "Sao Bento do Sul",
            "Sao Bernardino",
            "Sao Bonifacio",
            "Sao Carlos",
            "Sao Cristovao do Sul",
            "Sao Domingos",
            "Sao Francisco do Sul",
            "Sao Joao Batista",
            "Sao Joao do Itaperiu",
            "Sao Joao do Oeste",
            "Sao Joao do Sul",
            "Sao Joaquim",
            "Sao Jose do Cedro",
            "Sao Jose do Cerrito",
            "Sao Jose",
            "Sao Lourenco d\'Oeste",
            "Sao Ludgero",
            "Sao Martinho",
            "Sao Miguel d\'Oeste",
            "Sao Miguel da Boa Vista",
            "Sao Pedro de Alcantara",
            "Saudades",
            "Schroeder",
            "Seara",
            "Serra Alta",
            "Sideropolis",
            "Sombrio",
            "Sul Brasil",
            "Taio",
            "Tangara",
            "Tigrinhos",
            "Tijucas",
            "Timbe do Sul",
            "Timbo Grande",
            "Timbo",
            "Tres Barras",
            "Treviso",
            "Treze Tilias",
            "Treze de Maio",
            "Trombudo Central",
            "Tubarao",
            "Tunapolis",
            "Turvo",
            "Uniao do Oeste",
            "Urubici",
            "Urupema",
            "Urussanga",
            "Vargeao",
            "Vargem Bonita",
            "Vargem",
            "Vidal Ramos",
            "Videira",
            "Vitor Meireles",
            "Witmarsum",
            "Xanxere",
            "Xavantina",
            "Xaxim",
            "Zortea"});
            this.cbxCidade.Location = new System.Drawing.Point(193, 73);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(182, 21);
            this.cbxCidade.TabIndex = 305;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Enabled = false;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxEstado.Location = new System.Drawing.Point(162, 25);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(133, 21);
            this.cbxEstado.TabIndex = 301;
            this.cbxEstado.TextChanged += new System.EventHandler(this.cbxEstado_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkSim);
            this.panel1.Location = new System.Drawing.Point(18, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 60);
            this.panel1.TabIndex = 314;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deseja alterar o \r\nendereço?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSim
            // 
            this.chkSim.AutoSize = true;
            this.chkSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSim.Location = new System.Drawing.Point(31, 38);
            this.chkSim.Name = "chkSim";
            this.chkSim.Size = new System.Drawing.Size(43, 17);
            this.chkSim.TabIndex = 1;
            this.chkSim.Text = "Sim";
            this.chkSim.UseVisualStyleBackColor = true;
            this.chkSim.CheckedChanged += new System.EventHandler(this.chkSim_CheckedChanged);
            // 
            // mskCep
            // 
            this.mskCep.Enabled = false;
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(307, 24);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(99, 22);
            this.mskCep.TabIndex = 303;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(207, 10);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 300;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(263, 57);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 304;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(191, 172);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(230, 20);
            this.txtBairro.TabIndex = 313;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(191, 157);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 312;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(101, 172);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(79, 20);
            this.txtComplemento.TabIndex = 311;
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(101, 157);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 310;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(18, 172);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 20);
            this.txtNumero.TabIndex = 309;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(18, 157);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 308;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(18, 126);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(403, 20);
            this.txtLogradouro.TabIndex = 307;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(18, 111);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 306;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 745);
            this.Controls.Add(this.lblCadastroPedidos);
            this.Controls.Add(this.pnlCadastroPedidos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedido)).EndInit();
            this.pnlItensPedido.ResumeLayout(false);
            this.pnlItensPedido.PerformLayout();
            this.pnlCadastroPedidos.ResumeLayout(false);
            this.pnlCadastroPedidos.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItensPedido;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnAdicionarItensPedido;
        private System.Windows.Forms.DataGridView dtgItensPedido;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Panel pnlItensPedido;
        private System.Windows.Forms.Label lblCadastroPedidos;
        private System.Windows.Forms.Panel pnlCadastroPedidos;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.CheckBox chkSim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkEntregar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaObservacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValorUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValor;
    }
}