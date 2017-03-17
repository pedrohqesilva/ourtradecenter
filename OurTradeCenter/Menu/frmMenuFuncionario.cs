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
    public partial class frmMenuFuncionario : Form
    {
        public frmMenuFuncionario()
        {
            InitializeComponent();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmMensagemPergunta.Tipo = "Inserir";
            frmPedido Pedido = new frmPedido();
            Pedido.Show();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {            
            frmClientePergunta PergCliente = new frmClientePergunta();
            PergCliente.Show();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmProduto Prod = new frmProduto();
            Prod.Show();
        }

        private void btnEstoques_Click(object sender, EventArgs e)
        {
            frmEstoqueMenu EstMenu = new frmEstoqueMenu();
            EstMenu.Show();
        }

        private void btnMensagens_Click(object sender, EventArgs e)
        {
            frmMensagem Mensagens = new frmMensagem();
            Mensagens.Show();
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin Login = new frmLogin();
            Login.Show();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = new Bitmap(@"..\..\..\Portas\Porta2.png");
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
                btnSair.BackgroundImage = new Bitmap(@"..\..\..\Portas\Porta1.png");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?", "OurTradeCenter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenuFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }      
    }
}
