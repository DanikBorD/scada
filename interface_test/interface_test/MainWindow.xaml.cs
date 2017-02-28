using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;

namespace interface_test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public  mcOMRON.OmronPLC plc;
       

        public MainWindow()
        {
            InitializeComponent();

            
                this.plc = new mcOMRON.OmronPLC(mcOMRON.TransportType.Tcp);
            
            

        }

        private void termometr1Button_Click(object sender, RoutedEventArgs e)
        {
            termometr_1 frm = new termometr_1();
            frm.ShowDialog();
        }

        private void termometr2Button_Click(object sender, RoutedEventArgs e)
        {
            termometr_2 frm = new termometr_2();
            frm.ShowDialog();
        }

        private void termometr3Button_Click(object sender, RoutedEventArgs e)
        {
            termometr_3 frm = new termometr_3();
            frm.ShowDialog();
        }

        private void termometr4Button_Click(object sender, RoutedEventArgs e)
        {
            termometr_4 frm = new termometr_4();
            frm.ShowDialog();
        }

        private void flap1Button_Click(object sender, RoutedEventArgs e)
        {
            flap_1 frm = new flap_1();
            frm.ShowDialog();
        }

        private void flap2Button_Click(object sender, RoutedEventArgs e)
        {
            flap_2 frm = new flap_2();
            frm.ShowDialog();
        }

        private void fanButton_Click(object sender, RoutedEventArgs e)
        {
           // if (fanWorkingLabel.Visibility == Visibility.Collapsed) fanWorkingLabel.Visibility = Visibility.Visible;
         //   else fanWorkingLabel.Visibility = Visibility.Collapsed;
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {

            if (ipTextBox.Text == "") return;
            if (portTextBox.Text == "") return;

            try
            {
                mcOMRON.tcpFINSCommand tcpCommand = ((mcOMRON.tcpFINSCommand)plc.FinsCommand);
                tcpCommand.SetTCPParams(IPAddress.Parse(ipTextBox.Text), Convert.ToInt32(portTextBox.Text));

                if (!plc.Connect())
                {
                    throw new Exception(plc.LastError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect() error: " + ex.Message);
            }

            ipTextBox.IsEnabled = false;
            portTextBox.IsEnabled = false;
        }

        private void data_read_connection_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!plc.finsConnectionDataRead(0))
                {
                    throw new Exception(plc.LastError);
                }
                //cnt.ShowDialog();
                //cnt.messegeList_connect.Text = plc.LastDialog("CONTROLLER DATA READ");
                //cnt.messegeList_connect.AppendText("CONTROLLER: " + Encoding.ASCII.GetString(plc.FinsCommand.Response, 0, 20));
                //cnt.messegeList_connect.AppendText(Environment.NewLine);
                //cnt.messegeList_connect.AppendText("VERSION: " + Encoding.ASCII.GetString(plc.FinsCommand.Response, 20, 20));
            }
            catch (Exception ex)
            {
                MessageBox.Show("ControllerDataRead() error: " + ex.Message);
            }
        }

          private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        //
        }
    }
}
