namespace ControlaEstoque
{
    partial class frmMenuGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuGerente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnNovoIngrediente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRelatorioProduto = new System.Windows.Forms.Button();
            this.btnRelatorioFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.BackgroundImage")));
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFuncionario.Location = new System.Drawing.Point(29, 73);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(277, 80);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnNovoIngrediente
            // 
            this.btnNovoIngrediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoIngrediente.BackgroundImage")));
            this.btnNovoIngrediente.FlatAppearance.BorderSize = 0;
            this.btnNovoIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoIngrediente.Location = new System.Drawing.Point(29, 245);
            this.btnNovoIngrediente.Name = "btnNovoIngrediente";
            this.btnNovoIngrediente.Size = new System.Drawing.Size(277, 80);
            this.btnNovoIngrediente.TabIndex = 3;
            this.btnNovoIngrediente.UseVisualStyleBackColor = true;
            this.btnNovoIngrediente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNovoIngrediente);
            this.panel1.Controls.Add(this.btnNovoProduto);
            this.panel1.Controls.Add(this.btnFuncionario);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 438);
            this.panel1.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(314, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(20, 35);
            this.btnSair.TabIndex = 16;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnDeslogar_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "RELATÓRIOS:";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoProduto.BackgroundImage")));
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoProduto.Location = new System.Drawing.Point(29, 159);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(277, 80);
            this.btnNovoProduto.TabIndex = 2;
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRelatorioProduto);
            this.panel2.Controls.Add(this.btnRelatorioFuncionario);
            this.panel2.Location = new System.Drawing.Point(18, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 68);
            this.panel2.TabIndex = 6;
            // 
            // btnRelatorioProduto
            // 
            this.btnRelatorioProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorioProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioProduto.Location = new System.Drawing.Point(152, 11);
            this.btnRelatorioProduto.Name = "btnRelatorioProduto";
            this.btnRelatorioProduto.Size = new System.Drawing.Size(135, 44);
            this.btnRelatorioProduto.TabIndex = 5;
            this.btnRelatorioProduto.UseVisualStyleBackColor = true;
            this.btnRelatorioProduto.Click += new System.EventHandler(this.btnRelatorioProduto_Click);
            // 
            // btnRelatorioFuncionario
            // 
            this.btnRelatorioFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorioFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRelatorioFuncionario.Location = new System.Drawing.Point(11, 10);
            this.btnRelatorioFuncionario.Name = "btnRelatorioFuncionario";
            this.btnRelatorioFuncionario.Size = new System.Drawing.Size(135, 45);
            this.btnRelatorioFuncionario.TabIndex = 4;
            this.btnRelatorioFuncionario.UseVisualStyleBackColor = true;
            this.btnRelatorioFuncionario.Click += new System.EventHandler(this.btnRelatorioFuncionario_Click);
            // 
            // frmMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 462);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter (Gerente)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnNovoIngrediente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRelatorioProduto;
        private System.Windows.Forms.Button btnRelatorioFuncionario;
        private System.Windows.Forms.Button btnSair;
    }
}