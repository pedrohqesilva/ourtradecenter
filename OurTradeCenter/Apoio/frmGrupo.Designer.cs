namespace ControlaEstoque
{
    partial class frmGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupo));
            this.pnlGrupo = new System.Windows.Forms.Panel();
            this.dtgGrupo = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProdutoLimpar = new System.Windows.Forms.Button();
            this.Descricao = new System.Windows.Forms.Label();
            this.btnCadastrarGrupo = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.pnlGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrupo
            // 
            this.pnlGrupo.BackColor = System.Drawing.Color.Transparent;
            this.pnlGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrupo.Controls.Add(this.dtgGrupo);
            this.pnlGrupo.Controls.Add(this.btnSair);
            this.pnlGrupo.Controls.Add(this.btnProdutoLimpar);
            this.pnlGrupo.Controls.Add(this.Descricao);
            this.pnlGrupo.Controls.Add(this.btnCadastrarGrupo);
            this.pnlGrupo.Controls.Add(this.txtDescricao);
            this.pnlGrupo.Location = new System.Drawing.Point(12, 16);
            this.pnlGrupo.Name = "pnlGrupo";
            this.pnlGrupo.Size = new System.Drawing.Size(355, 237);
            this.pnlGrupo.TabIndex = 0;
            // 
            // dtgGrupo
            // 
            this.dtgGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGrupo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrupo.Location = new System.Drawing.Point(15, 13);
            this.dtgGrupo.Name = "dtgGrupo";
            this.dtgGrupo.ReadOnly = true;
            this.dtgGrupo.Size = new System.Drawing.Size(321, 105);
            this.dtgGrupo.TabIndex = 2;
            this.dtgGrupo.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(281, 201);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProdutoLimpar
            // 
            this.btnProdutoLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProdutoLimpar.Location = new System.Drawing.Point(15, 201);
            this.btnProdutoLimpar.Name = "btnProdutoLimpar";
            this.btnProdutoLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnProdutoLimpar.TabIndex = 5;
            this.btnProdutoLimpar.Text = "Limpar";
            this.btnProdutoLimpar.UseVisualStyleBackColor = true;
            this.btnProdutoLimpar.Click += new System.EventHandler(this.btnProdutoLimpar_Click);
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(146, 133);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(58, 13);
            this.Descricao.TabIndex = 3;
            this.Descricao.Text = "Descrição:";
            // 
            // btnCadastrarGrupo
            // 
            this.btnCadastrarGrupo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadastrarGrupo.Font = new System.Drawing.Font("Papyrus", 10.75F);
            this.btnCadastrarGrupo.Location = new System.Drawing.Point(87, 189);
            this.btnCadastrarGrupo.Name = "btnCadastrarGrupo";
            this.btnCadastrarGrupo.Size = new System.Drawing.Size(176, 36);
            this.btnCadastrarGrupo.TabIndex = 4;
            this.btnCadastrarGrupo.Text = "Cadastrar Grupo";
            this.btnCadastrarGrupo.UseVisualStyleBackColor = true;
            this.btnCadastrarGrupo.Click += new System.EventHandler(this.btnCadastrarGrupo_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 149);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(321, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(20, 7);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(125, 16);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "Cadastro de Grupo:";
            // 
            // frmGrupo
            // 
            this.AcceptButton = this.btnCadastrarGrupo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(379, 265);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.pnlGrupo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.pnlGrupo.ResumeLayout(false);
            this.pnlGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrupo;
        private System.Windows.Forms.Button btnProdutoLimpar;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.Button btnCadastrarGrupo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dtgGrupo;
    }
}