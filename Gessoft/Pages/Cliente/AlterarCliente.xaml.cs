using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Gessoft.Pages.Cliente;
using Gessoft.Model;
using MySql.Data.MySqlClient;
using Windows.UI.Popups;
using Gessoft.DAO;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Cliente
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AlterarCliente : Page
    {
        public AlterarCliente()
        {
            this.InitializeComponent();
        }

        

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cliente.cdCliente, cliente.nmCliente, cliente.cpf, cliente.rg, cliente.email, cliente.sexo, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, endereco.numero, endereco.complemento, telefones.nResidencial, telefones.nCelular from cliente inner join endereco on endereco.cdcliente = cliente.cdcliente inner join telefones on telefones.cdCliente = cliente.cdCliente where cliente.cdCliente = '" + Gambis.BadCodigo + "'";
            connection.Open();
            Reader = command.ExecuteReader();

            string nmCliente = "";
            string CPF = "";
            string RG = "";
            string tel = "";
            string cel = "";
            string email = "";
            string sexo = "";
            string rua = "";
            string bairro = "";
            string cidade = "";
            string estado = "";
            string cep = "";
            string Numero = "";
            string Complemento = "";

            while (Reader.Read())
            {
                nmCliente = (Reader.GetString("nmCliente"));
                CPF = (Reader.GetString("cpf"));
                RG = (Reader.GetString("RG"));
                tel = (Reader.GetString("nResidencial"));
                cel = (Reader.GetString("nCelular"));
                email = (Reader.GetString("email"));
                sexo = (Reader.GetString("sexo"));
                rua = (Reader.GetString("rua"));
                bairro = (Reader.GetString("bairro"));
                cidade = (Reader.GetString("cidade"));
                estado = (Reader.GetString("estado"));
                cep = (Reader.GetString("cep"));
                Numero = (Reader.GetString("numero"));
                Complemento = (Reader.GetString("complemento"));
            }

            Txt_Alterar_Nome.Text = nmCliente;
            txt_Alterar_CPF.Text = CPF;
            txt_Alterar_RG.Text = RG;
            txt_Alterar_Telefone.Text = tel;
            txt_Alterar_Celular.Text = cel;
            txt_Alterar_Email.Text = email;
            if (sexo == "Masculino")
            {
                rdb_Alterar_Masculino.IsChecked = true;
            }
            else 
            {
                rdb_Alterar_Feminino.IsChecked = true;
            }

            txt_Alterar_Rua.Text = rua;
            txt_Alterar_Bairro.Text = bairro;
            txt_Alterar_Cidade.Text = cidade;
            txt_Alterar_Estado.Text = estado;
            txt_Alterar_CEP.Text = cep;
            txt_Altear_Numero.Text = Numero;
            txt_Altear_Complemento.Text = Complemento;
            connection.Close();

            
      
        

        }

        //========================== BOTÕES DE NAVEGAÇÃO ==================================
        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }
        private void btn_NovoCliente_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Cliente.NovoCliente), null);
        }
        private void btn_AlterarCliente_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Cliente.AlterarCliente), null);
        }
        private void btn_HistoricoCliente_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.Cliente.HistoricoCliente), null);
        }
        private void btn_ConsultarCliente_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.Cliente.ConsultarCliente), null);

            

       
        }
        //=================================================================================

        private void lbl_AlterarCadastro(object sender, ContextMenuEventArgs e)
        {
            
            
        }
        private void btn_Pesquisar_CEP_Click(object sender, RoutedEventArgs e)
        { }

        private async void btn_SalvarCliente(object sender, RoutedEventArgs e)
        {

            Model.Endereco AlterarEndereco = new Model.Endereco();
            Model.Cliente AlterarCliente = new Model.Cliente();
            Model.Telefone AlterarTelefone = new Model.Telefone();

            ClienteDAO DA = new ClienteDAO();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cliente.cdCliente, cliente.nmCliente, cliente.cpf, cliente.rg, cliente.email, cliente.sexo, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, endereco.numero, endereco.complemento, telefones.nResidencial, telefones.nCelular from cliente inner join endereco on endereco.cdcliente = cliente.cdcliente inner join telefones on telefones.cdCliente = cliente.cdCliente where cliente.cdCliente = '" + Gambis.BadCodigo + "'";
            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                AlterarEndereco.CdEndereco = (Reader.GetInt16("cdCliente"));
            }


            //  Cagando o codigo aque :SSS
            

            AlterarCliente.Codigo = Convert.ToInt16(Gambis.BadCodigo);
            AlterarCliente.Nome = Txt_Alterar_Nome.Text;
            AlterarCliente.CPF = txt_Alterar_CPF.Text;
            AlterarCliente.RG = txt_Alterar_RG.Text;
            AlterarCliente.Email = txt_Alterar_Email.Text;
            if (rdb_Alterar_Masculino.IsChecked == true)
            {
                AlterarCliente.Sexo = "Masculino";
                // Sexo = Masculino
            }
            else if (rdb_Alterar_Feminino.IsChecked == true)
            {
                AlterarCliente.Sexo = "Feminino";
                // Sexo = Feminino
            }

            AlterarEndereco.Rua     = txt_Alterar_Rua.Text;
            AlterarEndereco.Bairro  = txt_Alterar_Bairro.Text;
            AlterarEndereco.Cidade  = txt_Alterar_Cidade.Text;
            AlterarEndereco.Estado  = txt_Alterar_Estado.Text;
            AlterarEndereco.Cep     = txt_Alterar_CEP.Text;
            AlterarEndereco.Numero = txt_Altear_Numero.Text;
            AlterarEndereco.Complemento = txt_Altear_Complemento.Text;


            AlterarTelefone.NCelular = txt_Alterar_Celular.Text;
            AlterarTelefone.NResidencial = txt_Alterar_Telefone.Text;

            DA.AlterarCadastroCliente(AlterarCliente);
            DA.AlterarCadastroEndereco(AlterarEndereco);
            DA.AlterarCadastroTelefone(AlterarTelefone);

            MessageDialog MessageDialog = new MessageDialog("Cadastro alterado com sucesso.", "Gessoft");
            await MessageDialog.ShowAsync();

        }

        private void rdb_Alterar_Feminino_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Servicos_Click(object sender, RoutedEventArgs e)
        {

        }

        }
    }

