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
    public partial class frmVisualizarEstIngrediente : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public static string EstIng;
        public static string EstNomeIng;
        public static string EstQuantidadeIng;
        public static string EstMedidaIng;

        public frmVisualizarEstIngrediente()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dtgProduto.Rows.Clear();
            Sql = "SELECT COUNT(id) FROM estoque_ingredientes";
            int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT est.id, i.descricao, est.quantidade, est.medida, est.data_modificacao FROM estoque_ingredientes est JOIN ingredientes i ON est.ingredientes_id = i.id";
            DataTable dt = BD.ExecutarConsultas(Sql);

            for (int i = 0; i < COUNT; i++)
            {
                string id = dt.Rows[i]["id"].ToString();
                string nome = dt.Rows[i]["descricao"].ToString();
                string quantidade = dt.Rows[i]["quantidade"].ToString();
                string medida = dt.Rows[i]["medida"].ToString();
                string data_modificacao = dt.Rows[i]["data_modificacao"].ToString();

                dtgProduto.Rows.Add(id, nome, quantidade, medida, data_modificacao);
            }
        }

        private void dtgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EstIng = dtgProduto.Rows[e.RowIndex].Cells["ColunaID"].Value.ToString();
            EstNomeIng = dtgProduto.Rows[e.RowIndex].Cells["ColunaNome"].Value.ToString();
            EstQuantidadeIng = dtgProduto.Rows[e.RowIndex].Cells["ColunaQuantidade"].Value.ToString();
            EstMedidaIng = dtgProduto.Rows[e.RowIndex].Cells["ColunaMedida"].Value.ToString();

            frmEstoqueIngrediente EstoqueIngrediente = new frmEstoqueIngrediente();
            EstoqueIngrediente.ShowDialog();
        }

        private void frmVisualizarEstIngrediente_Activated(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
