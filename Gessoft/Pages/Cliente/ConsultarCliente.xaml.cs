using Gessoft.DAO;
using Gessoft.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
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
    public sealed partial class ConsultarCliente : Page
    {
        public string CodigoBad = "";

        
        public ConsultarCliente()
        {
            this.InitializeComponent();
        }

       
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        /// 

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        //========================== BOTÕES DE NAVEGAÇÃO =================================
        private void btn_NovoCliente_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Cliente.NovoCliente), null);
        }
        private async void btn_AlterarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (BadReligion.SelectedIndex < 0) //UI UI OPERADORES LOGICOS EM CS '0'
            {
                MessageDialog MessageDialog = new MessageDialog("Selecione um cliente.", "Gessoft");
                await MessageDialog.ShowAsync();
            }
            else
            {
                // Bruxaria do Andre aqui-----> :
                StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
                foreach (TextBlock block in UserBlock.Children)
                {
                    Gambis.BadCodigo = block.DataContext.ToString();
                    //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
                }
                // Bruxaria do Andre aqui-----> :
                ClienteDAO DA = new ClienteDAO();
                DA.ConsutarCadastroCliente();

                this.Frame.Navigate(typeof(Pages.Cliente.AlterarCliente), null);
            }
        }
        private async void btn_HistoricoCliente_Click(object sender, RoutedEventArgs e)
        {
            if (BadReligion.SelectedIndex < 0) //UI UI OPERADORES LOGICOS EM CS '0'
            {
                MessageDialog MessageDialog = new MessageDialog("Selecione um cliente.", "Gessoft");
                await MessageDialog.ShowAsync();
            }
            else
            {
                // Bruxaria do Andre aqui-----> :
                StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
                foreach (TextBlock block in UserBlock.Children)
                {
                    Gambis.BadCodigo = block.DataContext.ToString();
                    //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
                }
                // Bruxaria do Andre aqui-----> :
                ClienteDAO DA = new ClienteDAO();
                DA.ConsutarCadastroCliente();

                this.Frame.Navigate(typeof(Pages.Cliente.HistoricoCliente), null);
            }
            
        }
        private async void btn_Servicos_Click(object sender, RoutedEventArgs e)
        {

            if (BadReligion.SelectedIndex < 0) //UI UI OPERADORES LOGICOS EM CS '0'
            {
                MessageDialog MessageDialog = new MessageDialog("Selecione um cliente.", "Gessoft");
                await MessageDialog.ShowAsync();
            }
            else
            {
                // Bruxaria do Andre aqui-----> :
                StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
                foreach (TextBlock block in UserBlock.Children)
                {
                    Gambis.BadCodigo = block.DataContext.ToString();
                    //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
                }
                // Bruxaria do Andre aqui-----> :
                ClienteDAO DA = new ClienteDAO();
                DA.ConsutarCadastroCliente();

                this.Frame.Navigate(typeof(Pages.Servicos.NovoOrcamento), null);
            }
            
        }
        private void btn_ConsultarCliente_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.Cliente.ConsultarCliente), null);
        }
        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {

            if (BadReligion.SelectedIndex < 0) //UI UI OPERADORES LOGICOS EM CS '0'
            {

                this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
            }
            else
            {
                // Bruxaria do Andre aqui-----> :
                StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
                foreach (TextBlock block in UserBlock.Children)
                {
                    Gambis.BadCodigo = block.DataContext.ToString();
                    //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
                }
                // Bruxaria do Andre aqui-----> :
                ClienteDAO DA = new ClienteDAO();
                DA.ConsutarCadastroCliente();
                this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
            }
        }

        //================================================================================




 
        private void BtnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            string PesuisaNome = "";
            string VarDaZuera = "nmCliente";

            if (txt_Consultar_Nome.Text != "")
            {
                VarDaZuera = "nmCliente";
                PesuisaNome = txt_Consultar_Nome.Text;
            }

            else if (txt_Consultar_Tel.Text != "")
            {
                VarDaZuera = "nCelular";
                PesuisaNome = txt_Consultar_Tel.Text;
            }
            BadReligion.Items.Clear();


            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select cliente.cdCliente, cliente.nmCliente, cliente.cpf, cliente.rg, cliente.email, cliente.sexo, endereco.cdendereco, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, telefones.nResidencial, telefones.nCelular from cliente inner join endereco on endereco.cdcliente = cliente.cdcliente inner join telefones on telefones.cdCliente = cliente.cdCliente where cliente." + VarDaZuera + " like '" + PesuisaNome + "%';";
            connection.Open();
            Reader = command.ExecuteReader();

            int cont = 0;
            int codigo;
            string nome;
            string CPF;
            string RG;
            string telefone;
            string cidade;
            string estado;


            while (Reader.Read())
            {

                cont++;

                codigo = (Reader.GetInt16("cdCliente"));
                nome = (Reader.GetString("nmCliente"));
                CPF = (Reader.GetString("cpf"));
                RG = (Reader.GetString("rg"));
                telefone = (Reader.GetString("nCelular"));
                cidade = (Reader.GetString("cidade"));
                estado = (Reader.GetString("estado"));


                TextBlock IDBlock = new TextBlock();
                IDBlock.Text = codigo.ToString();

                TextBlock NomeBlock = new TextBlock();
                NomeBlock.Text = " " + nome;
                NomeBlock.FontSize = 20;
                NomeBlock.FontWeight = FontWeights.Bold;
                NomeBlock.Foreground = new SolidColorBrush(Colors.Black);
                NomeBlock.TextAlignment = TextAlignment.Left;
                NomeBlock.VerticalAlignment = VerticalAlignment.Center;
                NomeBlock.DataContext = nome.ToString();

                TextBlock DocsBlock = new TextBlock();
                DocsBlock.Text = "  CPF: " + CPF + "    RG: " + RG;
                DocsBlock.FontSize = 13;
                DocsBlock.Foreground = new SolidColorBrush(Colors.Black);
                DocsBlock.TextAlignment = TextAlignment.Left;
                DocsBlock.VerticalAlignment = VerticalAlignment.Center;


                TextBlock TelBlock = new TextBlock();
                TelBlock.Text = "  Telefone: " + telefone;
                TelBlock.FontSize = 13;
                TelBlock.Foreground = new SolidColorBrush(Colors.Black);
                TelBlock.TextAlignment = TextAlignment.Left;
                TelBlock.VerticalAlignment = VerticalAlignment.Center;

                TextBlock EndBlock = new TextBlock();
                EndBlock.Text = "  Cidade: " + cidade + " - " + estado;
                EndBlock.FontSize = 13;
                EndBlock.Foreground = new SolidColorBrush(Colors.Black);
                EndBlock.TextAlignment = TextAlignment.Left;
                EndBlock.VerticalAlignment = VerticalAlignment.Center;

                TextBlock q = new TextBlock();
          
                q.Text = nome.ToString();

                StackPanel UserBlock = new StackPanel();
                UserBlock.Background = new SolidColorBrush(Colors.SkyBlue);
                UserBlock.Height = 112;
                UserBlock.Width = 443;
                UserBlock.VerticalAlignment = VerticalAlignment.Center;
                UserBlock.DataContext = codigo.ToString();
                

                UserBlock.Children.Add(NomeBlock);
                UserBlock.Children.Add(DocsBlock);
                UserBlock.Children.Add(TelBlock);
                UserBlock.Children.Add(EndBlock);

                BadReligion.Items.Add(UserBlock);


                //.Children.Add(UserBlock); Width="452" Height="126"


                //ListBox1.Items.Add(codigo+"--"+email+"--"+nome);

                //new TextBlock() { Name = "teste", Text = "Olaaaaaaaaa poha ", FontSize = 50 };
                //new TextBox() { Name = "asd", Width=11, Height=11 };


            }

            connection.Close();

        }

        private void BadReligion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // Bruxaria do Andre aqui-----> :
            StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
            foreach (TextBlock block in UserBlock.Children)
            {
                Gambis.BadCodigo = block.DataContext.ToString();
                //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
            }
            // Bruxaria do Andre aqui-----> :
            ClienteDAO DA = new ClienteDAO();
            DA.ConsutarCadastroCliente();


        }





       
    }
}
