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
    public partial class frmVisualizarEstProduto : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public static string EstProduto;
        public static string EstNome;
        public static string EstQuantidade;
        public static string EstMedida;

        public frmVisualizarEstProduto()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dtgProduto.Rows.Clear();
            Sql = "SELECT COUNT(id) FROM estoque_produtos";
            int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT est.id, p.nome, est.quantidade, est.medida, est.data_modificacao FROM estoque_produtos est JOIN produto p ON est.produto_id = p.id";
            DataTable dt = BD.ExecutarConsultas(Sql);

            for (int i = 0; i < COUNT; i++)
            {
                string id = dt.Rows[i]["id"].ToString();
                string nome = dt.Rows[i]["nome"].ToString();
                string quantidade = dt.Rows[i]["quantidade"].ToString();
                string medida = dt.Rows[i]["medida"].ToString();
                string data_modificacao = dt.Rows[i]["data_modificacao"].ToString();

                dtgProduto.Rows.Add(id, nome, quantidade, medida, data_modificacao);
            }
        }

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EstProduto = dtgProduto.Rows[e.RowIndex].Cells["ColunaID"].Value.ToString();
            EstNome = dtgProduto.Rows[e.RowIndex].Cells["ColunaNome"].Value.ToString();
            EstQuantidade = dtgProduto.Rows[e.RowIndex].Cells["ColunaQuantidade"].Value.ToString();
            EstMedida = dtgProduto.Rows[e.RowIndex].Cells["ColunaMedida"].Value.ToString();

            frmEstoqueProduto EstoqueProduto = new frmEstoqueProduto();
            EstoqueProduto.ShowDialog();
        }

        private void frmVisualizarEstProduto_Activated(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
