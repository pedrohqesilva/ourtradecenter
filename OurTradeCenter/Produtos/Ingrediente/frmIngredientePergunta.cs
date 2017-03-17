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
    public partial class frmIngredientePergunta : Form
    {
        public static string Tipo;

        public frmIngredientePergunta()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Tipo = "Inserir";

            frmIngrediente CadIngrediente = new frmIngrediente();
            CadIngrediente.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {            
            Tipo = "Alterar";

            frmPesquisaIngredientes PesqIngrediente = new frmPesquisaIngredientes();
            PesqIngrediente.Show();
            this.Close();            
        }
    }
}
