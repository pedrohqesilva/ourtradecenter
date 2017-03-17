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
    public partial class frmPesquisaProduto : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public static string IDProduto;
        public static string NomeProduto;

        public frmPesquisaProduto()
        {
            InitializeComponent();
            CarregaGrid();

            if (frmProduto.dtgClick == "ReadOnly")
            {
                dtgProduto.ReadOnly = true;
            }
        }

        private void CarregaGrid()
        {
            dtgProduto.Rows.Clear();
            Sql = "SELECT COUNT(id) FROM produto";
            int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT p.id, p.nome, p.custo_total, p.valor, g.descricao FROM produto p JOIN grupo g ON p.grupo_id = g.id ORDER BY p.id";
            DataTable dt = BD.ExecutarConsultas(Sql);

            for (int i = 0; i < COUNT; i++)
            {
                string id = dt.Rows[i]["id"].ToString();
                string nome = dt.Rows[i]["nome"].ToString();
                decimal custo = decimal.Parse(dt.Rows[i]["custo_total"].ToString());
                decimal valor = decimal.Parse(dt.Rows[i]["valor"].ToString());
                string grupo = dt.Rows[i]["descricao"].ToString();

                dtgProduto.Rows.Add(id, nome, ("R$ " + custo.ToString("0.00")), ("R$ " + valor.ToString("0.00")), grupo);
            }
        }

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (frmProduto.dtgClick != "ReadOnly")
            {
                IDProduto = dtgProduto.Rows[e.RowIndex].Cells["ColunaCod"].Value.ToString();
                string[] Nome = dtgProduto.Rows[e.RowIndex].Cells["ColunaNome"].Value.ToString().Split(' ');

                NomeProduto = Nome[0];

                frmProdutoMenu ProdutoMenu = new frmProdutoMenu();
                ProdutoMenu.ShowDialog();
            }
        }

        private void frmPesquisaProduto_Activated(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
