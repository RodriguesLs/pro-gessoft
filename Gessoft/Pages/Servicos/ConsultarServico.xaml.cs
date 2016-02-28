using Gessoft.DAO;
using Gessoft.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Servicos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConsultarServico : Page
    {
        string NumServico;
        string ClienteID;
        string Descricao;
        string Relatorio;
        int cdNumS2;


        public ConsultarServico()
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
        }
        //====================================================== BARRA DE CIMA ===========
        private void Btn_Novo_Orcamento_Click(object sender, RoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(Pages.Servicos.NovoOrcamento), null);
        }
        private void Btn_Consultar_Orcamento_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Servicos.ConsultarOrcamento), null);
        }
        private void Btn_Novo_Servico_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Servicos.NovoServico), null);
        }
        private void Btn_Consultar_Servico_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Servicos.ConsultarServico), null);
        }
        private void Btn_Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }

        private void brn_Consutar_Dados_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

    
        //====================================================== BARRA DE CIMA ===========
        private async void btn_PesquisarOrcamento_Click(object sender, RoutedEventArgs e)
        {


            NumServico = txt_NServico.Text;
            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaServico where cdServico = '" + NumServico + "';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    cdNumS2 = (Reader.GetInt16("numS"));
                    ClienteID = (Reader.GetString("cdCliente"));
                    Descricao = (Reader.GetString("Descricao"));
                    txt_Dia.Text = (Reader.GetString("Dia"));
                    txt_Mes.Text = (Reader.GetString("Mes"));
                    txt_Ano.Text = (Reader.GetString("Ano"));

                    //Data = (Reader.GetString("CPF"));
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);



            }
            if (cdNumS2 == 0)
            {
                MessageDialog MessageDialog = new MessageDialog("Numero de serviço invalido.", "Gessoft");
                await MessageDialog.ShowAsync();
                txt_NServico.Text = "";

            }
            else
            {

                Gambis.BadCodigo = ClienteID;
                ClienteDAO Poha = new ClienteDAO();
                Poha.ConsutarCadastroCliente();
                txt_Cliente_ID.Text = ClienteID;
                txt_NomeCliente.Text = Gambis.ClienteNome;
                txt_Descricao_Servico.Text = Relatorio + Descricao;
                txt_NumeroServico.Text = NumServico;
            }


        }

        private void brn_Limpar_Campos_Click(object sender, RoutedEventArgs e)
        {
            Descricao = "";
            
       
            txt_Cliente_ID.Text = "";
            txt_Descricao_Servico.Text = "";
         
            txt_NomeCliente.Text = "";
          
            txt_NServico.Text = "";
            txt_NumeroServico.Text = "";
        }
    }
}
