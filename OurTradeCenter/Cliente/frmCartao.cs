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
    public partial class frmCartao : Form
    {
        public static string Tipo = "Normal", Nome, CodCartao, Validade, Bandeira, CodSeguranca;

        public frmCartao()
        {
            InitializeComponent();
        }

        private void Mensagem(string Msg)
        {
            MessageBox.Show(Msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtSalvar_Click(object sender, EventArgs e)
        {
            #region Teste de preenchimento obrigatorio           
            if (txtNome.Text == "" || txtNome.Text.Length < 4)
            {
                Mensagem("Porfavor insira o nome.\nDeve conter ao menos 4 caracteres.");
                txtNome.Focus();
                return;
            }
            if (mskCodCartao.Text == "" || mskCodCartao.Text.Length != 16)
            {
                Mensagem("Porfavor insira o código do cartão!");
                mskCodCartao.Focus();
                return;
            }
            if (mskValidade.Text == "" || mskValidade.Text.Length != 7)
            {
                Mensagem("Porfavor insira a data de validade.");
                mskValidade.Focus();
                return;
            }
            if (cbxBandeira.Text == "")
            {
                Mensagem("Porfavor insira a bandeira do cartão.");
                cbxBandeira.Focus();
                return;
            }
            if (mskCodSeguranca.Text == "" || mskCodSeguranca.Text.Length != 3)
            {
                Mensagem("Porfavor insira o código de segurança!");
                mskCodSeguranca.Focus();
                return;
            }
            #endregion

            Tipo = "Cartão";
            Nome = txtNome.Text;
            CodCartao = mskCodCartao.Text;
            Validade = mskValidade.Text;
            Bandeira = cbxBandeira.Text;
            CodSeguranca = mskCodSeguranca.Text;
           
            MessageBox.Show("Dados do cartão salvos com sucesso, continue o cadastro do cliente!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mskCodCartao.Text = "";
            mskValidade.Text = "";
            cbxBandeira.Text = "";
            mskCodSeguranca.Text = "";
        }
    }
}
