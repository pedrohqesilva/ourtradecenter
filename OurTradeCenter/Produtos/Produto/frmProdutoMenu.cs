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
    public partial class frmProdutoMenu : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmProdutoMenu()
        {
            InitializeComponent();

            lblNome.Text = frmPesquisaProduto.NomeProduto;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmProdutoPergunta.Tipo = "Alterar";

            frmProduto Produto = new frmProduto();
            Produto.ShowDialog();
            this.Close(); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Sql = "CALL SP_Delete_Produto('" + frmPesquisaProduto.IDProduto + "')";
            BD.ExecutarComandos(Sql);

            MessageBox.Show("Produto '" + frmPesquisaProduto.NomeProduto + "', excluido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
