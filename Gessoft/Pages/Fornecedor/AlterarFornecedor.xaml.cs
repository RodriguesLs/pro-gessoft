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

namespace Gessoft.Pages.Fornecedor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AlterarFornecedor : Page
    {
        public AlterarFornecedor()
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

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select Fornecedor.cdFornecedor, Fornecedor.nmRazao, Fornecedor.nmFantasia, Fornecedor.cdCNPJ, Fornecedor.Email, endereco.cdendereco, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, endereco.numero, endereco.complemento, telefones.nResidencial, telefones.nCelular from Fornecedor inner join endereco on endereco.cdFornecedor = Fornecedor.cdFornecedor inner join telefones on telefones.cdFornecedor = Fornecedor.cdFornecedor where Fornecedor.cdFornecedor like '" + Gambis.Fornecedor + "%';";
            connection.Open();
            Reader = command.ExecuteReader();


            string nomeFan = "";
            string nomeRaz = "";
            string CNPJ = "";
            string Email = "";
            string rua = "";
            string bairro = "";
            string cidade = "";
            string estado = "";
            string cep = "";
            string Numero = "";
            string Complemento = "";
            string telefone = "";
            string cel = "";

            while (Reader.Read())
            {

                nomeRaz = (Reader.GetString("nmRazao"));
                nomeFan = (Reader.GetString("nmFantasia"));
                CNPJ = (Reader.GetString("cdCNPJ"));
                Email = (Reader.GetString("Email"));
                cidade = (Reader.GetString("cidade"));
                estado = (Reader.GetString("estado"));
                telefone = ((Reader.GetString("NResidencial")));
                cel = ((Reader.GetString("Ncelular")));
                rua = (Reader.GetString("rua"));
                bairro = (Reader.GetString("bairro"));
                cidade = (Reader.GetString("cidade"));
                estado = (Reader.GetString("estado"));
                cep = (Reader.GetString("cep"));
                Numero = (Reader.GetString("numero"));
                Complemento = (Reader.GetString("complemento"));
            }

            txt_nmF.Text = nomeFan;
            txt_Alterar_nmR.Text = nomeRaz;
            txt_CNPJ.Text = CNPJ;
            txt_cel.Text = cel;
            txt_tel.Text = telefone;
            txt_Email.Text = Email;


            txt_Novo_Rua.Text = rua;
            txt_Novo_Bairro.Text = bairro;
            txt_Novo_Cidade.Text = cidade;
            txt_Novo_Estado.Text = estado;
            txt_Novo_CEP.Text = cep;
            txt_Novo_Numero.Text = Numero;
            txt_Novo_Complemento.Text = Complemento;
            connection.Close();




        }

        private void btn_ConsultarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.ConsultarFornecedor), null);
        }

        private void btn_NovoFornecdor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.NovoFornecedor), null);
        }

        private void btn_AlterarFornecedor_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Fornecedor.AlterarFornecedor), null);
        }

        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }

        private async void btn_AlterarFornecedorClick(object sender, RoutedEventArgs e)
        {

            Model.Endereco AlterarEndereco = new Model.Endereco();
            Model.Fornecedor AlterarFornecedor = new Model.Fornecedor();
            Model.Telefone AlterarTelefone = new Model.Telefone();

            FornecedorDAO DA = new FornecedorDAO();

            AlterarFornecedor.Fantasia = txt_nmF.Text;
            AlterarFornecedor.Razao = txt_Alterar_nmR.Text;
            AlterarFornecedor.CNPJ = txt_CNPJ.Text;
            AlterarTelefone.NCelular = txt_cel.Text;
            AlterarTelefone.NResidencial = txt_tel.Text;
            AlterarTelefone.NResidencial = txt_Email.Text;


            AlterarEndereco.Rua = txt_Novo_Rua.Text;
            AlterarEndereco.Bairro = txt_Novo_Bairro.Text;
            AlterarEndereco.Cidade = txt_Novo_Cidade.Text;
            AlterarEndereco.Estado = txt_Novo_Estado.Text;
            AlterarEndereco.Cep = txt_Novo_CEP.Text;
            AlterarEndereco.Numero = txt_Novo_Numero.Text;
            AlterarEndereco.Complemento = txt_Novo_Complemento.Text;


            DA.AlterarCadastroFornecedor(AlterarFornecedor);
            DA.AlterarCadastroEndereco(AlterarEndereco);
            DA.AlterarCadastroTelefone(AlterarTelefone);

            MessageDialog MessageDialog = new MessageDialog("Cadastro alterado com sucesso.", "Gessoft");
            await MessageDialog.ShowAsync();

        }


    }
}
