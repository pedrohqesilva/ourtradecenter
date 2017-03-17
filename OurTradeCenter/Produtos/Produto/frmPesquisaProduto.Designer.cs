namespace ControlaEstoque
{
    partial class frmPesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProduto));
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColunaCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgProduto
            // 
            this.dtgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaCod,
            this.ColunaNome,
            this.ColunaCusto,
            this.ColunaValor,
            this.ColunaGrupo});
            this.dtgProduto.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dtgProduto.Location = new System.Drawing.Point(15, 48);
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.Size = new System.Drawing.Size(674, 316);
            this.dtgProduto.TabIndex = 1;
            this.dtgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduto_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos Cadastrados:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 381);
            this.panel1.TabIndex = 3;
            // 
            // ColunaCod
            // 
            this.ColunaCod.FillWeight = 75F;
            this.ColunaCod.HeaderText = "Cod. Produto";
            this.ColunaCod.Name = "ColunaCod";
            this.ColunaCod.ReadOnly = true;
            // 
            // ColunaNome
            // 
            this.ColunaNome.FillWeight = 150F;
            this.ColunaNome.HeaderText = "Nome do Produto";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.ReadOnly = true;
            // 
            // ColunaCusto
            // 
            this.ColunaCusto.FillWeight = 85F;
            this.ColunaCusto.HeaderText = "Custo de Prod.";
            this.ColunaCusto.Name = "ColunaCusto";
            this.ColunaCusto.ReadOnly = true;
            // 
            // ColunaValor
            // 
            this.ColunaValor.FillWeight = 85F;
            this.ColunaValor.HeaderText = "Valor de Venda";
            this.ColunaValor.Name = "ColunaValor";
            this.ColunaValor.ReadOnly = true;
            // 
            // ColunaGrupo
            // 
            this.ColunaGrupo.HeaderText = "Grupo";
            this.ColunaGrupo.Name = "ColunaGrupo";
            this.ColunaGrupo.ReadOnly = true;
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 405);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.Activated += new System.EventHandler(this.frmPesquisaProduto_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaGrupo;
    }
}