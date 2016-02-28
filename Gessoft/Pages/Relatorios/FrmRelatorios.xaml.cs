using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Relatorios
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FrmRelatorios : Page
    {
        public FrmRelatorios()
        {
            this.InitializeComponent();
        }

        string cdPesquisa;

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            int contComServico = 0;


            string MyConString00 = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString00);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaservico where cdOrcamento <> 'null' and cdStatus <> '0' ;";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    contComServico++;
                    txt_OrcamentosComServico.Text = contComServico.ToString();
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }

            //==============================================================================================================
            //==============================================================================================================


            int contOrcamento = 0;

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString00);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaservico where cdOrcamento <> 'null';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    contOrcamento++;
                    txt_OrcamentosCadastrados.Text = contOrcamento.ToString();
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }

//==============================================================================================================
            int contServico = 0;

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString00);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaservico where cdServico <> 'null';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    contServico++;
                    txt_ServicosCadastrados.Text = contServico.ToString();
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }

//===============================================================================================================
            int contCliente = 0;

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString00);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from cliente where cdCliente <> 'null';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    contCliente++;
                    txt_ClienteCadastrados.Text = contCliente.ToString();
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }

//=============================================================================================================

            int contFornecedor = 0;

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString00);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from Fornecedor where cdFornecedor <> 'null';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    contFornecedor++;
                    txt_FornecedoresCadastrados.Text = contFornecedor.ToString();
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            } if (contFornecedor == 0) {
                txt_FornecedoresCadastrados.Text = "0";
            }

//==========================================================================================

            int ContFuncionario = 0;

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString00);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from Funcionario where cdFuncionario <> 'null';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    ContFuncionario++;
                    txt_FuncionariosCadastrados.Text = ContFuncionario.ToString();
                }


            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }


            txt_OrcamentosSemServico.Text = (Convert.ToInt16(txt_OrcamentosCadastrados.Text) - Convert.ToInt16(txt_OrcamentosComServico.Text)).ToString();



        }

        private void Btn_Home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }

        private void btnValidaOcament_Click(object sender, RoutedEventArgs e)
        {



            BadReligion.Items.Clear();
            String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where cdOrcamento like '" + txt_NumeroPesquisa.Text + "%'";
                connection.Open();
                Reader = command.ExecuteReader();




                while (Reader.Read())
                {

                    string cdServico = (Reader.GetString("cdOrcamento"));
                    string nmCliente = (Reader.GetString("nmCliente"));
                    string cidade = (Reader.GetString("cidade"));
                    string estado = (Reader.GetString("estado"));
                    string rua = (Reader.GetString("rua"));
                    string bairro = (Reader.GetString("bairro"));
                    string geracao = (Reader.GetString("dtgeracao"));
                    int codigo = (Reader.GetInt16("NumS"));

                    TextBlock IDOrcamentBlock = new TextBlock();
                    IDOrcamentBlock.Text = "   Nº: " + cdServico + "   Gerado: " + geracao;
                    IDOrcamentBlock.Foreground = new SolidColorBrush(Colors.Black);

                    TextBlock NmCliente = new TextBlock();
                    NmCliente.Text = "   " + nmCliente;
                    NmCliente.Foreground = new SolidColorBrush(Colors.Black);
                    TextBlock DadosEnd = new TextBlock();
                    DadosEnd.Text = "   Cidade: " + cidade + "- " + estado + " \n   Rua: " + rua + "   Bairro: " + bairro;
                    DadosEnd.Foreground = new SolidColorBrush(Colors.Black);

                    StackPanel OrcamentBlock = new StackPanel();
                    OrcamentBlock.Background = new SolidColorBrush(Colors.White);
                    OrcamentBlock.Height = 100;
                    OrcamentBlock.Width = 450;
                    OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                    OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;
                    OrcamentBlock.DataContext = codigo.ToString();



                    ListViewItem RTAM = new ListViewItem();

                    OrcamentBlock.Children.Add(NmCliente);
                    OrcamentBlock.Children.Add(IDOrcamentBlock);
                    OrcamentBlock.Children.Add(DadosEnd);

                    BadReligion.Items.Add(OrcamentBlock);

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }
        }
        private void btnValidaServico_Click(object sender, RoutedEventArgs e)
        {

    

            BadReligion.Items.Clear();
            String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where cdServico like '" + txt_NumeroPesquisa.Text + "%'";
                connection.Open();
                Reader = command.ExecuteReader();




                while (Reader.Read())
                {

                    string cdServico = (Reader.GetString("cdServico"));
                    string nmCliente = (Reader.GetString("nmCliente"));
                    string cidade = (Reader.GetString("cidade"));
                    string estado = (Reader.GetString("estado"));
                    string rua = (Reader.GetString("rua"));
                    string bairro = (Reader.GetString("bairro"));
                    string geracao = (Reader.GetString("dtgeracao"));
                    int codigo = (Reader.GetInt16("NumS"));

                    TextBlock IDOrcamentBlock = new TextBlock();
                    IDOrcamentBlock.Text = "   Nº: " + cdServico + "   Gerado: " + geracao;
                    IDOrcamentBlock.Foreground = new SolidColorBrush(Colors.Black);

                    TextBlock NmCliente = new TextBlock();
                    NmCliente.Foreground = new SolidColorBrush(Colors.Black);
                    NmCliente.Text = "   " + nmCliente;
                    TextBlock DadosEnd = new TextBlock();
                    DadosEnd.Foreground = new SolidColorBrush(Colors.Black);
                    DadosEnd.Text = "   Cidade: " + cidade + "- " + estado + " \n" + "   Rua: " + rua + "   Bairro: " + bairro;


                    StackPanel OrcamentBlock = new StackPanel();
                    OrcamentBlock.Background = new SolidColorBrush(Colors.White);
                    OrcamentBlock.Height = 100;
                    OrcamentBlock.Width = 450;
                    OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                    OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;
                    OrcamentBlock.DataContext = codigo.ToString();


                    ListViewItem RTAM = new ListViewItem();

                    OrcamentBlock.Children.Add(NmCliente);
                    OrcamentBlock.Children.Add(IDOrcamentBlock);
                    OrcamentBlock.Children.Add(DadosEnd);

                    BadReligion.Items.Add(OrcamentBlock);

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }

        }



        private async void brn_Limpar_Campos_Click(object sender, RoutedEventArgs e)
        {
            // Bruxaria do Andre aqui-----> :
            StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
            foreach (TextBlock block in UserBlock.Children)
            {
                cdPesquisa = block.DataContext.ToString();
                //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
            }
            // Bruxaria do Andre aqui-----> :


            string Descricao;

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaServico where NumS = '" + cdPesquisa + "' and dtgeracao <> 'null' and dia <> 'null' and mes <> 'null' and ano <> 'null' ;";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {

                    Descricao = "\n Data de Agendamento: " + (Reader.GetString("dtgeracao"));
                    txt_Descricao_Servico.Text = Descricao = (Reader.GetString("Descricao"));
                    txt_Dia.Text = (Reader.GetString("Dia"));
                    txt_Mes.Text = (Reader.GetString("Mes"));
                    txt_Ano.Text = (Reader.GetString("Ano"));


                }


            }



            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }
        }

        private void txt_FornecedoresCadastrados_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void txt_FornecedoresCadastrados_IsEnabledChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        {

        }






        }

    }

