namespace ControlaEstoque
{
    partial class frmRelatorioProduto
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioProduto));
            this.relatorioprodutovendidoultimos30diasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ourtradecenterDataSet = new ControlaEstoque.ourtradecenterDataSet();
            this.relatorioprodutosmaisvendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioprodutosmenosvendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorioqntdvendafuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatoriofuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatoriovendafuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioprodutosmaisvendidosTableAdapter = new ControlaEstoque.ourtradecenterDataSetTableAdapters.relatorioprodutosmaisvendidosTableAdapter();
            this.relatorioprodutosmenosvendidosTableAdapter = new ControlaEstoque.ourtradecenterDataSetTableAdapters.relatorioprodutosmenosvendidosTableAdapter();
            this.relatorioprodutovendidoultimos30diasTableAdapter = new ControlaEstoque.ourtradecenterDataSetTableAdapters.relatorioprodutovendidoultimos30diasTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioprodutovendidoultimos30diasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourtradecenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioprodutosmaisvendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioprodutosmenosvendidosBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioqntdvendafuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriofuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendafuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // relatorioprodutovendidoultimos30diasBindingSource
            // 
            this.relatorioprodutovendidoultimos30diasBindingSource.DataMember = "relatorioprodutovendidoultimos30dias";
            this.relatorioprodutovendidoultimos30diasBindingSource.DataSource = this.ourtradecenterDataSet;
            // 
            // ourtradecenterDataSet
            // 
            this.ourtradecenterDataSet.DataSetName = "ourtradecenterDataSet";
            this.ourtradecenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatorioprodutosmaisvendidosBindingSource
            // 
            this.relatorioprodutosmaisvendidosBindingSource.DataMember = "relatorioprodutosmaisvendidos";
            this.relatorioprodutosmaisvendidosBindingSource.DataSource = this.ourtradecenterDataSet;
            // 
            // relatorioprodutosmenosvendidosBindingSource
            // 
            this.relatorioprodutosmenosvendidosBindingSource.DataMember = "relatorioprodutosmenosvendidos";
            this.relatorioprodutosmenosvendidosBindingSource.DataSource = this.ourtradecenterDataSet;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(11, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 787);
            this.panel4.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantidade Vendida nos últimos 30 dias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Produtos menos vendidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Produtos mais vendidos:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.reportViewer3);
            this.panel1.Location = new System.Drawing.Point(13, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 236);
            this.panel1.TabIndex = 25;
            // 
            // reportViewer3
            // 
            reportDataSource1.Name = "RelatorioUltimos30Dias";
            reportDataSource1.Value = this.relatorioprodutovendidoultimos30diasBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ControlaEstoque.Report6.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(17, 19);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(643, 197);
            this.reportViewer3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(13, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 230);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.relatorioprodutosmaisvendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControlaEstoque.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 193);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.reportViewer2);
            this.panel3.Location = new System.Drawing.Point(13, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 236);
            this.panel3.TabIndex = 2;
            // 
            // reportViewer2
            // 
            reportDataSource3.Name = "RelatorioMenosVendido";
            reportDataSource3.Value = this.relatorioprodutosmenosvendidosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ControlaEstoque.Report5.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(17, 19);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(643, 201);
            this.reportViewer2.TabIndex = 0;
            // 
            // relatorioqntdvendafuncionarioBindingSource
            // 
            this.relatorioqntdvendafuncionarioBindingSource.DataMember = "relatorioqntdvendafuncionario";
            // 
            // relatoriofuncionarioBindingSource
            // 
            this.relatoriofuncionarioBindingSource.DataMember = "relatoriofuncionario";
            // 
            // relatoriovendafuncionarioBindingSource
            // 
            this.relatoriovendafuncionarioBindingSource.DataMember = "relatoriovendafuncionario";
            // 
            // relatorioprodutosmaisvendidosTableAdapter
            // 
            this.relatorioprodutosmaisvendidosTableAdapter.ClearBeforeFill = true;
            // 
            // relatorioprodutosmenosvendidosTableAdapter
            // 
            this.relatorioprodutosmenosvendidosTableAdapter.ClearBeforeFill = true;
            // 
            // relatorioprodutovendidoultimos30diasTableAdapter
            // 
            this.relatorioprodutovendidoultimos30diasTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "Relatório de Produtos:";
            // 
            // frmRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 827);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioProduto";
            this.Load += new System.EventHandler(this.frmRelatorioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioprodutovendidoultimos30diasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourtradecenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioprodutosmaisvendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioprodutosmenosvendidosBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioqntdvendafuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriofuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendafuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource relatorioqntdvendafuncionarioBindingSource;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource relatoriofuncionarioBindingSource;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource relatoriovendafuncionarioBindingSource;
        private System.Windows.Forms.BindingSource relatorioprodutosmaisvendidosBindingSource;
        private ourtradecenterDataSet ourtradecenterDataSet;
        private ourtradecenterDataSetTableAdapters.relatorioprodutosmaisvendidosTableAdapter relatorioprodutosmaisvendidosTableAdapter;
        private System.Windows.Forms.BindingSource relatorioprodutosmenosvendidosBindingSource;
        private ourtradecenterDataSetTableAdapters.relatorioprodutosmenosvendidosTableAdapter relatorioprodutosmenosvendidosTableAdapter;
        private System.Windows.Forms.BindingSource relatorioprodutovendidoultimos30diasBindingSource;
        private ourtradecenterDataSetTableAdapters.relatorioprodutovendidoultimos30diasTableAdapter relatorioprodutovendidoultimos30diasTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}