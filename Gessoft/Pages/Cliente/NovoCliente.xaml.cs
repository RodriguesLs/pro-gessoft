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
using Gessoft.DAO;
using Gessoft.Model;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Cliente
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NovoCliente : Page
    {
        public NovoCliente()
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

        
        //========================== BOTÕES DE NAVEGAÇÃO =================================
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
        //================================================================================


        private async void btn_NovoSalvarClick(object sender, RoutedEventArgs e)
        {
            Model.Endereco NovoEndereco     = new Model.Endereco();
            Model.Cliente  NovoCliente      = new Model.Cliente ();
            Model.Telefone NovoTelefone     = new Model.Telefone();
          

            ClienteDAO DA               = new ClienteDAO();

            NovoCliente.Nome    = txt_Novo_Nome.Text;
            NovoCliente.CPF = txt_Novo_CPF.Text;
            NovoCliente.RG      = txt_Novo_RG.Text;
            NovoCliente.Email   = txt_Novo_Email.Text;
            if (rdb_Novo_Masculino.IsChecked == true)
            {
                NovoCliente.Sexo = "Masculino";
                // Sexo = Masculino
            }
            else if (rdb_Novo_Feminino.IsChecked == true)
            {
                NovoCliente.Sexo = "Feminino";
                // Sexo = Feminino
            }
            
            NovoEndereco.Rua    = txt_Novo_Rua.Text;
            NovoEndereco.Bairro = txt_Novo_Bairro.Text;
            NovoEndereco.Cidade = txt_Novo_Cidade.Text;
            NovoEndereco.Estado = txt_Novo_Estado.Text;
            NovoEndereco.Cep    = txt_Novo_CEP.Text;
            NovoEndereco.Numero = txt_Novo_Numero.Text;
            NovoEndereco.Complemento = txt_Novo_Complemento.Text;
            

            NovoTelefone.NCelular     = txt_Novo_Celular.Text;
            NovoTelefone.NResidencial = txt_Novo_Telefone.Text;

            DA.NovoCadastroCliente(NovoCliente);
            DA.NovoCadastroEndereco(NovoEndereco);
            DA.NovoCadastroTelefone(NovoTelefone);

       
           
            MessageDialog MessageDialog = new MessageDialog("Cadastro efetuado com sucesso.", "Gessoft");
            await MessageDialog.ShowAsync();

        }

        private void btn_Servicos_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
