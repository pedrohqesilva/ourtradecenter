namespace ControlaEstoque
{
    partial class frmIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngrediente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrarIngrediente = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxMedida);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.txtCusto);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnCadastrarIngrediente);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblCusto);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 124);
            this.panel1.TabIndex = 0;
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
            this.cbxMedida.Location = new System.Drawing.Point(174, 48);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(157, 21);
            this.cbxMedida.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(276, 93);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(55, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(78, 48);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(90, 20);
            this.txtCusto.TabIndex = 6;
            this.txtCusto.Text = "R$ ";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(14, 93);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrarIngrediente
            // 
            this.btnCadastrarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.btnCadastrarIngrediente.Location = new System.Drawing.Point(85, 85);
            this.btnCadastrarIngrediente.Name = "btnCadastrarIngrediente";
            this.btnCadastrarIngrediente.Size = new System.Drawing.Size(175, 32);
            this.btnCadastrarIngrediente.TabIndex = 8;
            this.btnCadastrarIngrediente.Text = "Cadastrar Ingrediente";
            this.btnCadastrarIngrediente.UseVisualStyleBackColor = true;
            this.btnCadastrarIngrediente.Click += new System.EventHandler(this.btnCadastrarMedida_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(14, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(78, 22);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(253, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(14, 51);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(37, 13);
            this.lblCusto.TabIndex = 5;
            this.lblCusto.Text = "Custo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredientes:";
            // 
            // frmIngrediente
            // 
            this.AcceptButton = this.btnCadastrarIngrediente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnVoltar;
            this.ClientSize = new System.Drawing.Size(372, 155);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrarIngrediente;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbxMedida;
    }
}