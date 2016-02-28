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

namespace Gessoft.Pages.Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FrmLogin : Page
    {
        public FrmLogin()
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

        private async void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            string Senha = txtSenha.Password.ToString();
            string Login = txtLogin.Text;

    

            int cdUsuario = 0;


            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from usuarios where cdSenha = '" + Senha + "' and nmUsuario = '" + Login + "';";
                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {

                    cdUsuario = (Reader.GetInt16("cdUsuario"));
                    //Data = (Reader.GetString("CPF"));
                }
                if (cdUsuario == 0)
                {

                    MessageDialog MessageDialog = new MessageDialog("Login ou senha incorretos, em caso de perca contacte o administrador.", "Gessoft");
                    await MessageDialog.ShowAsync();
                    txtLogin.Text = "";
                    Senha = "";

                }
                else {

                    this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
                
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);


            }
        }


    }
}
