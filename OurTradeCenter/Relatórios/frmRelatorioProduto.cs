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
    public partial class frmRelatorioProduto : Form
    {
        public frmRelatorioProduto()
        {
            InitializeComponent();
        }

        private void frmRelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ourtradecenterDataSet.relatorioprodutovendidoultimos30dias' table. You can move, or remove it, as needed.
            this.relatorioprodutovendidoultimos30diasTableAdapter.Fill(this.ourtradecenterDataSet.relatorioprodutovendidoultimos30dias);
            // TODO: This line of code loads data into the 'ourtradecenterDataSet.relatorioprodutosmenosvendidos' table. You can move, or remove it, as needed.
            this.relatorioprodutosmenosvendidosTableAdapter.Fill(this.ourtradecenterDataSet.relatorioprodutosmenosvendidos);
            // TODO: This line of code loads data into the 'ourtradecenterDataSet.relatorioprodutosmaisvendidos' table. You can move, or remove it, as needed.
            this.relatorioprodutosmaisvendidosTableAdapter.Fill(this.ourtradecenterDataSet.relatorioprodutosmaisvendidos);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
