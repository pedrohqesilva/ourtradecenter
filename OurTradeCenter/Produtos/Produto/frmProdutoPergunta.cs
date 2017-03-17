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
    public partial class frmProdutoPergunta : Form
    {
        public static string Tipo = "Inserir";

        public frmProdutoPergunta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tipo = "Inserir";

            frmProduto CadProduto = new frmProduto();
            CadProduto.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tipo = "Alterar";

            frmPesquisaProduto PesqProduto = new frmPesquisaProduto();
            PesqProduto.Show();
            this.Close();
        }
    }
}
