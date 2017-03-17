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
    public partial class frmIngredienteMenu : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmIngredienteMenu()
        {
            InitializeComponent();

            lblNome.Text = frmPesquisaIngredientes.NomeIngrediente;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmIngredientePergunta.Tipo = "Alterar";

            frmIngrediente Ingrediente = new frmIngrediente();
            Ingrediente.ShowDialog();
            this.Close(); 
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Sql = "CALL SP_Delete_Ingredientes('" + frmPesquisaIngredientes.IDIngrediente + "')";
            BD.ExecutarComandos(Sql);

            MessageBox.Show("Ingrediente '" + frmPesquisaIngredientes.NomeIngrediente + "', excluido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
