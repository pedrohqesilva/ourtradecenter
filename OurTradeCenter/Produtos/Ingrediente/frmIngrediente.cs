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
    public partial class frmIngrediente : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        frmProduto Prod = new frmProduto();

        string Sql;
        string ID;

        public frmIngrediente()
        {
            InitializeComponent();                    
            CarregarIngrediente();                                
        }        

        private void CarregarIngrediente()
        {
            if (frmIngredientePergunta.Tipo == "Alterar")
            {
                ID = frmPesquisaIngredientes.IDIngrediente;

                Sql = "SELECT descricao, custo, medida FROM ingredientes WHERE id = " + ID;
                DataTable PesquisaIngrediente = BD.ExecutarConsultas(Sql);

                cbxMedida.Text = PesquisaIngrediente.Rows[0]["medida"].ToString();
                txtDescricao.Text = PesquisaIngrediente.Rows[0]["descricao"].ToString();
                txtCusto.Text = "R$ " + decimal.Parse(PesquisaIngrediente.Rows[0]["custo"].ToString()).ToString("0.00");

                btnCadastrarIngrediente.Text = "Alterar Cadastro";
            }    
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtCusto.Text = "R$ ";
            txtDescricao.Focus();       
        }

        private void btnCadastrarMedida_Click(object sender, EventArgs e)
        {
            if (frmIngredientePergunta.Tipo == "Inserir")
            {
                #region Inserir Ingrediente
                if (txtDescricao.Text != "" && txtCusto.Text != "")
                {
                    Sql = "CALL SP_Insert_Ingrediente('" + txtDescricao.Text + "', '" + txtCusto.Text.Substring(3, txtCusto.TextLength - 3).Replace(',', '.');
                    Sql += "', '" + cbxMedida.SelectedValue + "')";
                    BD.ExecutarComandos(Sql);

                    MessageBox.Show("Ingrediente '" + txtDescricao.Text + "', registrado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Text = "";
                    txtCusto.Text = "R$ ";
                    txtDescricao.Focus();

                    frmProduto.stringCarregarComboBox = "Sim";
                }

                else
                {
                    MessageBox.Show("Porfavor preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
            }

            else if (frmIngredientePergunta.Tipo == "Alterar")
            {
                #region Alterar Ingrediente
                if (txtDescricao.Text != "" && txtCusto.Text != "")
                {
                    Sql  = "UPDATE ingredientes SET descricao = '" + txtDescricao.Text + "', custo = '";
                    Sql += txtCusto.Text.Substring(3, txtCusto.TextLength - 3).Replace(',', '.') + "', ";
                    Sql += "medida = '" + cbxMedida.Text + "' WHERE id = " + frmPesquisaIngredientes.IDIngrediente;
                    BD.ExecutarComandos(Sql);

                    MessageBox.Show("Ingrediente '" + txtDescricao.Text + "', alterado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescricao.Text = "";
                    txtCusto.Text = "R$ ";
                    txtDescricao.Focus();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Porfavor preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                #endregion
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
