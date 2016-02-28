using Gessoft.DAO;
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
    public sealed partial class NovoFuncionario : Page
    {
        public NovoFuncionario()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>

        //========================== BOTÕES DE NAVEGAÇÃO =================================
        private void btn_VoltarHome_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
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
        //================================================================================


        private async void btn_NovoSalvarClick(object sender, RoutedEventArgs e)
        {
            Model.Endereco NovoEndereco = new Model.Endereco();
            Model.Funcionario NovoFuncionario = new Model.Funcionario();
            Model.Telefone NovoTelefone = new Model.Telefone();
            //Model.Departamento NovoDepartamento = new Model.Departamento();
            //Model.Cargo NovoCargo = new Model.Cargo();


            FuncionarioDAO DA = new FuncionarioDAO();

            NovoFuncionario.Nome = txt_Novo_Nome.Text;
            NovoFuncionario.CPF = txt_Novo_CPF.Text;
            NovoFuncionario.RG = txt_Novo_RG.Text;
            NovoFuncionario.Email = txt_Novo_Email.Text;
            if (rdb_Novo_Masculino.IsChecked == true)
            {
                NovoFuncionario.Sexo = "Masculino";
                // Sexo = Masculino
            }
            else if (rdb_Novo_Feminino.IsChecked == true)
            {
                NovoFuncionario.Sexo = "Feminino";
                // Sexo = Feminino
            }

            NovoFuncionario.NCarteira = txt_Novo_CarteiraTrabalho.Text;
            NovoFuncionario.NSerie = txt_Novo_NSerie.Text;
            if (rdb_Novo_FilhosSim.IsChecked == true)
            {
                NovoFuncionario.TemFilhos = "Sim";
                // Filhos = Sim               
            }
            else if (rdb_Novo_FilhosNao.IsChecked == true)
            {
                NovoFuncionario.Sexo = "Não";
                // Filhos = Não       
            }

            NovoFuncionario.NomePai = txt_Novo_NomePai.Text;
            NovoFuncionario.NomeMae = txt_Novo_NomeMae.Text;
            NovoFuncionario.QuantosFilhos = txt_Novo_QuantidadeFilhos.Text;
            // Esta faltando se tem reservista !!!!!  Pera ae agora tem kk'
            if (txt_Novo_NReservista.Text == "")
            {
                NovoFuncionario.TemReservista = "Não";
            }
            else {
                NovoFuncionario.TemReservista = "Sim";
            }
            
            NovoFuncionario.NReservista = txt_Novo_NReservista.Text;
           
            NovoFuncionario.Nasimento = txt_Novo_Nascimento.Text;
    

            NovoTelefone.NCelular = txt_Novo_Celular.Text;
            NovoTelefone.NResidencial = txt_Novo_Telefone.Text;


            NovoEndereco.Rua = txt_Novo_Rua.Text;
            NovoEndereco.Bairro = txt_Novo_Bairro.Text;
            NovoEndereco.Cidade = txt_Novo_Cidade.Text;
            NovoEndereco.Estado = txt_Novo_Estado.Text;
            NovoEndereco.Cep = txt_Novo_CEP.Text;

            //DA.NovoCadastroCargo(NovoCargo);
            //DA.NovoCadastroDepartamento(NovoDepartamento);
            DA.NovoCadastroFuncionario(NovoFuncionario);      
            DA.NovoCadastroTelefone(NovoTelefone);
            DA.NovoCadastroEndereco(NovoEndereco);

            MessageDialog MessageDialog = new MessageDialog("Cadastro efetuado com sucesso.", "Gessoft");
            await MessageDialog.ShowAsync();

        }

        private void rdb_Novo_FilhosSim_Checked(object sender, RoutedEventArgs e)
        {
            //txt_Novo_QuantidadeFilhos.IsEnabled = true;
        }

        private void rdb_Novo_FilhosNao_Checked(object sender, RoutedEventArgs e)
        {
            //txt_Novo_QuantidadeFilhos.IsEnabled = false;
        }



    }
}
