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

namespace Gessoft.Pages.Fornecedor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConsultarFornecedor : Page
    {
        public ConsultarFornecedor()
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

        string VarDaZuera = "nmFantasia";
        private void btn_ConsultarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.ConsultarFornecedor), null);
        }

        private void btn_NovoFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.NovoFornecedor), null);
        }

        private async void btn_AlterarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            
            if (Gambis.Fornecedor == "")
            {
                MessageDialog MessageDialog = new MessageDialog("Selecione algum fornecedor.", "Gessoft");
                await MessageDialog.ShowAsync();
            } 
            else
            {
                StackPanel UserBlock = (StackPanel)BadReligion.SelectedItems[0];
                foreach (TextBlock block in UserBlock.Children)
                {
                    Gambis.Fornecedor = block.DataContext.ToString();
                    //SS.Text = x; aCONTECEU UM MILAGRE POR AQUI...
                }
              
                this.Frame.Navigate(typeof(Pages.Fornecedor.AlterarFornecedor), null);
            }



        }

        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }

        private void BtnPesquisarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            string PesuisaNome = "";

            if (txt_Consultar_NomeF.Text != "") {
                VarDaZuera = "nmFantasia";
                PesuisaNome = txt_Consultar_NomeF.Text;
            }

            else if (txt_Consultar_Tel.Text != "") {
                VarDaZuera = "nCelular";
                PesuisaNome = txt_Consultar_Tel.Text;
            }


            BadReligion.Items.Clear();


            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select Fornecedor.cdFornecedor, Fornecedor.nmRazao, Fornecedor.nmFantasia, Fornecedor.cdCNPJ, Fornecedor.Email, endereco.cdendereco, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, telefones.nResidencial, telefones.nCelular from Fornecedor inner join endereco on endereco.cdFornecedor = Fornecedor.cdFornecedor inner join telefones on telefones.cdFornecedor = Fornecedor.cdFornecedor where Fornecedor."+VarDaZuera+" like '" + PesuisaNome + "%';";
            connection.Open();
            Reader = command.ExecuteReader();

            int cont = 0;
            int codigo;
            string nomeFan;
            string nomeRaz;
            string CNPJ;
            string Email;
            string cidade;
            string estado;
            string telefone;


            while (Reader.Read())
            {

                cont++;

                codigo = (Reader.GetInt16("cdFornecedor"));
                Gambis.Fornecedor = codigo.ToString();
                nomeRaz = (Reader.GetString("nmRazao"));
                nomeFan = (Reader.GetString("nmFantasia"));
                CNPJ = (Reader.GetString("cdCNPJ"));
                Email = (Reader.GetString("Email"));
                cidade = (Reader.GetString("cidade"));
                estado = (Reader.GetString("estado"));
                telefone = ((Reader.GetString("Ncelular")));

                TextBlock IDBlock = new TextBlock();
                IDBlock.Text = codigo.ToString();

                TextBlock NomeBlock = new TextBlock();
                NomeBlock.Text = " " + nomeFan;
                NomeBlock.FontSize = 20;
                NomeBlock.FontWeight = FontWeights.Bold;
                NomeBlock.Foreground = new SolidColorBrush(Colors.Black);
                NomeBlock.TextAlignment = TextAlignment.Left;
                NomeBlock.VerticalAlignment = VerticalAlignment.Center;
                NomeBlock.DataContext = nomeFan.ToString();

                TextBlock DocsBlock = new TextBlock();
                DocsBlock.Text = "  Razão: " + nomeRaz + "    CNPJ: " + CNPJ;
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
          
                q.Text = nomeFan.ToString();

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
    }
}
