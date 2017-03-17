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
    public partial class frmFuncionarioPergunta : Form
    {
        public static string Tipo;

        public frmFuncionarioPergunta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tipo = "Inserir";

            frmFuncionario CadFuncionario = new frmFuncionario();
            CadFuncionario.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tipo = "Alterar";

            frmPesquisaFuncionario PesqFuncionario = new frmPesquisaFuncionario();
            PesqFuncionario.Show();
            this.Close();
        }
    }
}
