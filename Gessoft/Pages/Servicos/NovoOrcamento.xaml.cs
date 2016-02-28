using Gessoft.DAO;
using Gessoft.Model;
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
using Gessoft.Model;
using Windows.UI.Popups;
using MySql.Data.MySqlClient;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Servicos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NovoOrcamento : Page
    {

        int cdNumS;
        public NovoOrcamento()
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
            txt_Cliente_ID.Text = "";
            txt_Descricao_Servico.Text = "";
            txt_Medida.Text = "";
            txt_NomeCliente.Text = "";
            txt_NumeroOrcamento.Text = "";
            //cmb_Ambiente.SelectedIndex.Equals(0);
            //cmb_Material.SelectedIndex.Equals(0);
            //cmb_TipoDeServico.SelectedItem.Equals(0);




            if (Gambis.BadCodigo == null || Gambis.ClienteNome == null) { }
            else
            {
                txt_Cliente_ID.Text = Gambis.BadCodigo;
                txt_NomeCliente.Text = Gambis.ClienteNome;

                //--------------------------------------------------------------Gerando um codigo orçamento----------





                string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
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
                txt_NumeroOrcamento.Text = "O20." + Gambis.BadCodigo + "13.G" + cdNumS.ToString() + "-B";

                txt_Descricao_Servico.Text = Descrição =
                    "\n"+
                     
                     "Dados Do Cliente \n"+
                     "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n" +
                    Gambis.ClienteNome + "\n" +
                    "Rua: " + Gambis.ClienteRua + ",    Numero: " + Gambis.ClienteNumero + ",    " +
                    "Complemento: " + Gambis.ClienteComplemento + ",    Bairro: " + Gambis.ClienteBairro + ",   " +
                    "Cidade: " + Gambis.ClienteCidade + ",    Estado: " + Gambis.ClienteEstado + "\n" +
                    "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n";




            };

        }

        string Descrição;
        string TipoDeServico = "1";
        string Ambiente = "2";

        string txtTipoDeServico;
        string txtAmbiente;
        string txtMaterial;
        string cont = "1";
        int ContMes;

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
        //====================================================== BARRA DE CIMA ===========

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void brn_Limpar_Campos_Click(object sender, RoutedEventArgs e)
        {
            txt_Cliente_ID.Text = "";
            txt_Descricao_Servico.Text = "";
            txt_Medida.Text = "";
            txt_NomeCliente.Text = "";
            txt_NumeroOrcamento.Text = "";
            cmb_Ambiente.SelectedIndex = -1;
            cmb_Material.SelectedIndex = -1;
            cmb_TipoDeServico.SelectedIndex = -1;
            cmbDia.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;
            cmbAno.SelectedIndex = -1;

            Descrição = "";


            //txt_Descricao_Servico.Text += ((TextBlock)cmb_agora.SelectedItem).Text;

            //txt_Descricao_Servico.Text += cmb_agora.SelectedValue.ToString();

            //Pegando um  valor do combo box;
            //TextBlock bloco;
            //bloco = (TextBlock)cmb_agora.SelectedItem;
            //txt_Descricao_Servico.Text += bloco.Text;

        }

        private async void btn_Agendar_Orcamento_Click(object sender, RoutedEventArgs e)
        {
            if ((cmbDia.SelectedIndex == -1) || (cmbMes.SelectedIndex == -1) || (cmbAno.SelectedIndex == -2))
            {

                MessageDialog MessageDialog1 = new MessageDialog("Selecione alguma data para agendamento.", "Gessoft");
                await MessageDialog1.ShowAsync();
            }
            else if((txt_Cliente_ID.Text == "") || (txt_Descricao_Servico.Text == "") || (txt_Medida.Text == "") || (cmb_Ambiente.SelectedIndex == -1) || (cmb_Material.SelectedIndex == -1)) {

              MessageDialog MessageDialog3 = new MessageDialog("Preencha todos os campos.", "Gessoft");
                await MessageDialog3.ShowAsync();
            }
            else
            {

                Model.AgendaServico NovoOrcamento = new Model.AgendaServico();

                // Falta cadastrar a data de agendamento...

                AgendaServicoDAO DA = new AgendaServicoDAO();

                NovoOrcamento.CdOrcamento = txt_NumeroOrcamento.Text;
                NovoOrcamento.Descricao = txt_Descricao_Servico.Text;
                NovoOrcamento.CodigoCliente = Convert.ToInt16(Gambis.BadCodigo);
                // Um endereço por cliente.
                NovoOrcamento.CodigoEndereco = 1;
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

                NovoOrcamento.Mes = ContMes.ToString();

                TextBlock BlocoAno;
                BlocoAno = (TextBlock)cmbAno.SelectedItem;
                String SelecAno = BlocoAno.Text;

                NovoOrcamento.Ano = SelecAno;

                TextBlock BlocoDia;
                BlocoDia = (TextBlock)cmbDia.SelectedItem;
                String SelecDia = BlocoDia.Text;

                NovoOrcamento.Dia = SelecDia;

                DA.NovoCadastroOrcamento(NovoOrcamento);

                MessageDialog MessageDialog2 = new MessageDialog("Orçamento agendado com sucesso.", "Gessoft");
                await MessageDialog2.ShowAsync();

            }
        }

        private async void btn_Adicionar_Click(object sender, RoutedEventArgs e)
        {
            if ((cmb_Ambiente.SelectedIndex == -1) || (cmb_Material.SelectedIndex == -1) || (cmb_TipoDeServico.SelectedIndex == -1) || (txt_Medida.Text == "") || (txt_NomeCliente.Text == "") || (txt_Cliente_ID.Text == ""))
            {
                MessageDialog MessageDialog = new MessageDialog("Preencha todos os campos.", "Gessoft");
                await MessageDialog.ShowAsync();
            }
            else
            {


                TextBlock BlocoTipoServico;
                BlocoTipoServico = (TextBlock)cmb_TipoDeServico.SelectedItem;
                txtTipoDeServico = BlocoTipoServico.Text;

                TextBlock BlocoAmbiente;
                BlocoAmbiente = (TextBlock)cmb_Ambiente.SelectedItem;
                txtAmbiente = BlocoAmbiente.Text;

                TextBlock BlocoMaterial;
                BlocoMaterial = (TextBlock)cmb_Material.SelectedItem;
                txtMaterial = BlocoMaterial.Text;

                if (TipoDeServico == "1" && Ambiente == "2")
                {



                    TipoDeServico = txtTipoDeServico;
                    Ambiente = txtAmbiente;

                    Descrição = Descrição + "Ambiente: " + Ambiente + " - "
                                 + "Serviço: " + TipoDeServico + "\n \n"
                                 + "Material: " + txtMaterial + "   Medida: " + txt_Medida.Text;
                    txt_Descricao_Servico.Text = Descrição;

                }
                else if (TipoDeServico == txtTipoDeServico && Ambiente == txtAmbiente)
                {
                    Descrição = Descrição + "\nMaterial: " + txtMaterial + "   Medida: " + txt_Medida.Text;
                    txt_Descricao_Servico.Text = Descrição;
                }
                else
                {
                    TipoDeServico = txtTipoDeServico;
                    Ambiente = txtAmbiente;

                    Descrição = Descrição + "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨\n"
                                + "Ambiente: " + Ambiente + " - "
                                + "Serviço: " + TipoDeServico + "\n \n"
                                + "Material: " + txtMaterial + "   Medida: " + txt_Medida.Text;

                    txt_Descricao_Servico.Text = Descrição;
                }




            }
        }

        private async void btn_Validar_Click(object sender, RoutedEventArgs e)
        {
            Gambis.BadCodigo = txt_Cliente_ID.Text;

            ClienteDAO DA = new ClienteDAO();
            DA.ConsutarCadastroCliente();
            if (Gambis.ClienteCodigo.ToString() == "0")
            {
                MessageDialog MessageDialog = new MessageDialog("Cliente ID invalido.","Gessoft");
                await MessageDialog.ShowAsync();
                txt_Cliente_ID.Text = "";

            }
            else
            {

                if (Gambis.BadCodigo == null)
                {
                    //MessageDialog MessageDialog = new MessageDialog("Cliente nao exipe krilho.", "Gessoft");
                    //await MessageDialog.ShowAsync();
                }
                else
                {
                    txt_Cliente_ID.Text = Gambis.BadCodigo;
                    txt_NomeCliente.Text = Gambis.ClienteNome;

                    //--------------------------------------------------------------Gerando um codigo orçamento----------





                    string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                    try
                    {
                        MySqlConnection connection = new MySqlConnection(MyConString);
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
                    txt_NumeroOrcamento.Text = "O20." + Gambis.BadCodigo + "13.G" + cdNumS.ToString() + "-B";
                    
                    txt_Descricao_Servico.Text = Descrição =
               Gambis.ClienteNome + "\n" +
               "Rua: " + Gambis.ClienteRua + "     Numero: " + Gambis.ClienteNumero + ",     " +
               "Complemento: " + Gambis.ClienteComplemento + "     Bairro: " + Gambis.ClienteBairro + "\n" +
               "Cidade: " + Gambis.ClienteCidade + "       Estado: " + Gambis.ClienteEstado + "\n" +
               "¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨";


                }

            }
        }
    }
}
