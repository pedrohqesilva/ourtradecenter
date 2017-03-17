using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlaEstoque
{
    public partial class frmLogin : Form
    {
        DataTable Teste = new DataTable();
        ConexaoBanco BD = new ConexaoBanco();

        public static string idFunc;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM funcionario WHERE login = '" + txtUsuario.Text + "' AND senha = '" + txtSenha.Text + "'";
            Teste = BD.ExecutarConsultas(Sql);

            if (Teste.Rows.Count == 1)
            {
                idFunc = Teste.Rows[0]["id"].ToString();

                if (Teste.Rows[0]["cargo"].ToString() == "Atendente")
                {
                    this.Hide();
                    frmMenuFuncionario Menu = new frmMenuFuncionario();
                    Menu.Show();
                }

                else if (Teste.Rows[0]["cargo"].ToString() == "Gerente")
                {
                    this.Hide();
                    frmMenuGerente Menu = new frmMenuGerente();
                    Menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFuncionario Funcionario = new frmFuncionario();
            Funcionario.Show();
        }

        private void lblEsqueceu_MouseEnter(object sender, EventArgs e)
        {
            lblEsqueceu.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Underline);
        }

        private void lblEsqueceu_MouseLeave(object sender, EventArgs e)
        {
            lblEsqueceu.Font = new Font(FontFamily.GenericSansSerif, 8);
        }

    }
}
