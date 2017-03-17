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
    public partial class frmMensagemPergunta : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        DataTable dt = new DataTable();
        string Sql;

        public static string Tipo = "Inserir";
        public static string Pedido;

        public frmMensagemPergunta()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Sql = "CALL SP_Select_Pedido()";
            Pedido = BD.ExecutarConsultas(Sql).Rows[0]["Cod. Pedido"].ToString();

            this.Close();
            frmFatura Fatura = new frmFatura();
            Fatura.ShowDialog();            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Sql = "CALL SP_Select_Pedido()";
            Pedido = BD.ExecutarConsultas(Sql).Rows[0]["Cod. Pedido"].ToString();

            Sql = "CALL SP_Delete_Pedido(" + frmPedido.Pedido + ")";
            BD.ExecutarComandos(Sql);

            MessageBox.Show("Pedido '" + frmPedido.Pedido + "', excluido com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Tipo = "Alterar";

            this.Close();
            frmPedido Pedido = new frmPedido();
            Pedido.ShowDialog();   
        }
    }
}
