using Gessoft.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Cliente
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HistoricoCliente : Page
    {
        public HistoricoCliente()
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

            //============================================= ISSO AQUI PRA PREENCHER O LIST DE ORÇAMENTOS=========================>>
            lsbOrcamento.Items.Clear();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from Cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where cliente.cdCliente = " + Gambis.BadCodigo + " and cdOrcamento <> 'null' and Dia <> 'null' and Mes <> 'null' and Ano <> 'null' and dtgeracao <> 'null';";
            connection.Open();
            Reader = command.ExecuteReader();

            int cont = 0;
            string cdOrcamento;
            string ClienteNome;
            string DiaAgendameto;
            string MesAgendameto;
            string AnoAgendameto;
            string DataGeracao;


            while (Reader.Read())
            {

                cont++;

                cdOrcamento = (Reader.GetString("cdOrcamento"));
                ClienteNome = (Reader.GetString("nmCliente"));
                DiaAgendameto = (Reader.GetString("dia"));
                MesAgendameto = (Reader.GetString("mes"));
                AnoAgendameto = (Reader.GetString("ano"));
                DataGeracao = (Reader.GetString("dtgeracao"));



                TextBlock Orcamento = new TextBlock();
                Orcamento.Text = " Orçamento Nº: " + cdOrcamento;
                Orcamento.FontSize = 20;
                Orcamento.FontWeight = FontWeights.Bold;
                Orcamento.Foreground = new SolidColorBrush(Colors.Black);
                Orcamento.TextAlignment = TextAlignment.Left;
                Orcamento.VerticalAlignment = VerticalAlignment.Center;


                TextBlock Data = new TextBlock();
                Data.Text = "  Data de agendamento: " + DiaAgendameto + "/" + MesAgendameto + "/" + AnoAgendameto;
                Data.FontSize = 13;
                Data.Foreground = new SolidColorBrush(Colors.Black);
                Data.TextAlignment = TextAlignment.Left;
                Data.VerticalAlignment = VerticalAlignment.Center;


                TextBlock DataGera = new TextBlock();
                DataGera.Text = "  Data de Criação: " + DataGeracao;
                DataGera.FontSize = 13;
                DataGera.Foreground = new SolidColorBrush(Colors.Black);
                DataGera.TextAlignment = TextAlignment.Left;
                DataGera.VerticalAlignment = VerticalAlignment.Center;

                StackPanel UserBlock = new StackPanel();
                UserBlock.Background = new SolidColorBrush(Colors.SkyBlue);
                UserBlock.Height = 110;
                UserBlock.Width = 650;
                UserBlock.VerticalAlignment = VerticalAlignment.Center;
                UserBlock.HorizontalAlignment = HorizontalAlignment.Center;


                UserBlock.Children.Add(Orcamento);
                UserBlock.Children.Add(Data);
                UserBlock.Children.Add(DataGera);


                lsbOrcamento.Items.Add(UserBlock);
            }
            connection.Close();
        
                // ===============================================================================================================>>


            lsbServico.Items.Clear();

            string MyConString2 = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection2 = new MySqlConnection(MyConString2);
            MySqlCommand command2 = connection2.CreateCommand();
            MySqlDataReader Reader2;
            command2.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from Cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where cliente.cdCliente = " + Gambis.BadCodigo + " and cdServico <> 'null' and Dia <> 'null' and Mes <> 'null' and Ano <> 'null' and dtgeracao <> 'null';";
            connection2.Open();
            Reader2 = command2.ExecuteReader();

            int contS = 0;
            string cdServico;
            string ClienteNomeS;
            string DiaAgendametoS;
            string MesAgendametoS;
            string AnoAgendametoS;
            string DataGeracaoS;

            while (Reader2.Read())
            {

                cont++;

                cdServico = (Reader2.GetString("cdServico"));
                ClienteNomeS = (Reader2.GetString("nmCliente"));
                DiaAgendametoS = (Reader2.GetString("dia"));
                MesAgendametoS = (Reader2.GetString("mes"));
                AnoAgendametoS = (Reader2.GetString("ano"));
                DataGeracaoS = (Reader2.GetString("dtgeracao"));



                TextBlock Servico = new TextBlock();
                Servico.Text = " Serviço Nº: " + cdServico;
                Servico.FontSize = 20;
                Servico.FontWeight = FontWeights.Bold;
                Servico.Foreground = new SolidColorBrush(Colors.Black);
                Servico.TextAlignment = TextAlignment.Left;
                Servico.VerticalAlignment = VerticalAlignment.Center;


                TextBlock DataS = new TextBlock();
                DataS.Text = "  Data de agendamento: " + DiaAgendametoS + "/" + MesAgendametoS + "/" + AnoAgendametoS;
                DataS.FontSize = 13;
                DataS.Foreground = new SolidColorBrush(Colors.Black);
                DataS.TextAlignment = TextAlignment.Left;
                DataS.VerticalAlignment = VerticalAlignment.Center;


                TextBlock DataGeraS = new TextBlock();
                DataGeraS.Text = "  Data de Criação: " + DataGeracaoS;
                DataGeraS.FontSize = 13;
                DataGeraS.Foreground = new SolidColorBrush(Colors.Black);
                DataGeraS.TextAlignment = TextAlignment.Left;
                DataGeraS.VerticalAlignment = VerticalAlignment.Center;

                StackPanel UserBlockS = new StackPanel();
                UserBlockS.Background = new SolidColorBrush(Colors.SkyBlue);
                UserBlockS.Height = 110;
                UserBlockS.Width = 650;
                UserBlockS.VerticalAlignment = VerticalAlignment.Center;
                UserBlockS.HorizontalAlignment = HorizontalAlignment.Center;


                UserBlockS.Children.Add(Servico);
                UserBlockS.Children.Add(DataS);
                UserBlockS.Children.Add(DataGeraS);


                lsbServico.Items.Add(UserBlockS);
            }
            connection.Close();

            //.Children.Add(UserBlock); Width="452" Height="126"


            //ListBox1.Items.Add(codigo+"--"+email+"--"+nome);

            //new TextBlock() { Name = "teste", Text = "Olaaaaaaaaa poha ", FontSize = 50 };
            //new TextBox() { Name = "asd", Width=11, Height=11 };




          

               






            
        }

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

        private void btn_Servicos_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
