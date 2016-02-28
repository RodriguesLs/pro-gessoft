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
    class ClienteDAO
    {

        private MySqlConnection conexao;

        public void NovoCadastroCliente(Cliente   NovoCliente)
        {

           
            
            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "INSERT INTO Cliente values(null, '" + NovoCliente.Nome + "','" + NovoCliente.CPF + "','" + NovoCliente.RG + "','" + NovoCliente.Email + "','" + NovoCliente.Sexo + "', 'true')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {
             
                throw new Exception("Erro de comandos:" + ex.Message);
            }





        }
        public void NovoCadastroEndereco(Endereco NovoEndereco) {

            Model.Cliente NovoCliente = new Model.Cliente();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdCliente from cliente";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { NovoCliente.Codigo = (Reader.GetInt16("cdCliente")); }
                


            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO Endereco values(null, '" + NovoEndereco.Rua + "','" + NovoEndereco.Bairro + "','" + NovoEndereco.Cidade + "','" + NovoEndereco.Estado + "','" + NovoEndereco.Cep + "','" + NovoEndereco.Numero + "' , '" + NovoEndereco.Complemento + "',  null , null, null, '" + NovoCliente.Codigo + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }
        public void NovoCadastroTelefone(Telefone NovoTelefone)
        {

            Model.Cliente NovoCliente = new Model.Cliente();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdCliente from cliente";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { NovoCliente.Codigo = (Reader.GetInt16("cdCliente")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO Telefones values(null, '" + NovoCliente.Codigo + "',null,'" + NovoTelefone.NResidencial + "','" + NovoTelefone.NCelular + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }

        public void AlterarCadastroCliente(Cliente   AlterarCliente) {


            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "update Cliente set nmCliente= '" + AlterarCliente.Nome + "', cpf= '" + AlterarCliente.CPF + "', rg= '" + AlterarCliente.RG + "', email= '" + AlterarCliente.Email + "', sexo= '" + AlterarCliente.Sexo +"' where cdCliente= " + Gambis.BadCodigo + ";";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);
            }
        }
        public void AlterarCadastroEndereco(Endereco AlterarEndereco)
        {

            Model.Cliente AlterarCliente = new Model.Cliente();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdCliente from cliente";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { AlterarCliente.Codigo = (Reader.GetInt16("cdCliente")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "update Endereco set rua= '" + AlterarEndereco.Rua + "', bairro= '" + AlterarEndereco.Bairro + "', cidade= '" + AlterarEndereco.Cidade + "', estado= '" + AlterarEndereco.Estado + "', cep= '" + AlterarEndereco.Cep +"', numero= '"+AlterarEndereco.Numero+"', complemento= '"+AlterarEndereco.Complemento+"' where cdCliente= " +Gambis.BadCodigo+ ";";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }
        public void AlterarCadastroTelefone(Telefone AlterarTelefone)
        {

            Model.Cliente AlterarCliente = new Model.Cliente();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdCliente from cliente";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { AlterarCliente.Codigo = (Reader.GetInt16("cdCliente")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "update Telefones set nResidencial= '" +AlterarTelefone.NResidencial+ "' , nCelular= '" +AlterarTelefone.NCelular+ "' where cdCliente= " +Gambis.BadCodigo+ ";";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }

        public void ConsutarCadastroCliente() {

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cliente.cdCliente, cliente.nmCliente, cliente.cpf, cliente.rg, cliente.email, cliente.sexo, endereco.cdendereco, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, endereco.numero, endereco.complemento, telefones.nResidencial, telefones.nCelular from cliente inner join endereco on endereco.cdcliente = cliente.cdcliente inner join telefones on telefones.cdCliente = cliente.cdCliente where cliente.cdCliente like '" +Gambis.BadCodigo+ "%';";
            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                 Gambis.ClienteCodigo       = (Reader.GetInt16("cdCliente"));
                 Gambis.ClienteNome         = (Reader.GetString("nmCliente"));
                 Gambis.ClienteCPF          = (Reader.GetString("CPF"));
                 Gambis.ClienteRG           = (Reader.GetString("RG"));
                 Gambis.ClienteEmail        = (Reader.GetString("Email"));
                 Gambis.ClienteSexo         = (Reader.GetString("Sexo"));
                 Gambis.ClienteRua          = (Reader.GetString("Rua"));
                 Gambis.ClienteBairro       = (Reader.GetString("Bairro"));
                 Gambis.ClienteCidade       = (Reader.GetString("Cidade"));
                 Gambis.ClienteEstado       = (Reader.GetString("Estado"));
                 Gambis.ClienteCEP          = (Reader.GetString("CEP"));
                 Gambis.ClienteNumero       = (Reader.GetString("Numero"));
                 Gambis.ClienteComplemento  = (Reader.GetString("Complemento"));
                 Gambis.ClienteNResidencial = (Reader.GetString("NResidencial"));
                 Gambis.ClienteNCelular     = (Reader.GetString("NCelular"));
                  
            }
        }

    }
}
