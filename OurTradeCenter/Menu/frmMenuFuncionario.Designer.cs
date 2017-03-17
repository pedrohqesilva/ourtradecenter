namespace ControlaEstoque
{
    partial class frmMenuFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFuncionario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnEstoques = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.btnMensagens = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPedido
            // 
            this.btnPedido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPedido.BackgroundImage")));
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedido.Location = new System.Drawing.Point(18, 16);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(265, 97);
            this.btnPedido.TabIndex = 1;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoCliente.BackgroundImage")));
            this.btnNovoCliente.FlatAppearance.BorderSize = 0;
            this.btnNovoCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNovoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoCliente.Location = new System.Drawing.Point(18, 123);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(265, 84);
            this.btnNovoCliente.TabIndex = 2;
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnEstoques
            // 
            this.btnEstoques.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstoques.BackgroundImage")));
            this.btnEstoques.FlatAppearance.BorderSize = 0;
            this.btnEstoques.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEstoques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstoques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstoques.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstoques.Location = new System.Drawing.Point(18, 278);
            this.btnEstoques.Name = "btnEstoques";
            this.btnEstoques.Size = new System.Drawing.Size(265, 41);
            this.btnEstoques.TabIndex = 4;
            this.btnEstoques.UseVisualStyleBackColor = true;
            this.btnEstoques.Click += new System.EventHandler(this.btnEstoques_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNovoProduto.BackgroundImage")));
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNovoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovoProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovoProduto.Location = new System.Drawing.Point(18, 217);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(265, 51);
            this.btnNovoProduto.TabIndex = 3;
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnDeslogar);
            this.panel1.Controls.Add(this.btnMensagens);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnEstoques);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNovoProduto);
            this.panel1.Controls.Add(this.btnPedido);
            this.panel1.Controls.Add(this.btnNovoCliente);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 397);
            this.panel1.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(593, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(20, 35);
            this.btnSair.TabIndex = 15;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.BackgroundImage")));
            this.btnDeslogar.FlatAppearance.BorderSize = 0;
            this.btnDeslogar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDeslogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeslogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeslogar.Location = new System.Drawing.Point(153, 329);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(130, 52);
            this.btnDeslogar.TabIndex = 8;
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // btnMensagens
            // 
            this.btnMensagens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMensagens.BackgroundImage")));
            this.btnMensagens.FlatAppearance.BorderSize = 0;
            this.btnMensagens.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMensagens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMensagens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMensagens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMensagens.Location = new System.Drawing.Point(18, 329);
            this.btnMensagens.Name = "btnMensagens";
            this.btnMensagens.Size = new System.Drawing.Size(130, 52);
            this.btnMensagens.TabIndex = 7;
            this.btnMensagens.UseVisualStyleBackColor = true;
            this.btnMensagens.Click += new System.EventHandler(this.btnMensagens_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 201);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(641, 424);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuFuncionario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnEstoques;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Button btnMensagens;
        private System.Windows.Forms.Button btnSair;
    }
}