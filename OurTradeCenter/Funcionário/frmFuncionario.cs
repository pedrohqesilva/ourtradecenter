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
    public partial class frmFuncionario : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        Brasil Brasil = new Brasil();

        string Sql;
        string stringID;
        bool EstadoTeste = false;

        public frmFuncionario()
        {
            InitializeComponent();
            Estado(); 

            stringID = frmPesquisaFuncionario.IDFuncionario;
            #region Iniciar no tipo de Alterar
            if (frmFuncionarioPergunta.Tipo == "Alterar")
            {
                DataTable PesquisaCliente = new DataTable();
                PesquisaCliente = BD.ExecutarConsultas("SELECT * FROM funcionario where id = " + stringID);

                txtUsuario.Text = PesquisaCliente.Rows[0]["login"].ToString();
                txtSenha.Text = PesquisaCliente.Rows[0]["senha"].ToString();

                mskTelefone.Text = PesquisaCliente.Rows[0]["telefone"].ToString();
                txtNome.Text = PesquisaCliente.Rows[0]["nome"].ToString();
                txtEmail.Text = PesquisaCliente.Rows[0]["email"].ToString();
                mskDataNascimento.Text = PesquisaCliente.Rows[0]["nascimento"].ToString();
                mskCpf.Text = PesquisaCliente.Rows[0]["cpf"].ToString();
                cbxCargo.Text = PesquisaCliente.Rows[0]["cargo"].ToString();

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

                btnCadastrarFuncionario.Text = "Alterar Funcionário";

                cbxCargo.Enabled = false;
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
            cbxCargo.Text = "";

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
        
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (frmFuncionarioPergunta.Tipo == "Inserir")
            {
                #region Inserir
                string Complemento = txtComplemento.Text == "" ? "null" : txtComplemento.Text;
                string Sexo = rdbMasc.Checked ? "M" : rdbFem.Checked ? "F" : "";

                #region Teste de preenchimento obrigatorio
                if (txtUsuario.Text == "" || txtUsuario.Text.Length < 3)
                {
                    Mensagem("Porfavor insira o úsuario.\nDeve conter ao menos 4 caracteres.");
                    txtNome.Focus();
                    return;
                }
                if (txtSenha.Text == "" || txtSenha.Text.Length < 5)
                {
                    Mensagem("Porfavor insira a senha.\nDeve conter ao menos 6 caracteres.");
                    txtNome.Focus();
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
                if (mskTelefone.Text == "" || mskTelefone.Text.Length < 10)
                {
                    Mensagem("Porfavor insira o telefone.");
                    mskTelefone.Focus();
                    return;
                }
                if (cbxCargo.Text == "")
                {
                    Mensagem("Porfavor insira o cargo.");
                    cbxCargo.Focus();
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

                Sql = "CALL SP_Insert_Funcionario('" + txtNome.Text + "', '" + mskCpf.Text + "', '" + DataNascimento;
                Sql += "', '" + Sexo + "', '" + mskTelefone.Text + "', '" + txtEmail.Text + "', '" + cbxCargo.Text;
                Sql += "', '" + txtLogradouro.Text + "', " + txtNumero.Text + ", " + Complemento + ", '" + txtBairro.Text;
                Sql += "', '" + cbxCidade.Text + "', '" + cbxEstado.Text + "', '" + mskCep.Text + "', '" + txtUsuario.Text;
                Sql += "', '" + txtSenha.Text + "')";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Funcionário '" + txtNome.Text + "', inserido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                Limpar();
                #endregion
            }

            else if (frmFuncionarioPergunta.Tipo == "Alterar")
            {
                #region Alterar
                string Complemento = txtComplemento.Text == "" ? "null" : txtComplemento.Text;
                string Sexo = rdbMasc.Checked ? "M" : rdbFem.Checked ? "F" : "";

                #region Teste de preenchimento obrigatorio
                if (txtUsuario.Text == "" || txtUsuario.Text.Length < 3)
                {
                    Mensagem("Porfavor insira o úsuario.\nDeve conter ao menos 4 caracteres.");
                    txtNome.Focus();
                    return;
                }
                if (txtSenha.Text == "" || txtSenha.Text.Length < 5)
                {
                    Mensagem("Porfavor insira a senha.\nDeve conter ao menos 6 caracteres.");
                    txtNome.Focus();
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
                if (mskTelefone.Text == "" || mskTelefone.Text.Length < 10)
                {
                    Mensagem("Porfavor insira o telefone.");
                    mskTelefone.Focus();
                    return;
                }
                if (cbxCargo.Text == "")
                {
                    Mensagem("Porfavor insira o cargo.");
                    cbxCargo.Focus();
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

                Sql = "CALL SP_Update_Funcionario('" + stringID + "', '" + txtNome.Text + "', '" + mskCpf.Text + "', '" + DataNascimento;
                Sql += "', '" + Sexo + "', '" + mskTelefone.Text + "', '" + txtEmail.Text + "', '" + cbxCargo.Text;
                Sql += "', '" + txtLogradouro.Text + "', " + txtNumero.Text + ", " + Complemento + ", '" + txtBairro.Text;
                Sql += "', '" + cbxCidade.Text + "', '" + cbxEstado.Text + "', '" + mskCep.Text + "', '" + txtUsuario.Text;
                Sql += "', '" + txtSenha.Text + "')";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Funcionário '" + txtNome.Text + "', alterado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                Limpar();
                #endregion
            }
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
