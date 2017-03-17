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
    public partial class frmPesquisaCliente : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public static string IDCliente;
        public static string NomeCliente;

        public frmPesquisaCliente()
        {
            InitializeComponent();

            Sql = "SELECT id AS 'Cod. Cliente', nome AS 'Nome', cpf AS 'CPF', nascimento AS 'Data de Nascimento', sexo AS 'Sexo', telefone AS 'Telefone', email AS 'E-mail', logradouro AS 'Logradouro', numero AS 'Numero', complemento AS 'Compl.', bairro AS 'Bairro', cidade AS 'Cidade', uf AS 'Estado', cep AS 'CEP', nome_cartao AS 'Nome igual Cartao', codigo_cartao AS 'Cod. Cartao', codigo_seguranca AS 'Cod. Segurança', bandeira AS 'Bandeira', validade AS 'Data de Validade' FROM cliente";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgCliente.DataSource = dt;
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCliente = dtgCliente.Rows[e.RowIndex].Cells["Cod. Cliente"].Value.ToString();
            string[] Nome = dtgCliente.Rows[e.RowIndex].Cells["Nome"].Value.ToString().Split(' ');

            NomeCliente = Nome[0] + " " + Nome[1];

            frmClienteMenu ClienteMenu = new frmClienteMenu();
            ClienteMenu.ShowDialog();
        }

        private void frmPesquisaCliente_Activated(object sender, EventArgs e)
        {
            Sql = "SELECT id AS 'Cod. Cliente', nome AS 'Nome', cpf AS 'CPF', nascimento AS 'Data de Nascimento', sexo AS 'Sexo', telefone AS 'Telefone', email AS 'E-mail', logradouro AS 'Logradouro', numero AS 'Numero', complemento AS 'Compl.', bairro AS 'Bairro', cidade AS 'Cidade', uf AS 'Estado', cep AS 'CEP', nome_cartao AS 'Nome igual Cartao', codigo_cartao AS 'Cod. Cartao', codigo_seguranca AS 'Cod. Segurança', bandeira AS 'Bandeira', validade AS 'Data de Validade' FROM cliente";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgCliente.DataSource = dt;
        }
    }
}
