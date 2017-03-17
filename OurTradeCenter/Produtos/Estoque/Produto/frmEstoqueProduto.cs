using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControlaEstoque
{
    public partial class frmEstoqueProduto : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmEstoqueProduto()
        {
            InitializeComponent();

            txtProduto.Text = frmVisualizarEstProduto.EstNome;
            txtQuantidade.Text = frmVisualizarEstProduto.EstQuantidade;
            cbxMedida.Text = frmVisualizarEstProduto.EstMedida;
            txtQuantidade.Focus();
        }        

        private void Limpar()
        {
            txtQuantidade.Text = frmVisualizarEstProduto.EstQuantidade;
            cbxMedida.Text = frmVisualizarEstProduto.EstMedida;
            txtQuantidade.Focus();

            cbxMedida.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnAlterarEstoqueProduto_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text != "" && txtQuantidade.Text != "" && cbxMedida.Text != "")
            {
                string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

                Sql = "CALL SP_Update_EstProduto(" + txtQuantidade.Text + ", '" + dataAtual + "', '" + txtProduto.Text + "', '" + cbxMedida.Text + "')";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Estoque do produto '" + txtProduto.Text + "', alterado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
