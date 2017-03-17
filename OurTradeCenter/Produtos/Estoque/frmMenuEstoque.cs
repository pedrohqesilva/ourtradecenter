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
    public partial class frmEstoqueMenu : Form
    {
        public frmEstoqueMenu()
        {
            InitializeComponent();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmVisualizarEstProduto EstProduto = new frmVisualizarEstProduto();
            EstProduto.Show();
            this.Close();
        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            frmVisualizarEstIngrediente EstIngrediente = new frmVisualizarEstIngrediente();
            EstIngrediente.Show();
            this.Close();
        }

    }
}
