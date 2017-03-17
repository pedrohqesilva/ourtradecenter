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
    public partial class frmGrupo : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        frmProduto Prod = new frmProduto();

        string Sql;

        public frmGrupo()
        {
            InitializeComponent();

            Sql = "SELECT descricao AS 'Descricao' FROM grupo";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgGrupo.DataSource = dt;
        }       

        private void btnProdutoLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtDescricao.Focus();
        }

        private void btnCadastrarGrupo_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                Sql = "CALL SP_Insert_Grupo('" + txtDescricao.Text + "')";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Grupo '" + txtDescricao.Text + "', inserido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Sql = "SELECT descricao AS 'Descricao' FROM grupo";
                DataTable dt = BD.ExecutarConsultas(Sql);
                dtgGrupo.DataSource = dt;

                txtDescricao.Text = "";
                txtDescricao.Focus();

                frmProduto.stringCarregarComboBox = "Sim";
            }

            else
            {
                MessageBox.Show("Porfavor preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
