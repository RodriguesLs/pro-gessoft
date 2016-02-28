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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gessoft.Pages.Home
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PrincipalHome : Page
    {
        public PrincipalHome()
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
            if ((Gambis.BadCodigo == null) || Gambis.ClienteNome == null)
            {
                lblNomeCliente.Text = "";
                lblTextCliente.Text = "";

            }
            else {

                lblNomeCliente.Text = Gambis.ClienteNome;
            
            }

        }



        private void Grid_Cliente(Object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Cliente.ConsultarCliente), null);
        }
        private void Grid_Funcionario(Object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Funcionario.ConsultarFuncionario), null);
        }
        private void Grid_Agenda(Object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Agenda.AgendaOrcamento), null);  
        }
        private void Grid_Servicos(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Servicos.NovoOrcamento), null);
        }
        private void Grid_Relatorios(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Relatorios.FrmRelatorios), null);
        }
        private void Grid_Fornecedor(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.ConsultarFornecedor), null);
        }
        private void Logout(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Login.FrmLogin), null);
        }
        

    }
}
