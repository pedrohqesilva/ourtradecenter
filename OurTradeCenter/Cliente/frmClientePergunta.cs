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
    public partial class frmClientePergunta : Form
    {
        public static string Tipo;

        public frmClientePergunta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tipo = "Inserir";

            frmCliente CadCliente = new frmCliente();
            CadCliente.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tipo = "Alterar";

            frmPesquisaCliente PesqCliente = new frmPesquisaCliente();
            PesqCliente.Show();
            this.Close();
        }
    }
}
