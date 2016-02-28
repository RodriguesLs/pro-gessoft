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
    public sealed partial class ConsultarOrcamento : Page
    {

        int NumS;
        public ConsultarOrcamento()
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

        private void brn_Local_Orçamento_Click(object sender, RoutedEventArgs e)
        {

        }

        private void brn_Limpar_Campos_Click(object sender, RoutedEventArgs e)
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


        private void Btn_Consultar_Dados_Click(object sender, RoutedEventArgs e)
        {

        }
        //====================================================== BARRA DE CIMA ===========
            
        private async  void  btn_Consultar_Click(object sender, RoutedEventArgs e)
        {
           
            string ClienteID;
            
            string Descricao;
            string NumeroOrcamento = txt_NumeroOrcamento.Text;
            

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaServico where cdOrcamento = '" + NumeroOrcamento + "';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    NumS = (Reader.GetInt16("numS"));
                  txt_Cliente_ID.Text        = ClienteID    = (Reader.GetString("cdCliente"));
                  txt_Descricao_Servico.Text = Descricao    = (Reader.GetString("Descricao"));
                  txt_Dia.Text = (Reader.GetString("Dia"));
                  txt_Mes.Text = (Reader.GetString("Mes"));
                  txt_Ano.Text = (Reader.GetString("Ano"));
                  Gambis.BadCodigo = ClienteID;
                  ClienteDAO DA = new ClienteDAO();
                  DA.ConsutarCadastroCliente();
                  txt_NomeCliente.Text = Gambis.ClienteNome;
                  txt_NumeroOrcamentoPa.Text = NumeroOrcamento;
                    //Data = (Reader.GetString("CPF"));
                }
                if (NumS == 0) {

                    MessageDialog MessageDialog = new MessageDialog("Numero De Orçamento invalido.", "Gessoft");
                    await MessageDialog.ShowAsync();
                    txt_NumeroOrcamento.Text = "";             
                
                }
                
            }
            catch (Exception ex)
            {
              
                throw new Exception("Erro de comandos:" + ex.Message);
          
              
            }
        }

        private void txt_NumeroOrcamentoPa_IsEnabledChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {

        }


    }
}
