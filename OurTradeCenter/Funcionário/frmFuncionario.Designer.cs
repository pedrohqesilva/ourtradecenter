namespace ControlaEstoque
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnlSexo = new System.Windows.Forms.Panel();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
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
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pnlDadoFuncionario = new System.Windows.Forms.Panel();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDadoFuncionario = new System.Windows.Forms.Label();
            this.pnlSexo.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.pnlDadoFuncionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(218, 190);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 16;
            this.lblSexo.Text = "Sexo:";
            // 
            // pnlSexo
            // 
            this.pnlSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSexo.Controls.Add(this.rdbFem);
            this.pnlSexo.Controls.Add(this.rdbMasc);
            this.pnlSexo.Location = new System.Drawing.Point(156, 199);
            this.pnlSexo.Name = "pnlSexo";
            this.pnlSexo.Size = new System.Drawing.Size(159, 38);
            this.pnlSexo.TabIndex = 17;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.Location = new System.Drawing.Point(89, 11);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(67, 17);
            this.rdbFem.TabIndex = 1;
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
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Papyrus", 10.75F);
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(156, 492);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(176, 36);
            this.btnCadastrarFuncionario.TabIndex = 33;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(31, 258);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(70, 16);
            this.lblEndereco.TabIndex = 19;
            this.lblEndereco.Text = "Endereço:";
            // 
            // pnlEndereco
            // 
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
            this.pnlEndereco.Location = new System.Drawing.Point(21, 267);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Size = new System.Drawing.Size(436, 205);
            this.pnlEndereco.TabIndex = 18;
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbxCidade.Location = new System.Drawing.Point(103, 72);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(230, 21);
            this.cbxCidade.TabIndex = 24;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC - Acre",
            "AL - Alagoas",
            "AP - Amapá",
            "AM - Amazonas",
            "BA - Bahia",
            "CE - Ceará",
            "DF - Distrito Federal",
            "ES - Espírito Santo",
            "GO - Goiás",
            "MA - Maranhão",
            "MT - Mato Grosso",
            "MS - Mato Grosso do Sul",
            "MG - Minas Gerais",
            "PA - Pará",
            "PB - Paraíba",
            "PR - Paraná",
            "PE - Pernambuco",
            "PI - Piauí",
            "RJ - Rio de Janeiro",
            "RN - Rio Grande do Norte",
            "RS - Rio Grande do Sul",
            "RO - Rondônia",
            "RR - Roraima"});
            this.cbxEstado.Location = new System.Drawing.Point(88, 26);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(153, 21);
            this.cbxEstado.TabIndex = 20;
            this.cbxEstado.TextChanged += new System.EventHandler(this.cbxEstado_TextChanged);
            // 
            // mskCep
            // 
            this.mskCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCep.Location = new System.Drawing.Point(247, 25);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(99, 22);
            this.mskCep.TabIndex = 22;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(281, 10);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 21;
            this.lblCep.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(143, 11);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(197, 56);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 23;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(196, 172);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(224, 20);
            this.txtBairro.TabIndex = 32;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(196, 156);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 31;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(100, 172);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(79, 20);
            this.txtComplemento.TabIndex = 30;
            this.txtComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(100, 156);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 29;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(17, 172);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 20);
            this.txtNumero.TabIndex = 28;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumero);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 156);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(17, 126);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(403, 20);
            this.txtLogradouro.TabIndex = 26;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(14, 107);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 25;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // mskCpf
            // 
            this.mskCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskCpf.Location = new System.Drawing.Point(357, 115);
            this.mskCpf.Mask = "000-000-000.00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 12;
            this.mskCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(357, 99);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 13);
            this.lblCpf.TabIndex = 11;
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
            // mskTelefone
            // 
            this.mskTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mskTelefone.Location = new System.Drawing.Point(18, 156);
            this.mskTelefone.Mask = "(99) 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(131, 20);
            this.mskTelefone.TabIndex = 13;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // pnlDadoFuncionario
            // 
            this.pnlDadoFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.pnlDadoFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDadoFuncionario.Controls.Add(this.mskDataNascimento);
            this.pnlDadoFuncionario.Controls.Add(this.label2);
            this.pnlDadoFuncionario.Controls.Add(this.txtSenha);
            this.pnlDadoFuncionario.Controls.Add(this.label1);
            this.pnlDadoFuncionario.Controls.Add(this.txtUsuario);
            this.pnlDadoFuncionario.Controls.Add(this.btnLimpar);
            this.pnlDadoFuncionario.Controls.Add(this.cbxCargo);
            this.pnlDadoFuncionario.Controls.Add(this.lblCargo);
            this.pnlDadoFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.pnlDadoFuncionario.Controls.Add(this.lblSexo);
            this.pnlDadoFuncionario.Controls.Add(this.pnlSexo);
            this.pnlDadoFuncionario.Controls.Add(this.lblEndereco);
            this.pnlDadoFuncionario.Controls.Add(this.pnlEndereco);
            this.pnlDadoFuncionario.Controls.Add(this.mskCpf);
            this.pnlDadoFuncionario.Controls.Add(this.lblCpf);
            this.pnlDadoFuncionario.Controls.Add(this.lblNascimento);
            this.pnlDadoFuncionario.Controls.Add(this.label5);
            this.pnlDadoFuncionario.Controls.Add(this.txtEmail);
            this.pnlDadoFuncionario.Controls.Add(this.lblEmail);
            this.pnlDadoFuncionario.Controls.Add(this.txtNome);
            this.pnlDadoFuncionario.Controls.Add(this.lblNome);
            this.pnlDadoFuncionario.Controls.Add(this.mskTelefone);
            this.pnlDadoFuncionario.Controls.Add(this.lblTelefone);
            this.pnlDadoFuncionario.Location = new System.Drawing.Point(12, 17);
            this.pnlDadoFuncionario.Name = "pnlDadoFuncionario";
            this.pnlDadoFuncionario.Size = new System.Drawing.Size(475, 549);
            this.pnlDadoFuncionario.TabIndex = 100;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(246, 115);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimento.TabIndex = 10;
            this.mskDataNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(243, 26);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(144, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(84, 26);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(21, 505);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 34;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(161, 155);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(296, 21);
            this.cbxCargo.TabIndex = 15;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(161, 139);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 14;
            this.lblCargo.Text = "Cargo:";
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
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(18, 141);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblDadoFuncionario
            // 
            this.lblDadoFuncionario.AutoSize = true;
            this.lblDadoFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblDadoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadoFuncionario.Location = new System.Drawing.Point(21, 8);
            this.lblDadoFuncionario.Name = "lblDadoFuncionario";
            this.lblDadoFuncionario.Size = new System.Drawing.Size(144, 16);
            this.lblDadoFuncionario.TabIndex = 200;
            this.lblDadoFuncionario.Text = "Dados do Funcionário:";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.lblDadoFuncionario);
            this.Controls.Add(this.pnlDadoFuncionario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlSexo.ResumeLayout(false);
            this.pnlSexo.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.pnlDadoFuncionario.ResumeLayout(false);
            this.pnlDadoFuncionario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlSexo;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Panel pnlDadoFuncionario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblDadoFuncionario;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.ComboBox cbxCidade;

    }
}