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
    public partial class frmPesquisaIngredientes : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public static string IDIngrediente;
        public static string NomeIngrediente;

        public frmPesquisaIngredientes()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dtgIngrediente.Rows.Clear();
            Sql = "SELECT COUNT(id) FROM ingredientes";
            int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(id)"].ToString());

            Sql = "SELECT id AS 'Cod. Ingrediente', descricao AS 'Descricao', medida AS 'Medida', custo AS 'Custo' FROM ingredientes";
            DataTable dt = BD.ExecutarConsultas(Sql);
            
            for (int i = 0; i < COUNT; i++)
            {
                string id = dt.Rows[i]["Cod. Ingrediente"].ToString();
                string descricao = dt.Rows[i]["Descricao"].ToString();
                string medida = dt.Rows[i]["Medida"].ToString();
                decimal custo = decimal.Parse(dt.Rows[i]["Custo"].ToString());

                dtgIngrediente.Rows.Add(id, descricao, medida, ("R$ " + custo.ToString("0.00")));
            }
        }
        private void dtgIngrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDIngrediente = dtgIngrediente.Rows[e.RowIndex].Cells["ColunaId"].Value.ToString();
            string[] Nome = dtgIngrediente.Rows[e.RowIndex].Cells["ColunaIngrediente"].Value.ToString().Split(' ');

            NomeIngrediente = Nome[0];

            frmIngredienteMenu IngredienteMenu = new frmIngredienteMenu();
            IngredienteMenu.ShowDialog();
        }

        private void frmPesquisaIngredientes_Activated(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
