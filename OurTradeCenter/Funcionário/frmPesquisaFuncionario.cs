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
    public partial class frmPesquisaFuncionario : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public static string IDFuncionario;
        public static string NomeFuncionario;

        public frmPesquisaFuncionario()
        {
            InitializeComponent();

            Sql = "SELECT * FROM funcionario";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgFuncionario.DataSource = dt;
        }

        private void dtgFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDFuncionario = dtgFuncionario.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string[] Nome = dtgFuncionario.Rows[e.RowIndex].Cells["nome"].Value.ToString().Split(' ');

            NomeFuncionario = Nome[0] + " " + Nome[1];

            frmFuncionarioMenu FuncionarioMenu = new frmFuncionarioMenu();
            FuncionarioMenu.ShowDialog();
        }

        private void frmPesquisaFuncionario_Activated(object sender, EventArgs e)
        {
            Sql = "SELECT * FROM funcionario";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgFuncionario.DataSource = dt;
        }
    }
}
