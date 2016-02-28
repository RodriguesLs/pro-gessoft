using Gessoft.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.DAO
{
    class ServicoDAO
    {
        private MySqlConnection conexao;

        public void NovoCadastroServico(Servico NovoServico)
        {
            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "INSERT INTO agendaservico values(null, '" + NovoServico.Descricao + "', null ,'" + NovoServico.CodigoCliente + "','" + NovoServico.CodigoEndereco + "');";
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
