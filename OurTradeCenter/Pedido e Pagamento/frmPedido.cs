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
    public partial class frmPedido : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        Brasil Brasil = new Brasil();

        DataTable Consulta = new DataTable();
        string Sql;

        bool EstadoTeste = false;
        bool Auxiliar = false;

        string CodCliente;
        decimal ValorUni, ValorAtual, ValorTotal;

        string Produto, Obs, Valor, Qntd, Custo, TesteEst;

        public static string Pedido;
        public static string Telefone;
        public static string ValorPag;

        public frmPedido()
        {
            InitializeComponent();
            Entregar();
            Estado();

            CarregarDadosPedido();
        }

        private void Entregar()
        {
            if (chkEntregar.Checked == true)
            {
                pnlEndereco.Visible = true;
                lblEndereco.Visible = true;

                pnlCliente.Size = new System.Drawing.Size(468, 330);
                pnlItensPedido.Location = new Point(17, 383);
                lblItensPedido.Location = new Point(29, 374);

                pnlItensPedido.Size = new System.Drawing.Size(468, 273);
                dtgItensPedido.Size = new System.Drawing.Size(438, 146);
            }
            else
            {
                pnlEndereco.Visible = false;
                lblEndereco.Visible = false;

                pnlCliente.Size = new System.Drawing.Size(468, 122);
                pnlItensPedido.Location = new Point(17, 175);
                lblItensPedido.Location = new Point(29, 166);

                pnlItensPedido.Size = new System.Drawing.Size(468, 481);
                dtgItensPedido.Size = new System.Drawing.Size(438, 354);
            }
        }

        private void Estado()
        {
            Sql = "SELECT * FROM estado";

            cbxEstado.DataSource = Brasil.ExecutarConsultas(Sql);
            cbxEstado.ValueMember = "sigla";
            cbxEstado.DisplayMember = "nome";

            cbxEstado.SelectedIndex = -1;
            cbxEstado.Focus();

            EstadoTeste = true;
            Cidades();

        }

        private void TestarEstados(string Est)
        {
            switch (Est)
            {
                case "AC": cbxEstado.Text = "Acre"; break;
                case "AL": cbxEstado.Text = "Alagoas"; break;
                case "AP": cbxEstado.Text = "Amapá"; break;
                case "AM": cbxEstado.Text = "Amazonas"; break;
                case "BA": cbxEstado.Text = "Bahia"; break;
                case "CE": cbxEstado.Text = "Ceará"; break;
                case "DF": cbxEstado.Text = "Distrito Federal"; break;
                case "ES": cbxEstado.Text = "Espírito Santo"; break;
                case "GO": cbxEstado.Text = "Goiás"; break;
                case "MA": cbxEstado.Text = "Maranhão"; break;
                case "MT": cbxEstado.Text = "Mato Grosso"; break;
                case "MS": cbxEstado.Text = "Mato Grosso do Sul"; break;
                case "MG": cbxEstado.Text = "Minas Gerais"; break;
                case "PA": cbxEstado.Text = "Pará"; break;
                case "PB": cbxEstado.Text = "Paraíba"; break;
                case "PR": cbxEstado.Text = "Paraná"; break;
                case "PE": cbxEstado.Text = "Pernambuco"; break;
                case "PI": cbxEstado.Text = "Piauí"; break;
                case "RJ": cbxEstado.Text = "Rio de Janeiro"; break;
                case "RN": cbxEstado.Text = "Rio Grande do Norte"; break;
                case "RS": cbxEstado.Text = "Rio Grande do Sul"; break;
                case "RO": cbxEstado.Text = "Rondônia"; break;
                case "RR": cbxEstado.Text = "Roraima"; break;
                case "SC": cbxEstado.Text = "Santa Catarina"; break;
                case "SP": cbxEstado.Text = "São Paulo"; break;
                case "SE": cbxEstado.Text = "Sergipe"; break;
                case "TO": cbxEstado.Text = "Tocantins"; break;
            }
        }

        private void Cidades()
        {
            if (EstadoTeste == true)
            {
                Sql = "SELECT * FROM cidade WHERE uf = '" + (cbxEstado.SelectedIndex + 2) + "' ORDER BY nome ASC";

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
            Auxiliar = false;

            mskTelefone.Text = "";
            cbxCliente.DataSource = null;
            cbxCliente.SelectedIndex = -1;

            cbxCliente.Enabled = true;

            txtLogradouro.Text = ""; 
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            mskCep.Text = "";

            cbxProduto.Text = "Selecione o Produto";
            txtQuantidade.Text = "1";
            txtObservacoes.Text = "";
            txtValor.Text = "R$ 0";

            dtgItensPedido.Rows.Clear();
            cbxProduto.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
        }

        private void CarregarClientes()
        {
            cbxCliente.Enabled = true;

            Sql = "SELECT * FROM cliente WHERE nome = '" + cbxCliente.Text + "'";
            Consulta = BD.ExecutarConsultas(Sql);

            CodCliente = Consulta.Rows[0]["id"].ToString();
            TesteEst = Consulta.Rows[0]["uf"].ToString();
            TestarEstados(TesteEst);
            cbxCidade.Text = Consulta.Rows[0]["cidade"].ToString();
            mskCep.Text = Consulta.Rows[0]["cep"].ToString();
            txtLogradouro.Text = Consulta.Rows[0]["logradouro"].ToString();
            txtNumero.Text = Consulta.Rows[0]["numero"].ToString();
            txtComplemento.Text = Consulta.Rows[0]["complemento"].ToString();
            txtBairro.Text = Consulta.Rows[0]["bairro"].ToString();            
        }

        private void CarregarDadosPedido()
        {
            if (frmMensagemPergunta.Tipo == "Alterar")
            {
                btnCadastrarPedido.Text = "Alterar Pedido";

                Sql = "SELECT * FROM cliente WHERE telefone = '" + frmPedido.Telefone + "'";
                DataTable ConsultaCliente = BD.ExecutarConsultas(Sql);

                cbxCliente.DataSource = ConsultaCliente;
                cbxCliente.ValueMember = "id";
                cbxCliente.DisplayMember = "nome";

                mskTelefone.Text = ConsultaCliente.Rows[0]["telefone"].ToString();
                cbxCliente.Text = ConsultaCliente.Rows[0]["nome"].ToString();
                TesteEst = Consulta.Rows[0]["uf"].ToString();
                TestarEstados(TesteEst);
                cbxCidade.Text = Consulta.Rows[0]["cidade"].ToString();
                mskCep.Text = ConsultaCliente.Rows[0]["cep"].ToString();
                txtLogradouro.Text = ConsultaCliente.Rows[0]["logradouro"].ToString();
                txtNumero.Text = ConsultaCliente.Rows[0]["numero"].ToString();
                txtComplemento.Text = ConsultaCliente.Rows[0]["complemento"].ToString();
                txtBairro.Text = ConsultaCliente.Rows[0]["bairro"].ToString();

                decimal ValorMensagem = decimal.Parse(ValorPag.Substring(3, ValorPag.Length - 3).Replace(".", ","));
                decimal ValorMsg = decimal.Parse(ValorMensagem.ToString("0.00"));
                txtValor.Text = "R$ " + ValorMsg;

                Sql = "CALL SP_Select_PedidoAlterar('" + frmPedido.Pedido + "')";
                DataTable ConsultaPedido = BD.ExecutarConsultas(Sql);

                Sql = "SELECT COUNT(id) FROM itens_pedido WHERE pedido_id = '" + frmPedido.Pedido + "'";
                int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(id)"].ToString());
                               
                for (int i = 0; i < COUNT; i++)
                {
                    Produto = ConsultaPedido.Rows[i]["nome"].ToString();
                    Obs = ConsultaPedido.Rows[i]["observacoes"].ToString();
                    Qntd = ConsultaPedido.Rows[i]["quantidade"].ToString();                    

                    decimal ValorDtg = decimal.Parse(ConsultaPedido.Rows[i]["valor_itens"].ToString());
                    Valor = "R$ " + ValorDtg.ToString("0.00");

                    decimal CustoDtg = decimal.Parse(Valor.Substring(3, Valor.Length - 3).ToString()) / decimal.Parse(Qntd.ToString());
                    Custo = "R$ " + CustoDtg.ToString("0.00");

                    dtgItensPedido.Rows.Add(Produto, Qntd, Obs, Custo, Valor);
                }

                cbxProduto.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void cbxEstado_TextChanged(object sender, EventArgs e)
        {
            Cidades();
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {            
            #region Cadastrar o Pedido
            if (frmMensagemPergunta.Tipo == "Inserir")
            {
                if (mskTelefone.Text == "" && cbxCliente.Text == "")
                {
                    MessageBox.Show("Insira o telefone do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskTelefone.Focus();
                    return;
                }
                if (txtValor.Text == "R$ 0")
                {
                    MessageBox.Show("Insira ao menos 1 produto no pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxProduto.Focus();
                    return;
                }

                Sql = "CALL SP_Insert_Pedido('" + txtValor.Text.Substring(3, (txtValor.TextLength - 3)).Replace(",", ".") + "', '" + cbxCliente.SelectedValue + "', '" + frmLogin.idFunc + "')";
                BD.ExecutarComandos(Sql);

                for (int i = 0; i < dtgItensPedido.Rows.Count - 1; i++)
                {
                    string CodPedido = BD.ExecutarConsultas("SELECT MAX(id) FROM pedido").Rows[0]["MAX(id)"].ToString();
                    string CodProduto = BD.ExecutarConsultas("SELECT id FROM produto WHERE nome = '" + dtgItensPedido.Rows[i].Cells["ColunaProduto"].Value.ToString() + "'").Rows[0]["id"].ToString();
                    string Qntd = dtgItensPedido.Rows[i].Cells["ColunaQuantidade"].Value.ToString();
                    string Obs = dtgItensPedido.Rows[i].Cells["ColunaObservacoes"].Value.ToString();
                    string Valor = dtgItensPedido.Rows[i].Cells["ColunaValor"].Value.ToString().Substring(3, (dtgItensPedido.Rows[i].Cells["ColunaValor"].Value.ToString().Length - 3)).Replace(",", ".");

                    Sql = "CALL SP_Insert_ItensPedido(" + Qntd + ", '" + Obs + "', '" + Valor + "', '" + CodPedido + "', '" + CodProduto + "')";
                    BD.ExecutarComandos(Sql);
                }

                if (MessageBox.Show("Pedido realizado com sucesso!\nDeseja realizar o pagamento agora?", "OurTradeCenter", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataTable Dados = new DataTable();
                    Dados = BD.ExecutarConsultas("SELECT MAX(p.id), c.nome FROM pedido p JOIN cliente c ON p.cliente_id = c.id");
                    Pedido = Dados.Rows[0]["MAX(p.id)"].ToString();

                    this.Hide();
                    Limpar();

                    frmFatura Fatura = new frmFatura();
                    Fatura.ShowDialog();
                }
                else
                {
                    Limpar();
                }
            }
            #endregion            

            #region Alterar o Pedido
            else if (frmMensagemPergunta.Tipo == "Alterar")
            {
                if (mskTelefone.Text == "" && cbxCliente.Text == "")
                {
                    MessageBox.Show("Insira o telefone do cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskTelefone.Focus();
                    return;
                }
                if (txtValor.Text == "R$ 0")
                {
                    MessageBox.Show("Insira ao menos 1 produto no pedido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxProduto.Focus();
                    return;
                }

                Sql = "DELETE FROM itens_pedido WHERE pedido_id = '" + frmPedido.Pedido + "'";
                BD.ExecutarComandos(Sql);

                Sql = "UPDATE pedido SET valor_total = '" + txtValor.Text.Substring(3, (txtValor.TextLength - 3)).Replace(",", ".");
                Sql += "', valor_dtg = '" + txtValor.Text.Replace(",", ".") + "', cliente_id = '" + cbxCliente.SelectedValue + "' WHERE id = '" + frmPedido.Pedido + "'";
                BD.ExecutarComandos(Sql);

                for (int i = 0; i < dtgItensPedido.Rows.Count - 1; i++)
                {
                    string CodProduto = BD.ExecutarConsultas("SELECT id FROM produto WHERE nome = '" + dtgItensPedido.Rows[i].Cells["ColunaProduto"].Value.ToString() + "'").Rows[0]["id"].ToString();
                    string Obs = dtgItensPedido.Rows[i].Cells["ColunaObservacoes"].Value.ToString();
                    string Qntd = dtgItensPedido.Rows[i].Cells["ColunaQuantidade"].Value.ToString();                        
                    string Valor = dtgItensPedido.Rows[i].Cells["ColunaValor"].Value.ToString().Substring(3, (dtgItensPedido.Rows[i].Cells["ColunaValor"].Value.ToString().Length - 3)).Replace(",", ".");

                    Sql = "CALL SP_Insert_ItensPedido(" + Qntd + ", '" + Obs + "', '" + Valor + "', '" + frmPedido.Pedido + "', '" + CodProduto + "')";
                    BD.ExecutarComandos(Sql);
                }

                MessageBox.Show("Pedido alterado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            #endregion
        }

        private void mskTelefone_TextChanged(object sender, EventArgs e)
        {
            if (mskTelefone.TextLength == 14)
            {
                Sql = "SELECT * FROM cliente WHERE telefone = '" + mskTelefone.Text + "'";
                Consulta = BD.ExecutarConsultas(Sql);

                if (Consulta.Rows.Count == 1)
                {
                    cbxCliente.DataSource = Consulta;
                    cbxCliente.ValueMember = "id";
                    cbxCliente.DisplayMember = "nome";
                    cbxCliente.SelectedIndex = 0;

                    CodCliente = Consulta.Rows[0]["id"].ToString();
                    cbxCliente.Text = Consulta.Rows[0]["nome"].ToString();
                    TesteEst = Consulta.Rows[0]["uf"].ToString();
                    TestarEstados(TesteEst);
                    cbxCidade.Text = Consulta.Rows[0]["cidade"].ToString();
                    mskCep.Text = Consulta.Rows[0]["cep"].ToString();
                    txtLogradouro.Text = Consulta.Rows[0]["logradouro"].ToString();
                    txtNumero.Text = Consulta.Rows[0]["numero"].ToString();
                    txtComplemento.Text = Consulta.Rows[0]["complemento"].ToString();
                    txtBairro.Text = Consulta.Rows[0]["bairro"].ToString();

                    cbxCliente.Enabled = false;
                    chkSim.Enabled = true;
                }

                else if (Consulta.Rows.Count > 1)
                {
                    Sql = "SELECT * FROM cliente WHERE telefone = '" + mskTelefone.Text + "' ORDER BY nome ASC";

                    cbxCliente.DataSource = BD.ExecutarConsultas(Sql);
                    cbxCliente.ValueMember = "id";
                    cbxCliente.DisplayMember = "nome";
                    cbxCliente.SelectedIndex = 0;

                    CodCliente = Consulta.Rows[0]["id"].ToString();
                    TesteEst = Consulta.Rows[0]["uf"].ToString();
                    TestarEstados(TesteEst);
                    cbxCidade.Text = Consulta.Rows[0]["cidade"].ToString();
                    mskCep.Text = Consulta.Rows[0]["cep"].ToString();
                    txtLogradouro.Text = Consulta.Rows[0]["logradouro"].ToString();
                    txtNumero.Text = Consulta.Rows[0]["numero"].ToString();
                    txtComplemento.Text = Consulta.Rows[0]["complemento"].ToString();
                    txtBairro.Text = Consulta.Rows[0]["bairro"].ToString();

                    chkSim.Enabled = true;
                    Auxiliar = true;
                } 
            }    
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            Sql = "SELECT * FROM produto ORDER BY nome ASC";

            cbxProduto.DataSource = BD.ExecutarConsultas(Sql);
            cbxProduto.ValueMember = "id";
            cbxProduto.DisplayMember = "nome";

            cbxProduto.SelectedIndex = -1;
            cbxProduto.Focus();
        }

        private void btnAdicionarItensPedido_Click(object sender, EventArgs e)
        {
            if (cbxProduto.Text != "")
            {
                Sql = "SELECT valor FROM produto WHERE nome = '" + cbxProduto.Text + "'";

                ValorUni = decimal.Parse(BD.ExecutarConsultas(Sql).Rows[0]["valor"].ToString()) * int.Parse(txtQuantidade.Text);
                ValorAtual = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3));
                ValorTotal = ValorUni + ValorAtual;

                txtValor.Text = "R$ " + ValorTotal.ToString("0.00");

                dtgItensPedido.Rows.Add(cbxProduto.Text, txtQuantidade.Text, txtObservacoes.Text, ("R$ " + decimal.Parse(BD.ExecutarConsultas(Sql).Rows[0]["valor"].ToString()).ToString("0.00")), ("R$ " + ValorUni.ToString("0.00")));

                cbxProduto.Text = "Selecione o Produto";
                txtQuantidade.Text = "1";
                txtObservacoes.Text = "";
                lblProduto.Focus();

                cbxProduto.SelectedIndex = -1;
            }

            else
            {
                MessageBox.Show("Selecione o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void dtgItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja apagar esse item do pedido?", "Apagando.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string Valor = dtgItensPedido.Rows[e.RowIndex].Cells["ColunaValor"].Value.ToString();
                    string ValorConvertido = Valor.Substring(3, Valor.Length - 3);
                    decimal ValorPedido = decimal.Parse(ValorConvertido);

                    decimal ValorAgora = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3));
                    decimal ValorNovo = ValorAgora - ValorPedido;

                    txtValor.Text = "R$ " + ValorNovo;

                    dtgItensPedido.Rows.RemoveAt(e.RowIndex);
                }
            }

            catch
            {
                return;
            }
        }        

        private void chkSim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSim.Checked == true)
            {
                cbxEstado.Enabled = true;
                cbxCidade.Enabled = true;
                txtLogradouro.Enabled = true;
                txtNumero.Enabled = true;
                txtComplemento.Enabled = true;
                txtBairro.Enabled = true;
                mskCep.Enabled = true;
            }

            else
            {
                cbxEstado.Enabled = false;
                cbxCidade.Enabled = false;
                txtLogradouro.Enabled = false;
                txtNumero.Enabled = false;
                txtComplemento.Enabled = false;
                txtBairro.Enabled = false;
                mskCep.Enabled = false;                

                Sql = "SELECT * FROM cliente WHERE telefone = '" + mskTelefone.Text + "'";
                Consulta = BD.ExecutarConsultas(Sql);

                if (Consulta.Rows.Count == 1)
                {
                    cbxCliente.Text = Consulta.Rows[0]["nome"].ToString();
                    TesteEst = Consulta.Rows[0]["uf"].ToString();
                    TestarEstados(TesteEst);
                    cbxCidade.Text = Consulta.Rows[0]["cidade"].ToString();
                    mskCep.Text = Consulta.Rows[0]["cep"].ToString();
                    txtLogradouro.Text = Consulta.Rows[0]["logradouro"].ToString();
                    txtNumero.Text = Consulta.Rows[0]["numero"].ToString();
                    txtComplemento.Text = Consulta.Rows[0]["complemento"].ToString();
                    txtBairro.Text = Consulta.Rows[0]["bairro"].ToString();
                }
            }
        }

        private void chkEntregar_CheckedChanged(object sender, EventArgs e)
        {
            Entregar();
        }

        private void cbxCliente_TextChanged(object sender, EventArgs e)
        {
            if (Auxiliar == true)
            {
                if (cbxCliente.Text.Length > 3)
                    CarregarClientes();
            }
        }

        private void SomenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DesabilitarTudo(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
    }
}
