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
    public partial class frmFatura : Form
    {
        ConexaoBanco BD = new ConexaoBanco();
        DataTable Parcelas = new DataTable();

        string Sql;
        string PedidoID;

        public frmFatura()
        {
            InitializeComponent();

            Parcelas.Columns.Add("nParcelas");
            Parcelas.Columns.Add("Parcelas");
            PedidoID = frmPedido.Pedido;

            decimal Valor = decimal.Parse(BD.ExecutarConsultas("SELECT valor_total FROM pedido WHERE id = '" + PedidoID + "'").Rows[0]["valor_total"].ToString());
            string ValorTotal = "R$ " + Valor.ToString("0.00");
            txtValor.Text = ValorTotal;
        }

        private void Estoque()
        {
            Sql = "SELECT COUNT(ID) FROM itens_pedido WHERE pedido_id = '" + PedidoID + "'";
            int COUNT = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(ID)"].ToString());
            Sql = "SELECT produto_id, quantidade FROM itens_pedido WHERE pedido_id = '" + PedidoID + "'";
            DataTable Produtos = BD.ExecutarConsultas(Sql);

            for (int i = 0; i < COUNT; i++ )
            {
                string Alterar = Produtos.Rows[i]["produto_id"].ToString();
                string Quantidade = Produtos.Rows[i]["quantidade"].ToString();

                Sql = "UPDATE estoque_produtos SET quantidade = quantidade - '" + Quantidade + "' WHERE produto_id = '" + Alterar + "'";
                BD.ExecutarComandos(Sql);

                #region Ingredientes 
                Sql = "SELECT COUNT(ID) FROM ingredientes_produto WHERE produto_id = '" + Alterar + "'";
                int COUNTING = int.Parse(BD.ExecutarConsultas(Sql).Rows[0]["COUNT(ID)"].ToString());
                Sql = "SELECT ingredientes_id, quantidade FROM ingredientes_produto WHERE produto_id = '" + Alterar + "'";
                DataTable Ingredientes = BD.ExecutarConsultas(Sql);

                for (int x = 0; x < COUNTING; x++)
                {
                    string AlterarIng = Ingredientes.Rows[x]["ingredientes_id"].ToString();
                    string QuantidadeIng = Ingredientes.Rows[x]["quantidade"].ToString();

                    Sql = "UPDATE estoque_ingredientes SET quantidade = quantidade - '" + QuantidadeIng + "' WHERE ingredientes_id = '" + AlterarIng + "'";
                    BD.ExecutarComandos(Sql);
                }
                #endregion
            }

            MessageBox.Show("Os estoques de produtos e ingredientes do mesmo foram atualizados!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void cbxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMetodo.Text == "Selecione o Método")
                pnlBranco.BringToFront();
            else if (cbxMetodo.Text == "Dinheiro")
            {
                pnlDinheiro.BringToFront();
                #region Limpando campos
                txtValorPago.Focus();
                txtValorPago.Text = "R$ ";
                txtTroco.Text = "R$ ";
                #endregion
            }
            else
            {
                pnlCartao.BringToFront();
                #region Limpando campos
                mskCPF.Focus();
                mskCPF.Text = "";
                cbxParcelas.Text = "";
                txtNome.Text = "";
                mskCodCartao.Text = "";
                cbxBandeira.Text = "";
                mskValidade.Text = "";
                mskCodSeguranca.Text = "";
                #endregion
                #region ComboBox para Parcelas
                string Parcelas1 = "";
                string Parcelas2 = "";
                string Parcelas3 = "";
                string Parcelas4 = "";
                string Parcelas5 = "";
                string Parcelas6 = "";
                string Parcelas7 = "";
                string Parcelas8 = "";
                string Parcelas9 = "";
                string Parcelas10 = "";

                decimal cadaParcela1 = 0;
                decimal cadaParcela2 = 0;
                decimal cadaParcela3 = 0;
                decimal cadaParcela4 = 0;
                decimal cadaParcela5 = 0;
                decimal cadaParcela6 = 0;
                decimal cadaParcela7 = 0;
                decimal cadaParcela8 = 0;
                decimal cadaParcela9 = 0;
                decimal cadaParcela10 = 0;

                if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 50)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 100)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                  
                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 150)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                    
                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");
                    
                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 200)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                    
                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");
                    
                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");
                    
                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 250)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                    
                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");
                    
                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");
                    
                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");
                    
                    cadaParcela5 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 5;
                    Parcelas5 = "5x - R$ " + cadaParcela5.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 300)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                    
                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");
                    
                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");
                    
                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");
                    
                    cadaParcela5 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 5;
                    Parcelas5 = "5x - R$ " + cadaParcela5.ToString("0.00");
                    
                    cadaParcela6 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 6;
                    Parcelas6 = "6x - R$ " + cadaParcela6.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 350)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");
                    
                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");
                    
                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");
                    
                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");
                    
                    cadaParcela5 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 5;
                    Parcelas5 = "5x - R$ " + cadaParcela5.ToString("0.00");
                    
                    cadaParcela6 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 6;
                    Parcelas6 = "6x - R$ " + cadaParcela6.ToString("0.00");
                    
                    cadaParcela7 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 7;
                    Parcelas7 = "7x - R$ " + cadaParcela7.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 400)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");

                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");

                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");

                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");

                    cadaParcela5 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 5;
                    Parcelas5 = "5x - R$ " + cadaParcela5.ToString("0.00");

                    cadaParcela6 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 6;
                    Parcelas6 = "6x - R$ " + cadaParcela6.ToString("0.00");

                    cadaParcela7 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 7;
                    Parcelas7 = "7x - R$ " + cadaParcela7.ToString("0.00");
					
                    cadaParcela8 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 8;
                    Parcelas8 = "8x - R$ " + cadaParcela8.ToString("0.00");
                }
                else if (decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) < 450)
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");

                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");

                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");

                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");

                    cadaParcela5 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 5;
                    Parcelas5 = "5x - R$ " + cadaParcela5.ToString("0.00");

                    cadaParcela6 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 6;
                    Parcelas6 = "6x - R$ " + cadaParcela6.ToString("0.00");

                    cadaParcela7 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 7;
                    Parcelas7 = "7x - R$ " + cadaParcela7.ToString("0.00");
                    
                    cadaParcela8 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 8;
                    Parcelas8 = "8x - R$ " + cadaParcela8.ToString("0.00");
                    
                    cadaParcela9 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 9;
                    Parcelas9 = "9x - R$ " + cadaParcela9.ToString("0.00");
                }
                else
                {
                    cadaParcela1 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 1;
                    Parcelas1 = "1x - R$ " + cadaParcela1.ToString("0.00");

                    cadaParcela2 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 2;
                    Parcelas2 = "2x - R$ " + cadaParcela2.ToString("0.00");

                    cadaParcela3 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 3;
                    Parcelas3 = "3x - R$ " + cadaParcela3.ToString("0.00");

                    cadaParcela4 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 4;
                    Parcelas4 = "4x - R$ " + cadaParcela4.ToString("0.00");

                    cadaParcela5 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 5;
                    Parcelas5 = "5x - R$ " + cadaParcela5.ToString("0.00");

                    cadaParcela6 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 6;
                    Parcelas6 = "6x - R$ " + cadaParcela6.ToString("0.00");
                   
                    cadaParcela7 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 7;
                    Parcelas7 = "7x - R$ " + cadaParcela7.ToString("0.00");

                    cadaParcela8 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 8;
                    Parcelas8 = "8x - R$ " + cadaParcela8.ToString("0.00");

                    cadaParcela9 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 9;
                    Parcelas9 = "9x - R$ " + cadaParcela9.ToString("0.00");

                    cadaParcela10 = decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)) / 10;
                    Parcelas10 = "10x - R$ " + cadaParcela10.ToString("0.00");
                }

                if(Parcelas1 != "")
                    Parcelas.Rows.Add(1,Parcelas1);
                if(Parcelas2 != "")
                    Parcelas.Rows.Add(2,Parcelas2);
                if(Parcelas3 != "")
                    Parcelas.Rows.Add(3,Parcelas3);
                if(Parcelas4 != "")
                    Parcelas.Rows.Add(4,Parcelas4);
                if(Parcelas5 != "")
                    Parcelas.Rows.Add(5,Parcelas5);
                if(Parcelas6 != "")
                    Parcelas.Rows.Add(6,Parcelas6);
                if(Parcelas7 != "")
                    Parcelas.Rows.Add(7,Parcelas7);
                if(Parcelas8 != "")
                    Parcelas.Rows.Add(8,Parcelas8);
                if(Parcelas9 != "")
                    Parcelas.Rows.Add(9,Parcelas9);
                if(Parcelas10 != "")
                    Parcelas.Rows.Add(10,Parcelas10);

                cbxParcelas.DataSource = Parcelas;

                cbxParcelas.DisplayMember = "Parcelas";
                cbxParcelas.ValueMember = "nParcelas";
                #endregion
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!txtValorPago.Text.Contains("R$ "))
            {
                decimal Valor = decimal.Parse(txtValorPago.Text.ToString());
                decimal ValorB = decimal.Parse(Valor.ToString("0.00"));
                txtValorPago.Text = "R$ " + ValorB;                
            }

            else
            {
                decimal Valor = decimal.Parse(txtValorPago.Text.ToString().Substring(3, txtValorPago.TextLength - 3));
                decimal ValorB = decimal.Parse(Valor.ToString("0.00"));
                txtValorPago.Text = "R$ " + ValorB.ToString(); 
            }

            decimal Troco = decimal.Parse(decimal.Parse(txtValorPago.Text.Substring(3, txtValorPago.TextLength - 3)).ToString("0.00")) - decimal.Parse(decimal.Parse(txtValor.Text.Substring(3, txtValor.TextLength - 3)).ToString("0.00"));

            if (Troco > 0)
            {
                lblTroco.Visible = true;
                lblTroco.Text = "Troco:";

                txtTroco.Text = "R$ " + Troco.ToString("0.00");
            }
            else
            {
                lblTroco.Visible = true;
                lblTroco.Text = "Falta:";

                txtTroco.Text = "R$ " + (Troco * (-1)).ToString("0.00");
            }
        }

        private void btnCadastrarFatura_Click(object sender, EventArgs e)
        {
            Sql = "SELECT nome FROM pedido p JOIN cliente c ON p.cliente_id = c.id WHERE p.id = '" + PedidoID + "'";
            string Cliente = BD.ExecutarConsultas(Sql).Rows[0]["nome"].ToString();

            if (cbxMetodo.Text == "Dinheiro")
            {
                Sql  = "UPDATE pedido SET status = 'Pago', data_pagamento = default, metodo = '" + cbxMetodo.Text;
                Sql += "', parcelas = 1 WHERE id = '" + PedidoID + "'";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Pagamento do Pedido '" + PedidoID + "'\nRealizado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                Estoque();
            }

            else if (cbxMetodo.Text == "Cartão")
            {
                Sql  = "UPDATE pedido SET status = 'Pago', data_pagamento = 'default', metodo = '" + cbxMetodo.Text;
                Sql += "', parcelas = '" + cbxParcelas.SelectedValue + "' WHERE id = '" + PedidoID + "'";
                BD.ExecutarComandos(Sql);

                MessageBox.Show("Pagamento do Pedido '" + PedidoID + "'\nRealizado com sucesso!", "OurTradeCenter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                Estoque();
            }
        }

        private void mskCPF_TextChanged(object sender, EventArgs e)
        {
            if (mskCPF.TextLength == 14)
            {
                Sql = "SELECT * FROM cliente WHERE cpf = '" + mskCPF.Text + "'";
                DataTable dt = BD.ExecutarConsultas(Sql);

                if (dt.Rows.Count == 1)
                {
                    txtNome.Text = dt.Rows[0]["nome_cartao"].ToString();
                    mskCodCartao.Text = dt.Rows[0]["codigo_cartao"].ToString();
                    cbxBandeira.Text = dt.Rows[0]["bandeira"].ToString();
                    mskValidade.Text = dt.Rows[0]["validade"].ToString();
                    mskCodSeguranca.Text = dt.Rows[0]["codigo_seguranca"].ToString();
                }
            }   
        }
    }
}
