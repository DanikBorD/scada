using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace interface_test
{
    public partial class Connect : Form
    {
      //  public mcOMRON.OmronPLC plc;

        public Connect()
        {
            InitializeComponent();
           // this.plc = new mcOMRON.OmronPLC(mcOMRON.TransportType.Tcp);
        }

        //private void connect_button_Click(object sender, EventArgs e)
        //{
        //    if (connect_ip.Text == "") return;
        //    if (connect_port.Text == "") return;

        //    try
        //    {
        //        mcOMRON.tcpFINSCommand tcpCommand = ((mcOMRON.tcpFINSCommand)plc.FinsCommand);
        //        tcpCommand.SetTCPParams(IPAddress.Parse(connect_ip.Text), Convert.ToInt32(connect_port.Text));

        //        if (! plc.Connect())
        //        {
        //            throw new Exception(plc.LastError);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Connect() error: " + ex.Message);
        //    }
        //}

      //  public void connectionDataRead_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (!plc.finsConnectionDataRead(0))
//                {
//                    throw new Exception(plc.LastError);
//                }

//                messegeList_connect.Text = plc.LastDialog("CONTROLLER DATA READ");
//                messegeList_connect.AppendText("CONTROLLER: " + Encoding.ASCII.GetString(plc.FinsCommand.Response, 0, 20));
//                messegeList_connect.AppendText(Environment.NewLine);
//                messegeList_connect.AppendText("VERSION: " + Encoding.ASCII.GetString(plc.FinsCommand.Response, 20, 20));
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("ControllerDataRead() error: " + ex.Message);
//            }
//        }
    }
}
