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
    public sealed partial class NovoServico : Page
    {
        string cont = "1";
        string NSerie = "";
        string NomeFunconario;
        int cdFuncionario;
        public NovoServico()
        {
            this.InitializeComponent();
        }
        string Descricao;
        string ClienteID;
        string NumeroOrcamento;
        string Relatorio; // ÉSS USADA SIM CARA '-'
        string PegueiStatus;
        int cdNumS;
        int cdNumS2;
        int ContMes;
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

        private async void btn_PesquisarOrcamento_Click(object sender, RoutedEventArgs e)
        {




            NumeroOrcamento = txt_NumeroOrcamento.Text;
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
                    cdNumS2 = (Reader.GetInt16("numS"));
                    ClienteID = (Reader.GetString("cdCliente"));
                    Descricao = (Reader.GetString("Descricao"));
                    PegueiStatus = (Reader.GetString("cdStatus"));


                    //Data = (Reader.GetString("CPF"));
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);



            }
            if (cdNumS2 == 0)
            {
                MessageDialog MessageDialog = new MessageDialog("Numero de orçamento invalido.", "Gessoft");
                await MessageDialog.ShowAsync();
                txt_NumeroOrcamento.Text = "";

            }
            else
            {

                Gambis.BadCodigo = ClienteID;
                ClienteDAO Poha = new ClienteDAO();
                Poha.ConsutarCadastroCliente();
                txt_Cliente_ID.Text = ClienteID;
                txt_NomeCliente.Text = Gambis.ClienteNome;
                txt_Descricao_Servico.Text = Relatorio + Descricao;



                string MyConString1 = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString1);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select max(numS) from agendaservico;";
                    connection.Open();
                    Reader = command.ExecuteReader();

                    while (Reader.Read())
                    {
                        cdNumS = (Reader.GetInt16("Max(numS)"));

                        //Data = (Reader.GetString("CPF"));
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }
                txt_NumeroServico.Text = "SF20." + Gambis.BadCodigo + "13." + "A." + cdNumS.ToString() + "-R";





            }
        }

        private async void btn_Agendar_Servico_Click(object sender, RoutedEventArgs e)
        {


            NumeroOrcamento = txt_NumeroOrcamento.Text;
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
                    cdNumS2 = (Reader.GetInt16("numS"));
                    ClienteID = (Reader.GetString("cdCliente"));
                    Descricao = (Reader.GetString("Descricao"));
                    PegueiStatus = (Reader.GetString("cdStatus"));


                    //Data = (Reader.GetString("CPF"));
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);



            }
            if (cdNumS2 == 0)
            {
                MessageDialog MessageDialog = new MessageDialog("Numero de orçamento invalido.", "Gessoft");
                await MessageDialog.ShowAsync();
                txt_NumeroOrcamento.Text = "";

            }


           
//=================================================================================================================================
//==================================================================================== Doidera minha acima cuidado ======================
            Model.AgendaServico NovoServico = new Model.AgendaServico();

            // Falta cadastrar a data de agendamento...

            AgendaServicoDAO DA = new AgendaServicoDAO();

            NovoServico.CdServico = txt_NumeroServico.Text;
            NovoServico.Descricao = txt_Descricao_Servico.Text;
            NovoServico.CodigoCliente = Convert.ToInt16(Gambis.BadCodigo);
            // Um endereço por cliente.
            NovoServico.CodigoEndereco = 1;
            //NovoServico.CodigoUsuario = null;

            TextBlock BlocoMes;
            BlocoMes = (TextBlock)cmbMes.SelectedItem;
            String SelecMes = BlocoMes.Text;

            if (SelecMes == "Janeiro")
            {
                ContMes = 1;
            }
            else if (SelecMes == "Fevereiro")
            {
                ContMes = 2;
            }
            else if (SelecMes == "Março")
            {
                ContMes = 3;
            }
            else if (SelecMes == "Abril")
            {
                ContMes = 4;
            }
            else if (SelecMes == "Maio")
            {
                ContMes = 5;
            }
            else if (SelecMes == "Junho")
            {
                ContMes = 6;
            }
            else if (SelecMes == "Julho")
            {
                ContMes = 7;
            }
            else if (SelecMes == "Agosto")
            {
                ContMes = 8;
            }
            else if (SelecMes == "Setembro")
            {
                ContMes = 9;
            }
            else if (SelecMes == "Outubro")
            {
                ContMes = 10;
            }
            else if (SelecMes == "Novembro")
            {
                ContMes = 11;
            }
            else if (SelecMes == "Dezembro")
            {
                ContMes = 12;
            }

            NovoServico.Mes = ContMes.ToString();

            TextBlock BlocoAno;
            BlocoAno = (TextBlock)cmbAno.SelectedItem;
            String SelecAno = BlocoAno.Text;

            NovoServico.Ano = SelecAno;

            TextBlock BlocoDia;
            BlocoDia = (TextBlock)cmbDia.SelectedItem;
            String SelecDia = BlocoDia.Text;

            if (SelecAno == "" || ContMes == 0 || SelecDia == "")
            {
                MessageDialog MessageDialog1 = new MessageDialog("Selecione alguma data para agendamento.", "Gessoft");
                await MessageDialog1.ShowAsync();
            }
            else
            {

                NovoServico.Dia = SelecDia;

                int barao = Convert.ToInt16(PegueiStatus);
                barao++;
                NovoServico.CdStatus = barao.ToString();
                NovoServico.CdOrcamento = NumeroOrcamento;

                DA.UpDateOrcamento(NovoServico);
                DA.NovoCadastroServico(NovoServico);

                MessageDialog MessageDialog = new MessageDialog("Serviço Agendado com sucesso.", "Gessoft");
                await MessageDialog.ShowAsync();
            }
        }

        private async void btn_Adicionar_Click(object sender, RoutedEventArgs e)
        {
            if (NSerie == txt_NSerie.Text)
            {
                MessageDialog MessageDialog = new MessageDialog("Este funcionário já esta relacionado ao serviço.", "Gessoft");
                await MessageDialog.ShowAsync();
                txt_NSerie.Text = "";
            }
            else
            {

                NSerie = txt_NSerie.Text;



                string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select * from Funcionario where serie = '" + NSerie + "';";
                    connection.Open();
                    Reader = command.ExecuteReader();

                    while (Reader.Read())
                    {
                        cdFuncionario = (Reader.GetInt16("cdFuncionario"));
                        NomeFunconario = (Reader.GetString("nmFuncionario"));

                        //Data = (Reader.GetString("CPF"));
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);



                }
                if (cdFuncionario == 0)
                {
                    MessageDialog MessageDialog = new MessageDialog("Numero de série invalido.", "Gessoft");
                    await MessageDialog.ShowAsync();
                }
                else
                {

                    if (cont == "1")
                    {
                        txt_Gesseiro.Text = NomeFunconario;
                        Descricao = Descricao + "\n " + "\n" +
                            

                        "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n" +
                        "Funcionários envolvidos \n" +
                        "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n" +
                        "Nº" + txt_NSerie.Text + "    " + NomeFunconario + "\n";
                        txt_Descricao_Servico.Text = Descricao;

                        cont = "2";
                    }
                    else
                    {
                        Descricao = Descricao + "Nº" + txt_NSerie.Text + "    " + txt_Gesseiro.Text + "\n";
                        txt_Descricao_Servico.Text = Descricao;
                    }
                }
            }
        }



                //====================================================== BARRA DE CIMA ===========

            //}
        //}

        private void brn_Limpar_Campos_Click(object sender, RoutedEventArgs e)
        {
            Descricao = "";
             cont = "1";
         NSerie = "";
         NomeFunconario = "";
         txt_Cliente_ID.Text = "";
         txt_Descricao_Servico.Text = "";
         txt_Gesseiro.Text = "";
         txt_NomeCliente.Text = "";
         txt_NSerie.Text = "";
         txt_NumeroOrcamento.Text = "";
            


        }
    }
}
