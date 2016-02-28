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

namespace Gessoft.Pages.Agenda
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AgendaOrcamento : Page
    {
        int ContMes;
        string SelecMes;
        string SelecAno;
        int DiaProcura;
        string VarDaZuera = "";
        string VarDaZuera2 = "cdServico";
        string[] DiaTem = new string[30];
        MessageDialog MessageBotVazio = new MessageDialog("Selecione alguma opção.", "Gessoft");
        public AgendaOrcamento()
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


            cmb_Mes.SelectedIndex = 10;
            cmb_Ano.SelectedIndex = 0;

   

        }



        private void btnPorOrcamento_Click(object sender, RoutedEventArgs e)
        {
            VarDaZuera = "cdOrcamento";

            lst_Tarefas.Items.Clear();

            TextBlock BlocoMes;
            BlocoMes = (TextBlock)cmb_Mes.SelectedItem;
            SelecMes = BlocoMes.Text;

            TextBlock BlocoAno;
            BlocoAno = (TextBlock)cmb_Ano.SelectedItem;
            SelecAno = BlocoAno.Text;
         
// Da pra fazer um método pra isso eu sei mais to sem tempo pra fazer isso.
            
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
//======================================================================================================

// Nao da pra fazer método pra isso até onde eu sei... 

            btn1.Background = new SolidColorBrush(Colors.Black);
            btn2.Background = new SolidColorBrush(Colors.Black);
            btn3.Background = new SolidColorBrush(Colors.Black);
            btn4.Background = new SolidColorBrush(Colors.Black);
            btn5.Background = new SolidColorBrush(Colors.Black);
            btn6.Background = new SolidColorBrush(Colors.Black);
            btn7.Background = new SolidColorBrush(Colors.Black);
            btn8.Background = new SolidColorBrush(Colors.Black);
            btn9.Background = new SolidColorBrush(Colors.Black);
            btn10.Background = new SolidColorBrush(Colors.Black);
            btn11.Background = new SolidColorBrush(Colors.Black);
            btn12.Background = new SolidColorBrush(Colors.Black);
            btn13.Background = new SolidColorBrush(Colors.Black);
            btn14.Background = new SolidColorBrush(Colors.Black);
            btn15.Background = new SolidColorBrush(Colors.Black);
            btn16.Background = new SolidColorBrush(Colors.Black);
            btn17.Background = new SolidColorBrush(Colors.Black);
            btn18.Background = new SolidColorBrush(Colors.Black);
            btn19.Background = new SolidColorBrush(Colors.Black);
            btn20.Background = new SolidColorBrush(Colors.Black);
            btn21.Background = new SolidColorBrush(Colors.Black);
            btn22.Background = new SolidColorBrush(Colors.Black);
            btn23.Background = new SolidColorBrush(Colors.Black);
            btn24.Background = new SolidColorBrush(Colors.Black);
            btn25.Background = new SolidColorBrush(Colors.Black);
            btn26.Background = new SolidColorBrush(Colors.Black);
            btn27.Background = new SolidColorBrush(Colors.Black);
            btn28.Background = new SolidColorBrush(Colors.Black);
            btn29.Background = new SolidColorBrush(Colors.Black);
            btn31.Background = new SolidColorBrush(Colors.Black);

//======================================================================================================

           int[] DiaC = new int[30]; //  O Array esta aqui pra zerar sempre que o btn for acionado;



// Im breve irei providenciar um medodo pra isso..

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaservico where mes = '"+ContMes.ToString()+"' and ano = '"+SelecAno+"' and cdOrcamento <> 'null';";

                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    
                    DiaProcura = Convert.ToInt16(Reader.GetString("Dia"));
                    
                    //IsServico = (Reader.GetString("cdServico")); oushi nao ta funfando '-'
                   



                    if ((DiaProcura == 1)) 
                    {               
                            
                        if (DiaC[0] == 0) 
                        {
                            btn1.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 1)
                        {
                            btn1.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 2) 
                        {
                            btn1.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 3)
                        {
                            btn1.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 4)
                        {
                            btn1.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[0]++;
                        }
 
                    }

                    if (DiaProcura == 2 ) 
                    {

                        if (DiaC[1] == 0)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 1)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 2)
                        {
                            btn2.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 3)
                        {
                            btn2.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 4)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[1]++;
                        }
 
                    }

                    if (DiaProcura == 3 )
                    {

                        if (DiaC[2] == 0)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 1)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 2)
                        {
                            btn3.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 3)
                        {
                            btn3.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 4)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[2]++;
                        }

                    }


                    if (DiaProcura == 4 )
                    {

                        if (DiaC[3] == 0)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 1)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 2)
                        {
                            btn4.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 3)
                        {
                            btn4.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 4)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[3]++;
                        }
                    
                    }
                    if (DiaProcura == 5)
                    {
                        if (DiaC[4] == 0)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 1)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 2)
                        {
                            btn5.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 3)
                        {
                            btn5.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 4)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[4]++;
                        }

                    }
                    if (DiaProcura == 6 )
                    {
                        if (DiaC[5] == 0)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 1)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 2)
                        {
                            btn6.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 3)
                        {
                            btn6.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 4)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[5]++;
                        }
                    }
                    if (DiaProcura == 7)
                    {
                        if (DiaC[6] == 0)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 1)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 2)
                        {
                            btn7.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 3)
                        {
                            btn7.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 4)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[6]++;
                        }
                    }
                    if (DiaProcura == 8)
                    {
                        if (DiaC[7] == 0)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 1)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 2)
                        {
                            btn8.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 3)
                        {
                            btn8.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 4)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[7]++;
                        }
                    }
                    if (DiaProcura == 9 )
                    {
                        if (DiaC[8] == 0)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 1)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 2)
                        {
                            btn9.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 3)
                        {
                            btn9.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 4)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[8]++;
                        }

                    }
                    if (DiaProcura == 10 )
                    {
                        if (DiaC[9] == 0)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 1)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 2)
                        {
                            btn10.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 3)
                        {
                            btn10.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 4)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[9]++;
                        }
                    }
                    if (DiaProcura == 11)
                    {
                        if (DiaC[10] == 0)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 1)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 2)
                        {
                            btn11.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 3)
                        {
                            btn11.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 4)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[10]++;
                        }
                    }
                    if (DiaProcura == 12 )
                    {
                        if (DiaC[11] == 0)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 1)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 2)
                        {
                            btn12.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 3)
                        {
                            btn12.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 4)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[11]++;
                        }
                    }
                    if (DiaProcura == 13)
                    {
                        if (DiaC[12] == 0)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 1)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 2)
                        {
                            btn13.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 3)
                        {
                            btn13.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 4)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[12]++;
                        }
                    }
                    if (DiaProcura == 14)
                    {
                        if (DiaC[13] == 0)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 1)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 2)
                        {
                            btn14.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 3)
                        {
                            btn14.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 4)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[13]++;
                        }
                    }
                    if (DiaProcura == 15 )
                    {
                                           
                        if (DiaC[14] == 0)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 1)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 2)
                        {
                            btn15.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 3)
                        {
                            btn15.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 4)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[14]++;
                        }
                    }
                    if (DiaProcura == 16)
                    {
                     
                         if (DiaC[15] == 0)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 1)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 2)
                        {
                            btn16.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 3)
                        {
                            btn16.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 4)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[15]++;
                        }

                    }
                    if (DiaProcura == 17)
                    {
                        
                        if (DiaC[16] == 0)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 1)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 2)
                        {
                            btn17.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 3)
                        {
                            btn17.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 4)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[16]++;
                        }

                    }
                    if (DiaProcura == 18)
                    {
                        if (DiaC[17] == 0)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 1)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 2)
                        {
                            btn18.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 3)
                        {
                            btn18.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 4)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[17]++;
                        }
                    }
                    if (DiaProcura == 19 )
                    {
                        if (DiaC[18] == 0)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 1)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 2)
                        {
                            btn19.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 3)
                        {
                            btn19.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 4)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[18]++;
                        }
                    }
                    if (DiaProcura == 20)
                    {
                        if (DiaC[19] == 0)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 1)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 2)
                        {
                            btn20.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 3)
                        {
                            btn20.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 4)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[19]++;
                        }
                    }
                    if (DiaProcura == 21)
                    {
                        if (DiaC[20] == 0)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 1)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 2)
                        {
                            btn21.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 3)
                        {
                            btn21.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 4)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[20]++;
                        }
                    }
                    if (DiaProcura == 22)
                    {
                        if (DiaC[21] == 0)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 1)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 2)
                        {
                            btn22.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 3)
                        {
                            btn22.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 4)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[21]++;
                        }
                    }
                    if (DiaProcura == 23)
                    {
                        if (DiaC[22] == 0)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 1)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 2)
                        {
                            btn23.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 3)
                        {
                            btn23.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 4)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[22]++;
                        }
                    }
                    if (DiaProcura == 24)
                    {
                        if (DiaC[23] == 0)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 1)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 2)
                        {
                            btn24.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 3)
                        {
                            btn24.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 4)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[23]++;
                        }
                    }
                    if (DiaProcura == 25)
                    {
                        if (DiaC[24] == 0)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 1)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 2)
                        {
                            btn25.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 3)
                        {
                            btn25.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 4)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[24]++;
                        }
                    }
                    if (DiaProcura == 26)
                    {
                        if (DiaC[25] == 0)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 1)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 2)
                        {
                            btn26.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 3)
                        {
                            btn26.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 4)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[25]++;
                        }
                    }
                    if (DiaProcura == 27 )
                    {
                        if (DiaC[26] == 0)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 1)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 2)
                        {
                            btn27.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 3)
                        {
                            btn27.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 4)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[26]++;
                        }
                    }
                    if (DiaProcura == 28)
                    {
                        if (DiaC[27] == 0)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 1)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 2)
                        {
                            btn28.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 3)
                        {
                            btn28.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 4)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[27]++;
                        }
                    }
                    if (DiaProcura == 29)
                    {
                        if (DiaC[28] == 0)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 1)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 2)
                        {
                            btn29.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 3)
                        {
                            btn29.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 4)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[28]++;
                        }
                    }
                    if (DiaProcura == 30)
                    {
                        if (DiaC[29] == 0)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 1)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 2)
                        {
                            btn30.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 3)
                        {
                            btn30.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 4)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[29]++;
                        }
                    }
                    if (DiaProcura == 31)
                    {
                        if (DiaC[30] == 0)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 1)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 2)
                        {
                            btn31.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 3)
                        {
                            btn31.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 4)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[30]++;
                        }
                    }

                   // Hey, Jude, don't make it bad

                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);



            }
//=====================================================================================================


        }



        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home.PrincipalHome), null);
        }
        private void btnPorServico_Click(object sender, RoutedEventArgs e)
        {
            VarDaZuera = "cdServico";

            lst_Tarefas.Items.Clear();

            TextBlock BlocoMes;
            BlocoMes = (TextBlock)cmb_Mes.SelectedItem;
            SelecMes = BlocoMes.Text;

            TextBlock BlocoAno;
            BlocoAno = (TextBlock)cmb_Ano.SelectedItem;
            SelecAno = BlocoAno.Text;

            // Da pra fazer um método pra isso eu sei mais to sem tempo pra fazer isso.

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
            //======================================================================================================

            // Nao da pra fazer método pra isso até onde eu sei... 

            btn1.Background = new SolidColorBrush(Colors.Black);
            btn2.Background = new SolidColorBrush(Colors.Black);
            btn3.Background = new SolidColorBrush(Colors.Black);
            btn4.Background = new SolidColorBrush(Colors.Black);
            btn5.Background = new SolidColorBrush(Colors.Black);
            btn6.Background = new SolidColorBrush(Colors.Black);
            btn7.Background = new SolidColorBrush(Colors.Black);
            btn8.Background = new SolidColorBrush(Colors.Black);
            btn9.Background = new SolidColorBrush(Colors.Black);
            btn10.Background = new SolidColorBrush(Colors.Black);
            btn11.Background = new SolidColorBrush(Colors.Black);
            btn12.Background = new SolidColorBrush(Colors.Black);
            btn13.Background = new SolidColorBrush(Colors.Black);
            btn14.Background = new SolidColorBrush(Colors.Black);
            btn15.Background = new SolidColorBrush(Colors.Black);
            btn16.Background = new SolidColorBrush(Colors.Black);
            btn17.Background = new SolidColorBrush(Colors.Black);
            btn18.Background = new SolidColorBrush(Colors.Black);
            btn19.Background = new SolidColorBrush(Colors.Black);
            btn20.Background = new SolidColorBrush(Colors.Black);
            btn21.Background = new SolidColorBrush(Colors.Black);
            btn22.Background = new SolidColorBrush(Colors.Black);
            btn23.Background = new SolidColorBrush(Colors.Black);
            btn24.Background = new SolidColorBrush(Colors.Black);
            btn25.Background = new SolidColorBrush(Colors.Black);
            btn26.Background = new SolidColorBrush(Colors.Black);
            btn27.Background = new SolidColorBrush(Colors.Black);
            btn28.Background = new SolidColorBrush(Colors.Black);
            btn29.Background = new SolidColorBrush(Colors.Black);
            btn31.Background = new SolidColorBrush(Colors.Black);

            //======================================================================================================

            int[] DiaC = new int[30]; //  O Array esta aqui pra zerar sempre que o btn for acionado;
            


            // Im breve irei providenciar um medodo pra isso..

            string MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

            try
            {
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from agendaservico where mes = '" + ContMes.ToString() + "' and ano = '" + SelecAno + "' and cdServico <> 'null';";

                connection.Open();
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {

                    DiaProcura = Convert.ToInt16(Reader.GetString("Dia"));

                    //IsServico = (Reader.GetString("cdServico")); oushi nao ta funfando '-'




                    if ((DiaProcura == 1))
                    {

                        DiaTem[0] = "Tem";
                        if (DiaC[0] == 0)
                        {
                            btn1.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[0]++;
                            
                        }
                        else if (DiaC[0] == 1)
                        {
                            btn1.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 2)
                        {
                            btn1.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 3)
                        {
                            btn1.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[0]++;
                        }
                        else if (DiaC[0] == 4)
                        {
                            btn1.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[0]++;
                        }

                    }

                    if (DiaProcura == 2)
                    {

                        if (DiaC[1] == 0)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 1)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 2)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 3)
                        {
                            btn2.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[1]++;
                        }
                        else if (DiaC[1] == 4)
                        {
                            btn2.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[1]++;
                        }

                    }

                    if (DiaProcura == 3)
                    {

                        if (DiaC[2] == 0)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 1)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 2)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 3)
                        {
                            btn3.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[2]++;
                        }
                        else if (DiaC[2] == 4)
                        {
                            btn3.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[2]++;
                        }

                    }


                    if (DiaProcura == 4)
                    {

                        if (DiaC[3] == 0)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 1)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 2)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 3)
                        {
                            btn4.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[3]++;
                        }
                        else if (DiaC[3] == 4)
                        {
                            btn4.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[3]++;
                        }

                    }
                    if (DiaProcura == 5)
                    {
                        if (DiaC[4] == 0)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 1)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 2)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 3)
                        {
                            btn5.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[4]++;
                        }
                        else if (DiaC[4] == 4)
                        {
                            btn5.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[4]++;
                        }

                    }
                    if (DiaProcura == 6)
                    {
                        if (DiaC[5] == 0)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 1)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 2)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 3)
                        {
                            btn6.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[5]++;
                        }
                        else if (DiaC[5] == 4)
                        {
                            btn6.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[5]++;
                        }
                    }
                    if (DiaProcura == 7)
                    {
                        if (DiaC[6] == 0)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 1)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 2)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 3)
                        {
                            btn7.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[6]++;
                        }
                        else if (DiaC[6] == 4)
                        {
                            btn7.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[6]++;
                        }
                    }
                    if (DiaProcura == 8)
                    {
                        if (DiaC[7] == 0)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 1)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 2)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 3)
                        {
                            btn8.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[7]++;
                        }
                        else if (DiaC[7] == 4)
                        {
                            btn8.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[7]++;
                        }
                    }
                    if (DiaProcura == 9)
                    {
                        if (DiaC[8] == 0)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 1)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 2)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 3)
                        {
                            btn9.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[8]++;
                        }
                        else if (DiaC[8] == 4)
                        {
                            btn9.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[8]++;
                        }

                    }
                    if (DiaProcura == 10)
                    {
                        if (DiaC[9] == 0)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 1)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 2)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 3)
                        {
                            btn10.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[9]++;
                        }
                        else if (DiaC[9] == 4)
                        {
                            btn10.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[9]++;
                        }
                    }
                    if (DiaProcura == 11)
                    {
                        if (DiaC[10] == 0)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 1)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 2)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 3)
                        {
                            btn11.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[10]++;
                        }
                        else if (DiaC[10] == 4)
                        {
                            btn11.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[10]++;
                        }
                    }
                    if (DiaProcura == 12)
                    {
                        if (DiaC[11] == 0)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 1)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 2)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 3)
                        {
                            btn12.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[11]++;
                        }
                        else if (DiaC[11] == 4)
                        {
                            btn12.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[11]++;
                        }
                    }
                    if (DiaProcura == 13)
                    {
                        if (DiaC[12] == 0)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 1)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 2)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 3)
                        {
                            btn13.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[12]++;
                        }
                        else if (DiaC[12] == 4)
                        {
                            btn13.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[12]++;
                        }
                    }
                    if (DiaProcura == 14)
                    {
                        if (DiaC[13] == 0)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 1)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 2)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 3)
                        {
                            btn14.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[13]++;
                        }
                        else if (DiaC[13] == 4)
                        {
                            btn14.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[13]++;
                        }
                    }
                    if (DiaProcura == 15)
                    {

                        if (DiaC[14] == 0)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 1)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 2)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 3)
                        {
                            btn15.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[14]++;
                        }
                        else if (DiaC[14] == 4)
                        {
                            btn15.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[14]++;
                        }
                    }
                    if (DiaProcura == 16)
                    {

                        if (DiaC[15] == 0)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 1)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 2)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 3)
                        {
                            btn16.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[15]++;
                        }
                        else if (DiaC[15] == 4)
                        {
                            btn16.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[15]++;
                        }

                    }
                    if (DiaProcura == 17)
                    {

                        if (DiaC[16] == 0)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 1)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 2)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 3)
                        {
                            btn17.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[16]++;
                        }
                        else if (DiaC[16] == 4)
                        {
                            btn17.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[16]++;
                        }

                    }
                    if (DiaProcura == 18)
                    {
                        if (DiaC[17] == 0)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 1)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 2)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 3)
                        {
                            btn18.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[17]++;
                        }
                        else if (DiaC[17] == 4)
                        {
                            btn18.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[17]++;
                        }
                    }
                    if (DiaProcura == 19)
                    {
                        if (DiaC[18] == 0)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 1)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 2)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 3)
                        {
                            btn19.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[18]++;
                        }
                        else if (DiaC[18] == 4)
                        {
                            btn19.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[18]++;
                        }
                    }
                    if (DiaProcura == 20)
                    {
                        if (DiaC[19] == 0)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 1)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 2)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 3)
                        {
                            btn20.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[19]++;
                        }
                        else if (DiaC[19] == 4)
                        {
                            btn20.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[19]++;
                        }
                    }
                    if (DiaProcura == 21)
                    {
                        if (DiaC[20] == 0)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 1)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 2)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 3)
                        {
                            btn21.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[20]++;
                        }
                        else if (DiaC[20] == 4)
                        {
                            btn21.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[20]++;
                        }
                    }
                    if (DiaProcura == 22)
                    {
                        if (DiaC[21] == 0)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 1)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 2)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 3)
                        {
                            btn22.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[21]++;
                        }
                        else if (DiaC[21] == 4)
                        {
                            btn22.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[21]++;
                        }
                    }
                    if (DiaProcura == 23)
                    {
                        if (DiaC[22] == 0)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 1)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 2)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 3)
                        {
                            btn23.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[22]++;
                        }
                        else if (DiaC[22] == 4)
                        {
                            btn23.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[22]++;
                        }
                    }
                    if (DiaProcura == 24)
                    {
                        if (DiaC[23] == 0)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 1)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 2)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 3)
                        {
                            btn24.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[23]++;
                        }
                        else if (DiaC[23] == 4)
                        {
                            btn24.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[23]++;
                        }
                    }
                    if (DiaProcura == 25)
                    {
                        if (DiaC[24] == 0)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 1)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 2)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 3)
                        {
                            btn25.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[24]++;
                        }
                        else if (DiaC[24] == 4)
                        {
                            btn25.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[24]++;
                        }
                    }
                    if (DiaProcura == 26)
                    {
                        if (DiaC[25] == 0)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 1)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 2)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 3)
                        {
                            btn26.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[25]++;
                        }
                        else if (DiaC[25] == 4)
                        {
                            btn26.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[25]++;
                        }
                    }
                    if (DiaProcura == 27)
                    {
                        if (DiaC[26] == 0)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 1)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 2)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 3)
                        {
                            btn27.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[26]++;
                        }
                        else if (DiaC[26] == 4)
                        {
                            btn27.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[26]++;
                        }
                    }
                    if (DiaProcura == 28)
                    {
                        if (DiaC[27] == 0)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 1)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 2)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 3)
                        {
                            btn28.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[27]++;
                        }
                        else if (DiaC[27] == 4)
                        {
                            btn28.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[27]++;
                        }
                    }
                    if (DiaProcura == 29)
                    {
                        if (DiaC[28] == 0)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 1)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 2)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 3)
                        {
                            btn29.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[28]++;
                        }
                        else if (DiaC[28] == 4)
                        {
                            btn29.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[28]++;
                        }
                    }
                    if (DiaProcura == 30)
                    {
                        if (DiaC[29] == 0)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 1)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 2)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 3)
                        {
                            btn30.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[29]++;
                        }
                        else if (DiaC[29] == 4)
                        {
                            btn30.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[29]++;
                        }
                    }
                    if (DiaProcura == 31)
                    {
                        if (DiaC[30] == 0)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 1)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 2)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DeepSkyBlue);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 3)
                        {
                            btn31.Background = new SolidColorBrush(Colors.Goldenrod);
                            DiaC[30]++;
                        }
                        else if (DiaC[30] == 4)
                        {
                            btn31.Background = new SolidColorBrush(Colors.DarkRed);
                            DiaC[30]++;
                        }
                    }

                    // Hey, Jude, don't make it bad

                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro de comandos:" + ex.Message);



            }
            //=====================================================================================================
        }
        private async void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '1' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '2' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '3' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '4' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '5' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '6' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '7' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '8' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '9' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn10_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '10' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn11_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '11' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn12_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '12' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn13_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '13' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn14_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '14' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn15_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '15' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn16_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '16' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn17_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '17' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn18_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '18' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn19_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '19' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn20_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '20' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn21_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '21' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn22_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '22' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn23_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '23' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn24_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '24' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn25_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '25' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn26_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '26' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: "+geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " "+ nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: "+cidade +"- "+estado+" \n Rua: "+rua+"   Bairro: "+bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn27_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '27' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn28_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '28' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn29_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '29' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn30_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '30' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }
        private async void btn31_Click(object sender, RoutedEventArgs e)
        {
            if (VarDaZuera == "")
            {


                await MessageBotVazio.ShowAsync();

            }
            else
            {
                lst_Tarefas.Items.Clear();
                String MyConString = "SERVER=localhost;DATABASE=Gessoft;UID=root;PASSWORD=vegas;";

                try
                {
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                    command.CommandText = "select Cliente.cdCliente, Cliente.nmCliente, Cliente.cpf, Cliente.rg, Cliente.email, Cliente.sexo, Cliente.cdStatus, Telefones.nResidencial, Telefones.nCelular, Endereco.cdEndereco, Endereco.rua, Endereco.bairro, Endereco.cidade, Endereco.estado, Endereco.cep, Endereco.numero, Endereco.complemento, agendaServico.numS, agendaServico.cdOrcamento, agendaServico.cdServico, agendaServico.descricao, agendaServico.cdusuario, agendaServico.dia, agendaServico.mes, agendaServico.ano, agendaServico.dtgeracao from cliente inner join endereco on endereco.cdCliente = cliente.cdCliente inner join telefones on telefones.cdCliente = cliente.cdCliente inner join agendaservico on agendaservico.cdCliente = cliente.cdCliente where mes = '" + ContMes + "' and ano = '" + SelecAno + "' and dia = '31' and " + VarDaZuera + " <> 'null' ;";
                    connection.Open();
                    Reader = command.ExecuteReader();




                    while (Reader.Read())
                    {
                        string cdOrcamento = (Reader.GetString(VarDaZuera));
                        string nmCliente = (Reader.GetString("nmCliente"));
                        string cidade = (Reader.GetString("cidade"));
                        string estado = (Reader.GetString("estado"));
                        string rua = (Reader.GetString("rua"));
                        string bairro = (Reader.GetString("bairro"));
                        string geracao = (Reader.GetString("dtgeracao"));

                        TextBlock IDOrcamentBlock = new TextBlock();
                        IDOrcamentBlock.Text = " Nº: " + cdOrcamento + "   Gerado: " + geracao;

                        TextBlock NmCliente = new TextBlock();
                        NmCliente.Text = " " + nmCliente;
                        TextBlock DadosEnd = new TextBlock();
                        DadosEnd.Text = " Cidade: " + cidade + "- " + estado + " \n Rua: " + rua + "   Bairro: " + bairro;


                        StackPanel OrcamentBlock = new StackPanel();
                        OrcamentBlock.Background = new SolidColorBrush(Colors.DodgerBlue);
                        OrcamentBlock.Height = 100;
                        OrcamentBlock.Width = 362;
                        OrcamentBlock.VerticalAlignment = VerticalAlignment.Center;
                        OrcamentBlock.HorizontalAlignment = HorizontalAlignment.Center;



                        ListViewItem RTAM = new ListViewItem();

                        OrcamentBlock.Children.Add(NmCliente);
                        OrcamentBlock.Children.Add(IDOrcamentBlock);
                        OrcamentBlock.Children.Add(DadosEnd);

                        lst_Tarefas.Items.Add(OrcamentBlock);

                    }
                }
                catch (Exception ex)
                {

                    throw new Exception("Erro de comandos:" + ex.Message);


                }


            }
        }

        private void cmb_Mes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            TextBlock BlocoMes;
            BlocoMes = (TextBlock)cmb_Mes.SelectedItem;
            SelecMes = BlocoMes.Text;
            // Da pra fazer um método pra isso eu sei mais to sem tempo pra fazer isso.

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
            //======================================================================================================


            cmb_Ano.SelectedIndex = 0; 
            TextBlock BlocoAno;
            BlocoAno = (TextBlock)cmb_Ano.SelectedItem;
            SelecAno = BlocoAno.Text;
            
            //======================================================================================================

            // Nao da pra fazer método pra isso até onde eu sei... 

            lst_Tarefas.Items.Clear();

            btn1.Background = new SolidColorBrush(Colors.Black);
            btn2.Background = new SolidColorBrush(Colors.Black);
            btn3.Background = new SolidColorBrush(Colors.Black);
            btn4.Background = new SolidColorBrush(Colors.Black);
            btn5.Background = new SolidColorBrush(Colors.Black);
            btn6.Background = new SolidColorBrush(Colors.Black);
            btn7.Background = new SolidColorBrush(Colors.Black);
            btn8.Background = new SolidColorBrush(Colors.Black);
            btn9.Background = new SolidColorBrush(Colors.Black);
            btn10.Background = new SolidColorBrush(Colors.Black);
            btn11.Background = new SolidColorBrush(Colors.Black);
            btn12.Background = new SolidColorBrush(Colors.Black);
            btn13.Background = new SolidColorBrush(Colors.Black);
            btn14.Background = new SolidColorBrush(Colors.Black);
            btn15.Background = new SolidColorBrush(Colors.Black);
            btn16.Background = new SolidColorBrush(Colors.Black);
            btn17.Background = new SolidColorBrush(Colors.Black);
            btn18.Background = new SolidColorBrush(Colors.Black);
            btn19.Background = new SolidColorBrush(Colors.Black);
            btn20.Background = new SolidColorBrush(Colors.Black);
            btn21.Background = new SolidColorBrush(Colors.Black);
            btn22.Background = new SolidColorBrush(Colors.Black);
            btn23.Background = new SolidColorBrush(Colors.Black);
            btn24.Background = new SolidColorBrush(Colors.Black);
            btn25.Background = new SolidColorBrush(Colors.Black);
            btn26.Background = new SolidColorBrush(Colors.Black);
            btn27.Background = new SolidColorBrush(Colors.Black);
            btn28.Background = new SolidColorBrush(Colors.Black);
            btn29.Background = new SolidColorBrush(Colors.Black);
            btn31.Background = new SolidColorBrush(Colors.Black);

            //======================================================================================================
        }
        private void cbm_Ano_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBlock BlocoMes;
            BlocoMes = (TextBlock)cmb_Mes.SelectedItem;
            SelecMes = BlocoMes.Text;

            TextBlock BlocoAno;
            BlocoAno = (TextBlock)cmb_Ano.SelectedItem;
            SelecAno = BlocoAno.Text;

            //======================================================================================================

            // Nao da pra fazer método pra isso até onde eu sei... 

            lst_Tarefas.Items.Clear();

            btn1.Background = new SolidColorBrush(Colors.Black);
            btn2.Background = new SolidColorBrush(Colors.Black);
            btn3.Background = new SolidColorBrush(Colors.Black);
            btn4.Background = new SolidColorBrush(Colors.Black);
            btn5.Background = new SolidColorBrush(Colors.Black);
            btn6.Background = new SolidColorBrush(Colors.Black);
            btn7.Background = new SolidColorBrush(Colors.Black);
            btn8.Background = new SolidColorBrush(Colors.Black);
            btn9.Background = new SolidColorBrush(Colors.Black);
            btn10.Background = new SolidColorBrush(Colors.Black);
            btn11.Background = new SolidColorBrush(Colors.Black);
            btn12.Background = new SolidColorBrush(Colors.Black);
            btn13.Background = new SolidColorBrush(Colors.Black);
            btn14.Background = new SolidColorBrush(Colors.Black);
            btn15.Background = new SolidColorBrush(Colors.Black);
            btn16.Background = new SolidColorBrush(Colors.Black);
            btn17.Background = new SolidColorBrush(Colors.Black);
            btn18.Background = new SolidColorBrush(Colors.Black);
            btn19.Background = new SolidColorBrush(Colors.Black);
            btn20.Background = new SolidColorBrush(Colors.Black);
            btn21.Background = new SolidColorBrush(Colors.Black);
            btn22.Background = new SolidColorBrush(Colors.Black);
            btn23.Background = new SolidColorBrush(Colors.Black);
            btn24.Background = new SolidColorBrush(Colors.Black);
            btn25.Background = new SolidColorBrush(Colors.Black);
            btn26.Background = new SolidColorBrush(Colors.Black);
            btn27.Background = new SolidColorBrush(Colors.Black);
            btn28.Background = new SolidColorBrush(Colors.Black);
            btn29.Background = new SolidColorBrush(Colors.Black);
            btn31.Background = new SolidColorBrush(Colors.Black);

            //======================================================================================================
        }
    }
}
