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
    class FornecedorDAO
    {

    private MySqlConnection conexao;

        public void NovoCadastroFornecedor(Fornecedor NovoFornecedor)
        {



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "INSERT INTO fornecedor values(null, '" + NovoFornecedor.Razao + "','" + NovoFornecedor.Fantasia + "','" + NovoFornecedor.CNPJ + "','" + NovoFornecedor.Email + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);
            }




        }//Metodo Cadastro Fornecedor
        public void NovoCadastroEndereco(Endereco NovoEndereco)
        {

            Model.Fornecedor NovoForncecedor = new Model.Fornecedor();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdFornecedor from fornecedor";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { NovoForncecedor.Codigo = (Reader.GetInt16("cdFornecedor")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO Endereco values(null, '" + NovoEndereco.Rua + "','" + NovoEndereco.Bairro + "','" + NovoEndereco.Cidade + "','" + NovoEndereco.Estado + "','" + NovoEndereco.Cep + "','" + NovoEndereco.Numero + "' , '" + NovoEndereco.Complemento + "',  null , null, '" + NovoForncecedor.Codigo + "',null)";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }//Metodo Cadastro Endereco Fornecedor
        public void NovoCadastroTelefone(Telefone NovoTelefone)
        {

            Model.Fornecedor NovoFornecedor = new Model.Fornecedor();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdFornecedor from fornecedor";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { NovoFornecedor.Codigo = (Reader.GetInt16("cdFornecedor")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO Telefones values(null, null, '" + NovoFornecedor.Codigo + "','" + NovoTelefone.NResidencial + "','" + NovoTelefone.NCelular + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }

        public void AlterarCadastroFornecedor(Fornecedor AlterarFornecedor)
        {


            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "update Fornecedor set nmRazao= '" + AlterarFornecedor.Razao + "', nmFantasia= '" + AlterarFornecedor.Fantasia + "', cdCNPJ= '" + AlterarFornecedor.CNPJ + "', email= '" + AlterarFornecedor.Email + "' where cdFornecedor= " + Gambis.Fornecedor + ";";
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





            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "update Endereco set rua= '" + AlterarEndereco.Rua + "', bairro= '" + AlterarEndereco.Bairro + "', cidade= '" + AlterarEndereco.Cidade + "', estado= '" + AlterarEndereco.Estado + "', cep= '" + AlterarEndereco.Cep + "', numero= '" + AlterarEndereco.Numero + "', complemento= '" + AlterarEndereco.Complemento + "' where cdFuncionario= " + Gambis.Fornecedor + ";";
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

                String inserir = "update Telefones set nResidencial= '" + AlterarTelefone.NResidencial + "' , nCelular= '" + AlterarTelefone.NCelular + "' where cdCliente= " + Gambis.Fornecedor + ";";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }
    
    
    }//class NovoCadastroFornecedor

        
}//main
