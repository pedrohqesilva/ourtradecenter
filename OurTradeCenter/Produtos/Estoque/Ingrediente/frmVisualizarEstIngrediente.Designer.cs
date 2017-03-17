namespace ControlaEstoque
{
    partial class frmVisualizarEstIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarEstIngrediente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 381);
            this.panel1.TabIndex = 5;
            // 
            // dtgProduto
            // 
            this.dtgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaID,
            this.ColunaNome,
            this.ColunaQuantidade,
            this.ColunaMedida,
            this.ColunaData});
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
            this.label1.Location = new System.Drawing.Point(187, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque de Ingredientes:";
            // 
            // ColunaID
            // 
            this.ColunaID.FillWeight = 50F;
            this.ColunaID.HeaderText = "Cod.";
            this.ColunaID.Name = "ColunaID";
            this.ColunaID.ReadOnly = true;
            // 
            // ColunaNome
            // 
            this.ColunaNome.FillWeight = 200F;
            this.ColunaNome.HeaderText = "Descricao do Ingrediente";
            this.ColunaNome.Name = "ColunaNome";
            this.ColunaNome.ReadOnly = true;
            // 
            // ColunaQuantidade
            // 
            this.ColunaQuantidade.FillWeight = 50F;
            this.ColunaQuantidade.HeaderText = "Quantidade";
            this.ColunaQuantidade.Name = "ColunaQuantidade";
            this.ColunaQuantidade.ReadOnly = true;
            // 
            // ColunaMedida
            // 
            this.ColunaMedida.FillWeight = 75F;
            this.ColunaMedida.HeaderText = "Medida";
            this.ColunaMedida.Name = "ColunaMedida";
            this.ColunaMedida.ReadOnly = true;
            // 
            // ColunaData
            // 
            this.ColunaData.HeaderText = "Data de Modificação";
            this.ColunaData.Name = "ColunaData";
            this.ColunaData.ReadOnly = true;
            // 
            // frmVisualizarEstIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 402);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVisualizarEstIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.Activated += new System.EventHandler(this.frmVisualizarEstIngrediente_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaData;
    }
}