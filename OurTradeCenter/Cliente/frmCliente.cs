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
    public partial class frmCliente : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        Brasil Brasil = new Brasil();

        string Sql;
        string stringID;
        bool EstadoTeste = false;
        
        public frmCliente()
        {
            InitializeComponent();
            Estado();            
            
            stringID = frmPesquisaCliente.IDCliente;

            #region Iniciar no tipo de Alterar
            if (frmClientePergunta.Tipo == "Alterar")
            {
                DataTable PesquisaCliente = new DataTable();
                PesquisaCliente = BD.ExecutarConsultas("SELECT * FROM cliente where id = " + stringID);

                mskTelefone.Text = PesquisaCliente.Rows[0]["telefone"].ToString();
                txtNome.Text = PesquisaCliente.Rows[0]["nome"].ToString();
                txtEmail.Text = PesquisaCliente.Rows[0]["email"].ToString();
                mskDataNascimento.Text = PesquisaCliente.Rows[0]["nascimento"].ToString();
                mskCpf.Text = PesquisaCliente.Rows[0]["cpf"].ToString();

                string Sexo = PesquisaCliente.Rows[0]["sexo"].ToString();

                if (Sexo == "M") 
                    rdbMasc.Checked = true; 
                else
                    rdbFem.Checked = true;

                cbxEstado.Text = PesquisaCliente.Rows[0]["uf"].ToString();
                mskCep.Text = PesquisaCliente.Rows[0]["cep"].ToString();
                cbxCidade.Text = PesquisaCliente.Rows[0]["cidade"].ToString();
                txtLogradouro.Text = PesquisaCliente.Rows[0]["logradouro"].ToString();
                txtNumero.Text = PesquisaCliente.Rows[0]["numero"].ToString();
                txtComplemento.Text = PesquisaCliente.Rows[0]["complemento"].ToString();
                txtBairro.Text = PesquisaCliente.Rows[0]["bairro"].ToString();

                btnCadastrarClinte.Text = "Alterar Cliente";
            }
            #endregion
        }

        private void Estado()
        {
            Sql = "SELECT * FROM estado";

            cbxEstado.DataSource = Brasil.ExecutarConsultas(Sql);
            cbxEstado.ValueMember = "sigla";
            cbxEstado.DisplayMember = "nome";

            cbxEstado.Text = "Minas Gerais";
            cbxEstado.Focus();

            EstadoTeste = true;
            Cidades();
            
        }

        private void Cidades()
        {
            if (EstadoTeste == true)
            {
                Sql = "SELECT * FROM cidade WHERE uf = '" + (cbxEstado.SelectedIndex + 1) + "' ORDER BY nome ASC";

                cbxCidade.DataSource = Brasil.ExecutarConsultas(Sql);
                cbxCidade.ValueMember = "nome";
                cbxCidade.DisplayMember = "nome";

                cbxCidade.SelectedIndex = -1;
                cbxCidade.Focus();

                if (cbxEstado.Text == "Minas Gerais")
                    cbxCidade.Text = "Belo Horizonte";
            }
        }

        private void Limpar()
        {
            mskTelefone.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            mskDataNascimento.Text = "";
            mskCpf.Text = "";

            rdbMasc.Checked = false;
            rdbFem.Checked = false;

            cbxEstado.Text = "MG - Minas Gerais";
            mskCep.Text = "";
            cbxCidade.Text = "Belo Horizonte";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
        }

        private void Mensagem(string Msg)
        {
            MessageBox.Show(Msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnCadastrarClinte_Click(object sender, EventArgs e)
        {
            string Nome = frmCartao.Nome;
            string CodCartao = frmCartao.CodCartao;
            string Validade = frmCartao.Validade;
            string Bandeira = frmCartao.Bandeira;
            string CodSeg = frmCartao.CodSeguranca;

            if (frmClientePergunta.Tipo == "Inserir")
            {
                #region Inserir
                string Complemento = txtComplemento.Text == "" ? "null" : txtComplemento.Text;
                string Sexo = rdbMasc.Checked ? "M" : rdbFem.Checked ? "F" : "";

                #region Teste de preenchimento obrigatorio
                if (mskTelefone.Text == "" || mskTelefone.Text.Length < 10)
                {
                    Mensagem("Porfavor insira o telefone.");
                    mskTelefone.Focus(); 
                    return;
                }
                if (txtNome.Text == "" || txtNome.Text.Length < 4) 
                {
                    Mensagem("Porfavor insira o nome.\nDeve conter ao menos 4 caracteres.");
                    txtNome.Focus(); 
                    return;
                }
                if (txtEmail.Text == "" || txtEmail.Text.Length < 4)
                {
                    Mensagem("Porfavor insira o e-mail.");
                    txtEmail.Focus(); 
                    return; 
                }
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    Mensagem("E-mail deve conter '@' e '.'");
                    txtEmail.Focus();
                    return;
                }
                if (mskDataNascimento.Text == "" || mskDataNascimento.Text.Length != 10)
                {
                    Mensagem("Porfavor insira a data de nascimento.");
                    mskDataNascimento.Focus();
                    return;
                }
                if (mskCpf.Text == "" || mskCpf.Text.Length != 11) 
                {
                    Mensagem("Porfavor insira o CPF.");
                    return; 
                }
                if (rdbMasc.Checked == false && rdbFem.Checked == false)
                {
                    Mensagem("Porfavor insira o sexo.");
                    rdbMasc.Focus();
                    return;
                }
                if (mskCep.Text == "" || mskCep.Text.Length != 8)
                {
                    Mensagem("Porfavor insira o CEP.");
                    mskCep.Focus();
                    return;
                }
                if (txtLogradouro.Text == "" || txtLogradouro.Text.Length < 5)
                { 
                    Mensagem("Porfavor insira o Logradouro.");
                    txtLogradouro.Focus();
                    return; 
                }
                if (txtNumero.Text == "")
                { 
                    Mensagem("Porfavor insira o número.");
                    txtNumero.Focus();
                    return;
                }
                if (txtBairro.Text == "" || txtBairro.Text.Length < 5) 
                {
                    Mensagem("Porfavor insira o bairro.");
                    txtBairro.Focus(); 
                    return;
                }
                #endregion

                string DataNascimento = (Convert.ToDateTime(mskDataNascimento.Text)).ToString("yyyy-MM-dd");

                #region Sem Cartão
                if (frmCartao.Tipo == "Normal")
                {
                    Sql = "CALL SP_Insert_Cliente('" + txtNome.Text + "', '" + mskCpf.Text + "', '" + DataNascimento;
                    Sql += "', '" + Sexo + "', '" + mskTelefone.Text + "', '" + txtEmail.Text;
                    Sql += "', '" + txtLogradouro.Text + "', " + txtNumero.Text + ", " + Complemento + ", '" + txtBairro.Text;
                    Sql += "', '" + cbxCidade.Text + "', '" + cbxEstado.Text + "', '" + mskCep.Text + "')";
                    BD.ExecutarComandos(Sql);
                }
                #endregion
                #region Com Cartão
                else if (frmCartao.Tipo == "Cartão")
                {
                    Sql = "CALL SP_Insert_ClienteCartao('" + txtNome.Text + "', '" + mskCpf.Text + "', '" + DataNascimento;
                    Sql += "', '" + Sexo + "', '" + mskTelefone.Text + "', '" + txtEmail.Text;
                    Sql += "', '" + txtLogradouro.Text + "', " + txtNumero.Text + ", " + Complemento + ", '" + txtBairro.Text;
                    Sql += "', '" + cbxCidade.Text + "', '" + cbxEstado.Text + "', '" + mskCep.Text + "', '" + Nome;
                    Sql += "', '" + CodCartao + "', '" + Validade + "', '" + Bandeira + "', '" + CodSeg + "')";
                    BD.ExecutarComandos(Sql);
                }
                #endregion

                MessageBox.Show("Cliente '" + txtNome.Text + "', inserido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpar();

                #endregion
            }

            else if (frmClientePergunta.Tipo == "Alterar")
            {
                #region Alterar
                string Complemento = txtComplemento.Text == "" ? "null" : txtComplemento.Text;
                string Sexo = rdbMasc.Checked ? "M" : rdbFem.Checked ? "F" : "";

                #region Teste de preenchimento obrigatorio
                if (mskTelefone.Text == "" || mskTelefone.Text.Length < 10)
                {
                    Mensagem("Porfavor insira o telefone.");
                    mskTelefone.Focus(); 
                    return;
                }
                if (txtNome.Text == "" || txtNome.Text.Length < 4) 
                {
                    Mensagem("Porfavor insira o nome.\nDeve conter ao menos 4 caracteres.");
                    txtNome.Focus(); 
                    return;
                }
                if (txtEmail.Text == "" || txtEmail.Text.Length < 4)
                {
                    Mensagem("Porfavor insira o e-mail.");
                    txtEmail.Focus(); 
                    return; 
                }
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    Mensagem("E-mail deve conter '@' e '.'");
                    txtEmail.Focus();
                    return;
                }
                if (mskDataNascimento.Text == "" || mskDataNascimento.Text.Length != 10)
                {
                    Mensagem("Porfavor insira a data de nascimento.");
                    mskDataNascimento.Focus();
                    return;
                }
                if (mskCpf.Text == "" || mskCpf.Text.Length != 11) 
                {
                    Mensagem("Porfavor insira o CPF.");
                    return; 
                }
                if (rdbMasc.Checked == false && rdbFem.Checked == false)
                {
                    Mensagem("Porfavor insira o sexo.");
                    rdbMasc.Focus();
                    return;
                }
                if (mskCep.Text == "" || mskCep.Text.Length != 8)
                {
                    Mensagem("Porfavor insira o CEP.");
                    mskCep.Focus();
                    return;
                }
                if (txtLogradouro.Text == "" || txtLogradouro.Text.Length < 5)
                { 
                    Mensagem("Porfavor insira o Logradouro.");
                    txtLogradouro.Focus();
                    return; 
                }
                if (txtNumero.Text == "")
                { 
                    Mensagem("Porfavor insira o número.");
                    txtNumero.Focus();
                    return;
                }
                if (txtBairro.Text == "" || txtBairro.Text.Length < 5) 
                {
                    Mensagem("Porfavor insira o bairro.");
                    txtBairro.Focus(); 
                    return;
                }
                #endregion  
                                    
                string DataNascimento = (Convert.ToDateTime(mskDataNascimento.Text)).ToString("yyyy-MM-dd");

                Sql = "CALL SP_Update_Cliente('" + stringID + "', '" + txtNome.Text + "', '" + mskCpf.Text + "', '" + DataNascimento;
                Sql += "', '" + Sexo + "', '" + mskTelefone.Text + "', '" + txtEmail.Text;
                Sql += "', '" + txtLogradouro.Text + "', " + txtNumero.Text + ", " + Complemento + ", '" + txtBairro.Text;
                Sql += "', '" + cbxCidade.Text + "', '" + cbxEstado.Text + "', '" + mskCep.Text + "', '" + Nome;
                Sql += "', '" + CodCartao + "', '" + Validade + "', '" + Bandeira + "', '" + CodSeg + "')";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Cliente '" + txtNome.Text + "', alterado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpar();
                this.Close();

                #endregion
            }
        }                

        private void btnCartao_Click(object sender, EventArgs e)
        {
            frmCartao Cartao = new frmCartao();
            Cartao.ShowDialog();
        }

        private void cbxEstado_TextChanged(object sender, EventArgs e)
        {
            Cidades();
        }

        private void SomenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
