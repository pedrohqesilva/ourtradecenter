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
    public partial class frmMenuGerente : Form
    {
        public frmMenuGerente()
        {
            InitializeComponent();

            btnSair.BackgroundImage = new Bitmap(@"..\..\..\Portas\Porta1.png");
            btnFuncionario.BackgroundImage = new Bitmap(@"C:\Users\pedri\Desktop\Projeto Interdisciplinar\Imagens\Botoes\AdicionarFuncionario.png");
            btnNovoProduto.BackgroundImage = new Bitmap(@"C:\Users\pedri\Desktop\Projeto Interdisciplinar\Imagens\Botoes\AdicionarIngrediente.png");
            btnNovoIngrediente.BackgroundImage = new Bitmap(@"C:\Users\pedri\Desktop\Projeto Interdisciplinar\Imagens\Botoes\AdicionarProdutoAdm.png");
            btnRelatorioFuncionario.BackgroundImage = new Bitmap(@"C:\Users\pedri\Desktop\Projeto Interdisciplinar\Imagens\Botoes\RelatorioFuncionario.png");
            btnRelatorioProduto.BackgroundImage = new Bitmap(@"C:\Users\pedri\Desktop\Projeto Interdisciplinar\Imagens\Botoes\RelatorioProdutos.png");
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?", "OurTradeCenter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmFuncionarioPergunta PergFunc = new frmFuncionarioPergunta();
            PergFunc.Show();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmIngredientePergunta PergIng = new frmIngredientePergunta();
            PergIng.Show();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmProduto.dtgClick = "";

            frmProdutoPergunta PergProd = new frmProdutoPergunta();
            PergProd.Show();
        }

        private void btnRelatorioFuncionario_Click(object sender, EventArgs e)
        {
            frmRelatorioFuncionario RelatorioFuncionario = new frmRelatorioFuncionario();
            RelatorioFuncionario.Show();
        }

        private void btnRelatorioProduto_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto RelatorioProduto = new frmRelatorioProduto();
            RelatorioProduto.Show();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = new Bitmap(@"..\..\..\Portas\Porta2.png");
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = new Bitmap(@"..\..\..\Portas\Porta1.png");
        }
    }
}
