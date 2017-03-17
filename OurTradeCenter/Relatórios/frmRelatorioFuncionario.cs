using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaEstoque
{
    public partial class frmRelatorioFuncionario : Form
    {
        public frmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        private void frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ourtradecenterDataSet.relatorioqntdvendafuncionario' table. You can move, or remove it, as needed.
            this.relatorioqntdvendafuncionarioTableAdapter.Fill(this.ourtradecenterDataSet.relatorioqntdvendafuncionario);
            // TODO: This line of code loads data into the 'ourtradecenterDataSet.relatoriovendafuncionario' table. You can move, or remove it, as needed.
            this.relatoriovendafuncionarioTableAdapter.Fill(this.ourtradecenterDataSet.relatoriovendafuncionario);
            // TODO: This line of code loads data into the 'ourtradecenterDataSet.relatoriofuncionario' table. You can move, or remove it, as needed.
            this.relatoriofuncionarioTableAdapter.Fill(this.ourtradecenterDataSet.relatoriofuncionario);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
