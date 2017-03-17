namespace ControlaEstoque
{
    partial class frmPesquisaIngredientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaIngredientes));
            this.dtgIngrediente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaIngrediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngrediente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgIngrediente
            // 
            this.dtgIngrediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIngrediente.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngrediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaId,
            this.ColunaIngrediente,
            this.ColunaMedida,
            this.ColunaCusto});
            this.dtgIngrediente.Location = new System.Drawing.Point(15, 48);
            this.dtgIngrediente.Name = "dtgIngrediente";
            this.dtgIngrediente.Size = new System.Drawing.Size(674, 316);
            this.dtgIngrediente.TabIndex = 1;
            this.dtgIngrediente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIngrediente_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredientes Cadastrados:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgIngrediente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 381);
            this.panel1.TabIndex = 3;
            // 
            // ColunaId
            // 
            this.ColunaId.FillWeight = 75F;
            this.ColunaId.HeaderText = "Cod. Ingrediente";
            this.ColunaId.Name = "ColunaId";
            this.ColunaId.ReadOnly = true;
            // 
            // ColunaIngrediente
            // 
            this.ColunaIngrediente.FillWeight = 150F;
            this.ColunaIngrediente.HeaderText = "Descricao do Ingrediente";
            this.ColunaIngrediente.Name = "ColunaIngrediente";
            this.ColunaIngrediente.ReadOnly = true;
            // 
            // ColunaMedida
            // 
            this.ColunaMedida.HeaderText = "Medida";
            this.ColunaMedida.Name = "ColunaMedida";
            this.ColunaMedida.ReadOnly = true;
            // 
            // ColunaCusto
            // 
            this.ColunaCusto.FillWeight = 75F;
            this.ColunaCusto.HeaderText = "Custo";
            this.ColunaCusto.Name = "ColunaCusto";
            this.ColunaCusto.ReadOnly = true;
            // 
            // frmPesquisaIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 405);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisaIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.Activated += new System.EventHandler(this.frmPesquisaIngredientes_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngrediente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaIngrediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCusto;
    }
}