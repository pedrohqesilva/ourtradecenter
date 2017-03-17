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
    public partial class frmMensagem : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        string Sql;

        public frmMensagem()
        {
            InitializeComponent();

            Sql = "CALL SP_Select_Pedido()";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgPedidoAberto.DataSource = dt;

        }
        
        private void dtgPedidoAberto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                Sql = "CALL SP_Select_Pedido()";
                DataTable Pedido = BD.ExecutarConsultas(Sql);

                frmPedido.Pedido = Pedido.Rows[e.RowIndex]["Cod. Pedido"].ToString();
                frmPedido.Telefone = Pedido.Rows[e.RowIndex]["Telefone do Cliente"].ToString();
                frmPedido.ValorPag = Pedido.Rows[e.RowIndex]["Valor"].ToString();

                frmMensagemPergunta Pergunta = new frmMensagemPergunta();
                Pergunta.ShowDialog();
            //}

            //catch 
            //{
            //    return;
            //}
        }

        private void frmMensagem_Activated(object sender, EventArgs e)
        {
            Sql = "CALL SP_Select_Pedido()";
            DataTable dt = BD.ExecutarConsultas(Sql);
            dtgPedidoAberto.DataSource = dt;
        }
    }
}
