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

namespace Gessoft.Pages.Funcionario
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AlterarFuncionario : Page
    {
        public AlterarFuncionario()
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
            command.CommandText = "select funcionario.cdFuncionario, Funcionario.nmFuncionario, Funcionario.cpf, Funcionario.rg, Funcionario.email, Funcionario.sexo, Funcionario.carteiraTrabalho, Funcionario.serie, Funcionario.icFilhos, Funcionario.nmPai, Funcionario.nmMae, Funcionario.qtFilhos, Funcionario.reservista, Funcionario.cdReservista, Funcionario.dtNascimento, Funcionario.nmDepto, Funcionario.nmCargo, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, endereco.numero, endereco.complemento, telefones.nResidencial, telefones.nCelular from Funcionario inner join endereco on endereco.cdFuncionario = Funcionario.cdFuncionario inner join telefones on telefones.cdFuncionario = Funcionario.cdFuncionario where Funcionario.cdFuncionario = '" + Gambis.Funcionario + "';";
            connection.Open();
            Reader = command.ExecuteReader();

            string nmFuncionario = "";
            string CPF = "";
            string RG = "";
            string tel = "";
            string cel = "";
            string email = "";
            string sexo = "";
            string rua = "";
            string bairro = "";
            string cidade = "";
            string estado = "";
            string cep = "";
            string Numero = "";
            string Complemento = "";
            string CarteriraTrabalho = "";
            string Serie = "";
            string IcFilhos = "";
            string NmPai = "";
            string NmMae = "";
            string QtFilhos = "";
            string Reservista = "";
            string CdReservista = "";
            string DtNascimento = "";
           
            while (Reader.Read())
            {
                nmFuncionario = (Reader.GetString("nmFuncionario"));
                CPF = (Reader.GetString("cpf"));
                RG = (Reader.GetString("RG"));
                tel = (Reader.GetString("nResidencial"));
                cel = (Reader.GetString("nCelular"));
                email = (Reader.GetString("email"));
                sexo = (Reader.GetString("sexo"));
                CarteriraTrabalho = (Reader.GetString("carteiraTrabalho"));
                Serie = (Reader.GetString("serie"));
                IcFilhos = (Reader.GetString("icFilhos"));
                NmPai = (Reader.GetString("NmPai"));
                NmMae = (Reader.GetString("NmMae"));
                QtFilhos = (Reader.GetString("QtFilhos"));
                Reservista = (Reader.GetString("Reservista"));
                CdReservista = (Reader.GetString("CdReservista"));
                DtNascimento = (Reader.GetString("DtNascimento"));

                rua = (Reader.GetString("rua"));
                bairro = (Reader.GetString("bairro"));
                cidade = (Reader.GetString("cidade"));
                estado = (Reader.GetString("estado"));
                cep = (Reader.GetString("cep"));
                Numero = (Reader.GetString("numero"));
                Complemento = (Reader.GetString("complemento"));

             

            }

            txt_Alterar_Nome.Text = nmFuncionario;
            txt_Alterar_CPF.Text = CPF;
            txt_Alterar_RG.Text = RG;
            txt_Alterar_Telefone.Text = tel;
            txt_Alterar_Celular.Text = cel;
            txt_Alterar_Email.Text = email;
            if (sexo == "Masculino")
            {
                rdb_Alterar_Masculino.IsChecked = true;
            }
            else
            {
                rdb_Alterar_Feminino.IsChecked = true;
            }

            txt_Alterar_Rua.Text = rua;
            txt_Alterar_Bairro.Text = bairro;
            txt_Alterar_Cidade.Text = cidade;
            txt_Alterar_Estado.Text = estado;
            txt_Alterar_CEP.Text = cep;
            txt_Alterar_Numero.Text = Numero;
            txt_Alterar_Complemento.Text = Complemento;
            txt_Alterar_CarteiraTrabalho.Text = CarteriraTrabalho;
            txt_Alterar_NSerie.Text = Serie;
            txt_Alterar_NomeMae.Text = NmMae;
            txt_Alterar_NomePai.Text = NmPai;
            txt_Alterar_QuantidadeFilhos.Text = QtFilhos;
            txt_Alterar_NReservista.Text = CdReservista;
            txt_Alterar_Nascimento.Text = DtNascimento;
            if (IcFilhos == "Sim")
            {
                rdb_Alterar_FilhosSim.IsChecked = true;

            }
            else
            {
                rdb_Alterar_FilhosNao.IsChecked = true;
            }
            
            
            connection.Close();

            
      
        





        }

        //========================== BOTÕES DE NAVEGAÇÃO =================================
        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home.PrincipalHome), null);
        }
        private void btn_NovoFuncionario_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Funcionario.NovoFuncionario), null);
        }
        private void btn_AlterarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Funcionario.AlterarFuncionario), null);
        }
        private void btn_ConsultarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Pages.Funcionario.ConsultarFuncionario), null);
        }

        private async void btn_Novo_SalvarClick(object sender, RoutedEventArgs e)
        {

            Model.Endereco AlterarEndereco = new Model.Endereco();
            Model.Funcionario AlterarFuncionario = new Model.Funcionario();
            Model.Telefone AlterarTelefone = new Model.Telefone();

            FuncionarioDAO DA = new FuncionarioDAO();

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select funcionario.cdFuncionario, funcionario.nmFuncionario, funcionario.cpf, funcionario.rg, funcionario.email, funcionario.sexo, funcionario.carteiraTrabalho, funcionario.serie, funcionario.icFilhos, funcionario.nmPai, funcionario.nmMae, funcionario.qtFilhos, funcionario.reservista, funcionario.dtNascimento, funcionario.nmDepto, funcionario.nmCargo, cdStatus, endereco.rua, endereco.bairro, endereco.cidade, endereco.estado, endereco.cep, endereco.numero, endereco.complemento, telefones.nResidencial, telefones.nCelular from funcionario inner join endereco on endereco.cdfuncionario = funcionario.cdfuncionario inner join telefones on telefones.cdfuncionario = funcionario.cdfuncionario where funcionario.cdfuncionario = '" + Gambis.Funcionario + "'";
            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                AlterarEndereco.CdEndereco = (Reader.GetInt16("cdFuncionario"));
            }


            //  Cagando o codigo aque :SSS


            AlterarFuncionario.Codigo = Convert.ToInt16(Gambis.Funcionario);
            AlterarFuncionario.Nome = txt_Alterar_Nome.Text;
            AlterarFuncionario.CPF = txt_Alterar_CPF.Text;
            AlterarFuncionario.RG = txt_Alterar_RG.Text;
            AlterarFuncionario.Email = txt_Alterar_Email.Text;
            if (rdb_Alterar_Masculino.IsChecked == true)
            {
                AlterarFuncionario.Sexo = "Masculino";
                // Sexo = Masculino
            }
            else if (rdb_Alterar_Feminino.IsChecked == true)
            {
                AlterarFuncionario.Sexo = "Feminino";
                // Sexo = Feminino
            }

            AlterarEndereco.Rua = txt_Alterar_Rua.Text;
            AlterarEndereco.Bairro = txt_Alterar_Bairro.Text;
            AlterarEndereco.Cidade = txt_Alterar_Cidade.Text;
            AlterarEndereco.Estado = txt_Alterar_Estado.Text;
            AlterarEndereco.Cep = txt_Alterar_CEP.Text;
            AlterarEndereco.Numero = txt_Alterar_Numero.Text;
            AlterarEndereco.Complemento = txt_Alterar_Complemento.Text;


            AlterarTelefone.NCelular = txt_Alterar_Celular.Text;
            AlterarTelefone.NResidencial = txt_Alterar_Telefone.Text;

            DA.AlterarCadastroFuncionario(AlterarFuncionario);
            DA.AlterarCadastroEndereco(AlterarEndereco);
            DA.AlterarCadastroTelefone(AlterarTelefone);

            MessageDialog MessageDialog = new MessageDialog("Cadastro alterado com sucesso.", "Gessoft");
            await MessageDialog.ShowAsync();

        }
        //================================================================================
    
    }
}
