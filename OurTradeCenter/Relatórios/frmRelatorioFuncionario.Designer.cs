namespace ControlaEstoque
{
    partial class frmRelatorioFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioFuncionario));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ourtradecenterDataSet = new ControlaEstoque.ourtradecenterDataSet();
            this.relatoriofuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatoriofuncionarioTableAdapter = new ControlaEstoque.ourtradecenterDataSetTableAdapters.relatoriofuncionarioTableAdapter();
            this.relatoriovendafuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatoriovendafuncionarioTableAdapter = new ControlaEstoque.ourtradecenterDataSetTableAdapters.relatoriovendafuncionarioTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relatorioqntdvendafuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioqntdvendafuncionarioTableAdapter = new ControlaEstoque.ourtradecenterDataSetTableAdapters.relatorioqntdvendafuncionarioTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ourtradecenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriofuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendafuncionarioBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioqntdvendafuncionarioBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RelatorioFuncionario";
            reportDataSource1.Value = this.relatoriofuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControlaEstoque.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(17, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(643, 193);
            this.reportViewer1.TabIndex = 0;
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
            reportDataSource2.Name = "RelatorioVendaFuncionario";
            reportDataSource2.Value = this.relatoriovendafuncionarioBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ControlaEstoque.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(17, 19);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(643, 201);
            this.reportViewer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vendas realizadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Funcionários cadastrados:";
            // 
            // ourtradecenterDataSet
            // 
            this.ourtradecenterDataSet.DataSetName = "ourtradecenterDataSet";
            this.ourtradecenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatoriofuncionarioBindingSource
            // 
            this.relatoriofuncionarioBindingSource.DataMember = "relatoriofuncionario";
            this.relatoriofuncionarioBindingSource.DataSource = this.ourtradecenterDataSet;
            // 
            // relatoriofuncionarioTableAdapter
            // 
            this.relatoriofuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // relatoriovendafuncionarioBindingSource
            // 
            this.relatoriovendafuncionarioBindingSource.DataMember = "relatoriovendafuncionario";
            this.relatoriovendafuncionarioBindingSource.DataSource = this.ourtradecenterDataSet;
            // 
            // relatoriovendafuncionarioTableAdapter
            // 
            this.relatoriovendafuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quantidade de vendas por funcionário:";
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
            reportDataSource3.Name = "RelatorioQntdVenda";
            reportDataSource3.Value = this.relatorioqntdvendafuncionarioBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "ControlaEstoque.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(17, 19);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(643, 197);
            this.reportViewer3.TabIndex = 0;
            // 
            // relatorioqntdvendafuncionarioBindingSource
            // 
            this.relatorioqntdvendafuncionarioBindingSource.DataMember = "relatorioqntdvendafuncionario";
            this.relatorioqntdvendafuncionarioBindingSource.DataSource = this.ourtradecenterDataSet;
            // 
            // relatorioqntdvendafuncionarioTableAdapter
            // 
            this.relatorioqntdvendafuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "Relatório de Funcionários:";
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
            this.panel4.Location = new System.Drawing.Point(12, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 787);
            this.panel4.TabIndex = 28;
            // 
            // frmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 824);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OurTradeCenter";
            this.Load += new System.EventHandler(this.frmRelatorioFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ourtradecenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriofuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatoriovendafuncionarioBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.relatorioqntdvendafuncionarioBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource relatoriofuncionarioBindingSource;
        private ourtradecenterDataSet ourtradecenterDataSet;
        private ourtradecenterDataSetTableAdapters.relatoriofuncionarioTableAdapter relatoriofuncionarioTableAdapter;
        private System.Windows.Forms.BindingSource relatoriovendafuncionarioBindingSource;
        private ourtradecenterDataSetTableAdapters.relatoriovendafuncionarioTableAdapter relatoriovendafuncionarioTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource relatorioqntdvendafuncionarioBindingSource;
        private ourtradecenterDataSetTableAdapters.relatorioqntdvendafuncionarioTableAdapter relatorioqntdvendafuncionarioTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
    }
}