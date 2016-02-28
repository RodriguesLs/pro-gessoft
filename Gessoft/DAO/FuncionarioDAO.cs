using Gessoft.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gessoft.DAO
{
    class FuncionarioDAO
    {
        private MySqlConnection conexao;

        //public void NovoCadastroDepartamento(Departamento NovoDepartamento)
        //{


        //    String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
        //    try
        //    {
        //        conexao = new MySqlConnection(caminho);
        //        conexao.Open();

        //        String inserir = "INSERT INTO Depto values(null,'Funcionario')";
        //        MySqlCommand comandos = new MySqlCommand(inserir, conexao);
        //        comandos.ExecuteNonQuery();
        //        conexao.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro de comandos:" + ex.Message);
        //    }

        //}
        //public void NovoCadastroCargo(Cargo NovoCargo)
        //{

        //    String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
        //    try
        //    {
        //        conexao = new MySqlConnection(caminho);
        //        conexao.Open();

        //        String inserir = "INSERT INTO Cargo values(null,'Funcionario')";
        //        MySqlCommand comandos = new MySqlCommand(inserir, conexao);
        //        comandos.ExecuteNonQuery();
        //        conexao.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro de comandos:" + ex.Message);
        //    }

        //}
        public void NovoCadastroFuncionario(Funcionario NovoFuncionario)
        {
            

           
            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "INSERT INTO Funcionario values(null, '" + NovoFuncionario.Nome + "','" + NovoFuncionario.CPF + "','" + NovoFuncionario.RG + "','" + NovoFuncionario.Email + "','" + NovoFuncionario.Sexo + "','" + NovoFuncionario.NCarteira + "','" + NovoFuncionario.NSerie + "','" + NovoFuncionario.TemFilhos + "','" + NovoFuncionario.NomePai + "','" + NovoFuncionario.NomeMae + "','" + NovoFuncionario.QuantosFilhos + "','" + NovoFuncionario.TemReservista + "','" + NovoFuncionario.NReservista + "','"+ NovoFuncionario.Nasimento +"','"+ NovoFuncionario.Depto +"','"+ NovoFuncionario.Cargo +"', 'true')";
                // TA FALTANDO A INSERÇAO DA DATA E DA RESERVISTA MAIS TUDIO BEM..
                
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);
            }





        }
        public void NovoCadastroEndereco(Endereco NovoEndereco)
        {

            Model.Funcionario NovoFuncionario = new Model.Funcionario();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdFuncionario from Funcionario";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { NovoFuncionario.Codigo = (Reader.GetInt16("cdFuncionario")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO Endereco values(null, '" + NovoEndereco.Rua + "','" + NovoEndereco.Bairro + "','" + NovoEndereco.Cidade + "','" + NovoEndereco.Estado + "','" + NovoEndereco.Cep + "','" + NovoEndereco.Numero + "' , '" + NovoEndereco.Complemento + "',  null ,'" + NovoFuncionario.Codigo + "', null,null )"; 
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

            Model.Funcionario NovoFuncionario = new Model.Funcionario();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cdFuncionario from Funcionario";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            { NovoFuncionario.Codigo = (Reader.GetInt16("cdFuncionario")); }



            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();

                String inserir = "INSERT INTO Telefones values('" + NovoFuncionario.Codigo + "',null,null,'" + NovoTelefone.NResidencial + "','" + NovoTelefone.NCelular + "')";
                MySqlCommand comandos = new MySqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos:" + ex.Message);
            }

        }

    public void AlterarCadastroFuncionario(Funcionario AlterarFuncionario)
        {


            String caminho = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                conexao = new MySqlConnection(caminho);
                conexao.Open();
                String inserir = "update Funcionario set nmFuncionario= '" + AlterarFuncionario.Nome + "', cpf= '" + AlterarFuncionario.CPF + "', rg= '" + AlterarFuncionario.RG + "', email= '" + AlterarFuncionario.Email + "', sexo= '" + AlterarFuncionario.Sexo + "', carteiraTrabalho='" + AlterarFuncionario.NCarteira + "', serie ='" + AlterarFuncionario.NSerie + "', icFilhos = '" + AlterarFuncionario.TemFilhos + "', nmPai='" + AlterarFuncionario.NomePai + "', nmMae= '" + AlterarFuncionario.NomeMae + "', qtFilhos='" + AlterarFuncionario.QuantosFilhos +"', reservista='"+AlterarFuncionario.TemReservista+"', cdReservista='"+AlterarFuncionario.NReservista+"', dtNascimento='"+AlterarFuncionario.Nasimento+"', nmDepto='"+AlterarFuncionario.Depto+"', nmCargo='"+AlterarFuncionario.Cargo+"', cdStatus='True'   where cdFuncionario= " + Gambis.Funcionario + ";";
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

                String inserir = "update Endereco set rua= '" + AlterarEndereco.Rua + "', bairro= '" + AlterarEndereco.Bairro + "', cidade= '" + AlterarEndereco.Cidade + "', estado= '" + AlterarEndereco.Estado + "', cep= '" + AlterarEndereco.Cep + "', numero= '" + AlterarEndereco.Numero + "', complemento= '" + AlterarEndereco.Complemento + "' where cdFuncionario= " + Gambis.Funcionario + ";";
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

                String inserir = "update Telefones set nResidencial= '" + AlterarTelefone.NResidencial + "' , nCelular= '" + AlterarTelefone.NCelular + "' where cdCliente= " + Gambis.Funcionario + ";";
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
