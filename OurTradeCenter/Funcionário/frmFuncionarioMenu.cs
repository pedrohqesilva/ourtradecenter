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
    public partial class frmFuncionarioMenu : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmFuncionarioMenu()
        {
            InitializeComponent();

            lblNome.Text = frmPesquisaFuncionario.NomeFuncionario;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmFuncionarioPergunta.Tipo = "Alterar";

            frmFuncionario Funcionario = new frmFuncionario();
            Funcionario.ShowDialog();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Sql = "DELETE FROM funcionario WHERE id = " + frmPesquisaFuncionario.IDFuncionario;
            BD.ExecutarComandos(Sql);

            MessageBox.Show("Funcionário '" + frmPesquisaFuncionario.NomeFuncionario + "', excluido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
