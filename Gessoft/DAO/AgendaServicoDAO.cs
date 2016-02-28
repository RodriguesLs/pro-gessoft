using Gessoft.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace Gessoft.DAO
{
    class AgendaServicoDAO
    {

        private MySqlConnection conexao;

         public void NovoCadastroOrcamento(AgendaServico NovoOrcamento)
        {

            

            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "INSERT INTO agendaservico (cdorcamento, descricao, cdcliente, dia, mes, ano) values('" + NovoOrcamento.CdOrcamento + "', '" + NovoOrcamento.Descricao + "','" + NovoOrcamento.CodigoCliente + "','" + NovoOrcamento.Dia + "','" + NovoOrcamento.Mes + "','" + NovoOrcamento.Ano + "');";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }





        }

         public void NovoCadastroServico(AgendaServico NovoServico)
        {
            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "INSERT INTO agendaservico (cdservico, descricao, cdcliente, dia, mes, ano) values('" + NovoServico.CdServico + "', '" + NovoServico.Descricao + "','" + NovoServico.CodigoCliente + "','" + NovoServico.Dia + "','" + NovoServico.Mes + "','" + NovoServico.Ano + "');";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }





        }

         public void ConsultaOrcamento(AgendaServico ConsultaServico)
        {


            String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaservico where mes = '" + ConsultaServico.Mes + "' and ano = '" + ConsultaServico.Ano + "' and dia = '"+ConsultaServico.Dia+" and cdOrcamento <> 'null' ';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    ConsultaServico.CdOrcamento = (Reader.GetInt16("cdOrcamento")).ToString();

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }





        }

         public void UpDateOrcamento(AgendaServico NovoOrcamento)
         {



             String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
             try
             {
                 conexao = new MySqlConnection(caminho);
                 conexao.Open();
                 String inserir = "update agendaservico set cdStatus = '"+NovoOrcamento.CdStatus+"' where cdOrcamento='"+NovoOrcamento.CdOrcamento+"';";
                 MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                 comandos.ExecuteNonQuery();
                 conexao.Close();
             }
             catch (Exception ex)
             {

                 throw new Exception("Erro de comandos:" + ex.Message);


             }





         }
    }
}


