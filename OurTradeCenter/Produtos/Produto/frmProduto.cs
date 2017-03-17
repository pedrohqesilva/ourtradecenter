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
    public partial class frmProduto : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;
        string ID;
        string Foto;

        public static string stringCarregarComboBox = "Sim";
        public static string dtgClick = "ReadOnly";

        public frmProduto()
        {
            InitializeComponent();
            CarregarComboBox();            
            CarregaGrid();

            stringCarregarComboBox = "Sim";
            
            if (frmProdutoPergunta.Tipo == "Inserir")
                btnCadastrarProduto.Text = "Cadastrar Produto";
            else if (frmProdutoPergunta.Tipo == "Alterar")
                btnCadastrarProduto.Text = "Alterar Produto";
        }

        private void LimparForm()
        {
            txtNome.Text = "";
            txtCusto.Text = "R$ 0";
            txtValor.Text = "R$ ";

            cbxGrupo.SelectedIndex = -1;
            cbxIngrediente.SelectedIndex = -1;
            cbxMedida.SelectedIndex = -1;
            pcbFoto.Image = null;

            txtQuantidade.Text = "1";

            dtgIngredientes.Rows.Clear();
        }

        private void CarregarComboBox()
        {   
            if (stringCarregarComboBox == "Sim")
            {  
                #region ComboBox Grupo
                Sql = "SELECT * FROM grupo ORDER BY descricao ASC";

                cbxGrupo.DataSource = BD.ExecutarConsultas(Sql);
                cbxGrupo.ValueMember = "id";
                cbxGrupo.DisplayMember = "descricao";
                cbxGrupo.SelectedIndex = -1;

                if (txtNome.Text != "")
                {
                    Sql = "SELECT g.descricao FROM produto p JOIN grupo g ON p.grupo_id = g.id WHERE p.id = " + ID;
                    DataTable PesquisaProduto = BD.ExecutarConsultas(Sql);
                    cbxGrupo.Text = PesquisaProduto.Rows[0]["descricao"].ToString();
                }
                #endregion
                #region ComboBox Ingrediente
                Sql = "SELECT * FROM ingredientes ORDER BY descricao ASC";

                cbxIngrediente.DataSource = BD.ExecutarConsultas(Sql);
                cbxIngrediente.ValueMember = "id";
                cbxIngrediente.DisplayMember = "descricao";
                cbxIngrediente.SelectedIndex = -1;
                #endregion

                stringCarregarComboBox = "Nao";
            }
        }

        private void CarregaGrid()
        {
            if (frmProdutoPergunta.Tipo == "Alterar")
            {
                ID = frmPesquisaProduto.IDProduto;
                
                Sql = "SELECT p.nome, p.foto, p.valor, g.descricao FROM produto p JOIN grupo g ON p.grupo_id = g.id WHERE p.id = " + ID;
                DataTable PesquisaProduto = BD.ExecutarConsultas(Sql);

                txtNome.Text = PesquisaProduto.Rows[0]["nome"].ToString();
                cbxGrupo.Text = PesquisaProduto.Rows[0]["descricao"].ToString();
                txtValor.Text = "R$ " + decimal.Parse(PesquisaProduto.Rows[0]["valor"].ToString()).ToString("0.00");

                try
                {
                    Foto = PesquisaProduto.Rows[0]["foto"].ToString();
                    Bitmap bmp = new Bitmap(@Foto);
                    Bitmap bmp2 = new Bitmap(bmp, pcbFoto.Size);
                    pcbFoto.Image = bmp2;
                }
                catch
                { }

                Sql = "SELECT COUNT(id) FROM ingredientes_produto WHERE produto_id = " + ID;
                int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(id)"].ToString());

                Sql = "CALL SP_Select_ItensProduto(" + ID + ")";
                DataTable ListaIng = BD.ExecutarConsultas(Sql);                

                for (int i = 0; i < COUNT; i++)
                {
                    string Qntd = ListaIng.Rows[i]["quantidade"].ToString();
                    string Medida = ListaIng.Rows[i]["medida"].ToString();
                    string Ing = ListaIng.Rows[i]["descricao"].ToString();
                    string CustoUni = "R$ " + decimal.Parse(ListaIng.Rows[i]["custo"].ToString()).ToString("0.00");
                    string CustoTotal = "R$ " + (decimal.Parse(ListaIng.Rows[i]["custo"].ToString()) * decimal.Parse(Qntd)).ToString("0.00");
                    
                    dtgIngredientes.Rows.Add(Ing, Qntd, Medida, CustoUni, CustoTotal);

                    string Custo = dtgIngredientes.Rows[i].Cells["ColunaCustoTotal"].Value.ToString();
                    string ValorCusto = decimal.Parse(Custo.Substring(3, Custo.Length - 3)).ToString("0.00");
                    decimal CustoAtual = decimal.Parse(txtCusto.Text.Substring(3, txtCusto.TextLength - 3));
                    decimal TotalCusto = decimal.Parse(ValorCusto) + CustoAtual;

                    txtCusto.Text = "R$ " + TotalCusto.ToString();
                }

                txtNome.Focus();
            }
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            frmGrupo Grupo = new frmGrupo();
            Grupo.Show();
        }

        private void btnAdicionarIng_Click(object sender, EventArgs e)
        {
            frmIngrediente Ingrediente = new frmIngrediente();
            Ingrediente.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }
        
        private void btnAdicionarIngrediente_Click(object sender, EventArgs e)
        {
            if (cbxIngrediente.Text != "" && cbxMedida.Text != "")
            {
                Sql = "SELECT custo FROM ingredientes WHERE descricao = '" + cbxIngrediente.Text + "'";
                decimal ValorCustoUni = decimal.Parse(BD.ExecutarConsultas(Sql).Rows[0]["Custo"].ToString());
                decimal ValorCustoTotal = ValorCustoUni * int.Parse(txtQuantidade.Text);
                decimal CustoAtual = decimal.Parse(txtCusto.Text.Substring(3, txtCusto.TextLength - 3));
                decimal TotalCusto = ValorCustoTotal + CustoAtual;

                double Total = double.Parse(TotalCusto.ToString()) * 1.3;
                decimal TotalValor = decimal.Parse(Total.ToString("0.00"));

                dtgIngredientes.Rows.Add(cbxIngrediente.Text, txtQuantidade.Text, cbxMedida.Text, ("R$ " + ValorCustoUni.ToString("0.00")), ("R$ " + ValorCustoTotal.ToString("0.00")));

                txtCusto.Text = "R$ " + TotalCusto.ToString("0.00");
                txtValor.Text = "R$ " + TotalValor.ToString("0.00");

                cbxIngrediente.SelectedIndex = -1;
                cbxMedida.SelectedIndex = -1;
                txtQuantidade.Text = "1";

                cbxIngrediente.Focus();
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            if (frmProdutoPergunta.Tipo == "Inserir")
            {
                #region Inserir
                if (txtNome.Text == "" && txtNome.Text.Length < 4)
                {
                    MessageBox.Show("Insira o nome do produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }
                if (cbxGrupo.Text == "")
                {
                    MessageBox.Show("Insira o grupo do produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxGrupo.Focus();
                    return;
                }
                if (txtCusto.Text == "R$ 0")
                {
                    MessageBox.Show("Insira ao menos 1 ingrediente para o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxIngrediente.Focus();
                    return;
                }

                Sql = "CALL SP_Insert_Produto('" + txtNome.Text + "', '" + txtCusto.Text.Substring(3, txtCusto.TextLength - 3).Replace(',', '.') + "', '";
                Sql += txtValor.Text.Substring(3, txtValor.TextLength - 3).Replace(',', '.') + "', '" + Foto + "', '" + cbxGrupo.SelectedValue + "')";
                BD.ExecutarComandos(Sql);

                string CodProduto = BD.ExecutarConsultas("Select Max(id) From Produto").Rows[0]["Max(id)"].ToString();

                for (int i = 0; i < dtgIngredientes.Rows.Count - 1; i++)
                {
                    string CodIngrediente = BD.ExecutarConsultas("SELECT id FROM ingredientes WHERE descricao = '" + dtgIngredientes.Rows[i].Cells[0].Value.ToString() + "'").Rows[0]["id"].ToString();
                    string Qntd = dtgIngredientes.Rows[i].Cells["ColunaQuantidade"].Value.ToString();
                    string Medida = dtgIngredientes.Rows[i].Cells["ColunaMedida"].Value.ToString();

                    Sql = "CALL SP_Insert_Receita('" + Qntd + "', '" + CodProduto + "', '" + CodIngrediente + "', '" + Medida + "')";
                    BD.ExecutarComandos(Sql);
                }

                MessageBox.Show("Produto '" + txtNome.Text + "' e seus ingredientes, foram inseridos com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparForm();
                #endregion
            }
            
            else if (frmProdutoPergunta.Tipo == "Alterar")
            {
                #region Alterar
                if (txtNome.Text == "" && txtNome.Text.Length < 4)
                {
                    MessageBox.Show("Insira o nome do produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNome.Focus();
                    return;
                }
                if (cbxGrupo.Text == "")
                {
                    MessageBox.Show("Insira o grupo do produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxGrupo.Focus();
                    return;
                }
                if (txtCusto.Text == "R$ 0")
                {
                    MessageBox.Show("Insira ao menos 1 ingrediente para o produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxIngrediente.Focus();
                    return;
                }

                Sql = "DELETE FROM ingredientes_produto WHERE produto_id = '" + ID + "'";
                BD.ExecutarComandos(Sql);

                Sql  = "UPDATE produto SET nome = '" + txtNome.Text + "', custo_total = '" + txtCusto.Text.Substring(3, txtCusto.TextLength - 3).Replace(',', '.');
                Sql += "', foto = '" + Foto + "', valor = '" + txtValor.Text.Substring(3, txtValor.TextLength - 3).Replace(',', '.') + "', ";
                Sql += "grupo_id = '" + cbxGrupo.SelectedValue + "' WHERE id = " + ID;
                BD.ExecutarComandos(Sql);
                                       
                for (int i = 0; i < dtgIngredientes.Rows.Count - 1; i++)
                {
                    string CodIngrediente = BD.ExecutarConsultas("SELECT id FROM ingredientes WHERE descricao = '" + dtgIngredientes.Rows[i].Cells[0].Value.ToString() + "'").Rows[0]["id"].ToString();
                    string Qntd = dtgIngredientes.Rows[i].Cells["ColunaQuantidade"].Value.ToString();
                    string Medida = dtgIngredientes.Rows[i].Cells["ColunaMedida"].Value.ToString();

                    Sql = "CALL SP_Insert_Receita('" + Qntd + "', '" + ID + "', '" + CodIngrediente + "', '" + Medida + "')";
                    BD.ExecutarComandos(Sql);
                }

                MessageBox.Show("Produto '" + txtNome.Text + "' e seus ingredientes, foram alterados com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimparForm();
                #endregion
            }
        }       

        private void dtgIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja apagar esse ingrediente do produto?", "Apagando.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string Custo = dtgIngredientes.Rows[e.RowIndex].Cells["ColunaCustoUni"].Value.ToString();
                string CustoConvertido = Custo.Substring(3, Custo.Length - 3);
                decimal ValorCusto = decimal.Parse(CustoConvertido);

                decimal ValorAtual = decimal.Parse(txtCusto.Text.Substring(3, txtCusto.TextLength - 3));
                decimal ValorNovo = ValorAtual - ValorCusto;

                txtCusto.Text = "R$ " + ValorNovo;

                string ProdutoAgora = txtValor.Text.Substring(3, txtValor.TextLength - 3);
                decimal ProdutoConvertido = decimal.Parse(ProdutoAgora.ToString());
                double ValorProdutoNovo = double.Parse(ProdutoConvertido.ToString()) - (double.Parse(ValorCusto.ToString()) * 1.3);

                txtValor.Text = "R$ " + ValorProdutoNovo.ToString("0.00");

                dtgIngredientes.Rows.RemoveAt(e.RowIndex);
            }                       
        }

        private void SomenteNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAlterarFoto_Click(object sender, EventArgs e)
        {
            if (frmProdutoPergunta.Tipo == "Inserir")
            {
                try
                {
                    ofdAlterarFoto.ShowDialog();

                    Bitmap bmp = new Bitmap(ofdAlterarFoto.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, pcbFoto.Size);

                    pcbFoto.Image = bmp2;
                    pcbFoto.Image.Save(@"..\..\..\FotosProdutos\" + txtNome.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    Foto = @"..\\..\\..\\FotosProdutos\\" + txtNome.Text + ".png";
                }
                catch
                {
                    return;
                }
            }
            else if (frmProdutoPergunta.Tipo == "Alterar")
            {
                try
                {
                    ofdAlterarFoto.ShowDialog();

                    Bitmap bmp = new Bitmap(ofdAlterarFoto.FileName);
                    Bitmap bmp2 = new Bitmap(bmp, pcbFoto.Size);

                    pcbFoto.Image = bmp2;
                    pcbFoto.Image.Save(@"..\..\..\FotosProdutos\" + txtNome.Text + "Nova.png", System.Drawing.Imaging.ImageFormat.Png);
                    Foto = @"..\\..\\..\\FotosProdutos\\" + txtNome.Text + "Nova.png";
                }
                catch
                {
                    return;
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                btnAlterarFoto.Enabled = true;
            }
            else if (txtNome.Text == "")
            {
                btnAlterarFoto.Enabled = false;
            }
        }

        private void btnProdutosCadastrados_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto Pesquisa = new frmPesquisaProduto();
            Pesquisa.Show();
        }

        private void frmProduto_Activated(object sender, EventArgs e)
        {
            CarregarComboBox();
        }

    }
}
