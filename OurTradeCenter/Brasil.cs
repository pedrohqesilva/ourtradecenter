using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                                                              //Inserir Biblioteca de Dados
using MySql.Data.MySqlClient;  

namespace ControlaEstoque
{
    class Brasil
    {
        MySqlConnection mConn;                                                  //Nomear a classe de Conexão

        //String de Conexão com o Banco de Dados:
        public void ConexaoBD()
        {
            try
            {
                mConn = new MySqlConnection("Persist Security Info = false; server = localhost; database = Brasil; uid = root; Pwd = ");
                mConn.Open();                                                   //Criar e Abrir a Conexão com o  Banco de Dados
            }

            catch (Exception)
            {
                throw;                                                          //Retornar mensagem de erro
            }
        }

        //Método de Execução de Consultas do Banco de Dados:
        public DataTable ExecutarConsultas(string Sql)
        {
            try
            {
                ConexaoBD();                                                    //Conectar com o Banco
                MySqlDataAdapter mAdapter = new MySqlDataAdapter(Sql, mConn);   //Criar o Adaptador
                DataTable dt = new DataTable();                                 //Criar o DataTable
                mAdapter.Fill(dt);                                              //Encher o DataTable

                return dt;                                                      //Retornar o valor do DataTable para o método
            }

            catch (Exception)
            {
                throw;                                                          //Retornar mensagem de erro
            }

            finally
            {
                mConn.Close();                                                  //Fechar Conexão
            }
        }
    }
}
