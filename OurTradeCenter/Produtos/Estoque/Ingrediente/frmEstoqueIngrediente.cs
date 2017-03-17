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
    public partial class frmEstoqueIngrediente : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmEstoqueIngrediente()
        {
            InitializeComponent();

            txtIngrediente.Text = frmVisualizarEstIngrediente.EstNomeIng;
            txtQuantidade.Text = frmVisualizarEstIngrediente.EstQuantidadeIng;
            cbxMedida.Text = frmVisualizarEstIngrediente.EstMedidaIng;
            txtQuantidade.Focus();
        }

        private void Limpar()
        {
            txtIngrediente.Text = frmVisualizarEstIngrediente.EstNomeIng;
            txtQuantidade.Text = frmVisualizarEstIngrediente.EstQuantidadeIng;
            cbxMedida.Text = frmVisualizarEstIngrediente.EstMedidaIng;
            txtQuantidade.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnAlterarEstoqueIngrediente_Click(object sender, EventArgs e)
        {
            if (txtIngrediente.Text != "" && txtQuantidade.Text != "" && cbxMedida.Text != "")
            {
                string dataAtual = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");

                Sql = "CALL SP_Update_EstIngrediente(" + txtQuantidade.Text + ", '" + dataAtual + "', '" + txtIngrediente.Text + "', '" + cbxMedida.Text + "')";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Estoque do ingrediente '" + txtIngrediente.Text + "', alterado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
