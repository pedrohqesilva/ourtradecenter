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
    public partial class frmClienteMenu : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmClienteMenu()
        {
            InitializeComponent();

            lblNome.Text = frmPesquisaCliente.NomeCliente;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {            
            frmClientePergunta.Tipo = "Alterar";
     
            frmCliente Cliente = new frmCliente();
            Cliente.ShowDialog();
            this.Close();            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Sql = "DELETE FROM cliente WHERE id = " + frmPesquisaCliente.IDCliente;
            BD.ExecutarComandos(Sql);

            MessageBox.Show("Cliente '" + frmPesquisaCliente.NomeCliente + "', excluido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }        
    }
}
