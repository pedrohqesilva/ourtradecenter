using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                                                              //Inserir Biblioteca de Dados
using MySql.Data.MySqlClient;                                                   //Inserir Biblioteca do MySql

namespace ControlaEstoque
{
    class ConexaoBanco
    {
        MySqlConnection mConn;                                                  //Nomear a classe de Conexão

        //String de Conexão com o Banco de Dados:
        public void ConexaoBD()
        {
            try
            {
                mConn = new MySqlConnection("Persist Security Info = false; server = localhost; database = OurTradeCenter; uid = root; Pwd = ");
                mConn.Open();                                                   //Criar e Abrir a Conexão com o  Banco de Dados
            }

            catch (Exception)
            {
                throw;                                                          //Retornar mensagem de erro
            }
        }

        //Método de Execução de strings do Banco de Dados:
        public void ExecutarComandos(string Sql)
        { 
            try
            {
                ConexaoBD();                                                    //Conectar com o Banco
                MySqlCommand mCmd = new MySqlCommand(Sql, mConn);               //Inserir o Comando Sql
                mCmd.ExecuteNonQuery();                                         //Executar o Comando Sql
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
