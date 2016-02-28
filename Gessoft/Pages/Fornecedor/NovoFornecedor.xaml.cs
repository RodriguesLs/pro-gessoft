using Gessoft.DAO;
using Gessoft.Model;
using Windows.UI.Popups;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Fornecedor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NovoFornecedor : Page
    {
        public NovoFornecedor()
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

     

        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }

        private void btn_ConsultarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.ConsultarFornecedor), null);
        }

        private void btn_NovoFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.ConsultarFornecedor), null);
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

                this.Frame.Navigate(typeof(Pages.Fornecedor.AlterarFornecedor), null);
            }

        }

        private async void btn_NovoSalvarClick(object sender, RoutedEventArgs e)
        {
            Model.Endereco NovoEndereco = new Model.Endereco();
            Model.Fornecedor NovoFornecedor = new Model.Fornecedor();
            Model.Telefone NovoTelefone = new Model.Telefone();


            FornecedorDAO DA = new FornecedorDAO();

            NovoFornecedor.Razao= txt_Novo_Nome.Text;
            NovoFornecedor.Fantasia = txt_Novo_Fantasia.Text;
            NovoFornecedor.CNPJ = txt_Novo_CNPJ.Text;
            NovoFornecedor.Email = txt_Novo_Email.Text;
            

            NovoEndereco.Rua = txt_Novo_Rua.Text;
            NovoEndereco.Bairro = txt_Novo_Bairro.Text;
            NovoEndereco.Cidade = txt_Novo_Cidade.Text;
            NovoEndereco.Estado = txt_Novo_Estado.Text;
            NovoEndereco.Cep = txt_Novo_CEP.Text;
            NovoEndereco.Numero = txt_Novo_Numero.Text;
            NovoEndereco.Complemento = txt_Novo_Complemento.Text;


            NovoTelefone.NCelular = txt_Novo_Celular.Text;
            NovoTelefone.NResidencial = txt_Novo_Telefone.Text;

            DA.NovoCadastroFornecedor(NovoFornecedor);
            DA.NovoCadastroEndereco(NovoEndereco);
            DA.NovoCadastroTelefone(NovoTelefone);



            MessageDialog MessageDialog = new MessageDialog("Cadastro efetuado com sucesso.", "Gessoft");
            await MessageDialog.ShowAsync();
        }
    }
}
