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
    public partial class flap_1 : Form
    {
        public termometr_1 termometr = new termometr_1();
        MainWindow cnt = new MainWindow();
        //mcOMRON.OmronPLC plc;

        bool in_2_0;
        bool in_2_1;
        bool in_2_2;
        bool in_2_3;

        public flap_1()
        {
            InitializeComponent();
            // this.plc = new mcOMRON.OmronPLC(mcOMRON.TransportType.Tcp);

            cnt.ipTextBox.Text = "192.168.250.1";
            cnt.portTextBox.Text = "9600";
            if (cnt.ipTextBox.Text == "") return;
            if (cnt.portTextBox.Text == "") return;

            try
            {
                mcOMRON.tcpFINSCommand tcpCommand = ((mcOMRON.tcpFINSCommand)cnt.plc.FinsCommand);
                tcpCommand.SetTCPParams(IPAddress.Parse(cnt.ipTextBox.Text), Convert.ToInt32(cnt.portTextBox.Text));

                if (!cnt.plc.Connect())
                {
                    throw new Exception(cnt.plc.LastError);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect() error: " + ex.Message);
            }

            cnt.ipTextBox.IsEnabled = false;
            cnt.portTextBox.IsEnabled = false;

        }

        private void WriteOpen()
        {
            OpenFlap_1();
            UInt16 dm_position = 5;
            UInt16 dmval = Convert.ToUInt16(1);

            try
            {
                if (MessageBox.Show("This action will write some memory area of your PLC.\n\nContinue anyway?"
                                , "OMRON PLC text"
                                , MessageBoxButtons.OKCancel
                                , MessageBoxIcon.Question
                                , MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                if (!cnt.plc.WriteCIO(Convert.ToUInt16(dm_position), dmval))
                {
                    throw new Exception(cnt.plc.LastError);
                }

                messegeListFlap_1.Text = cnt.plc.LastDialog("WRITE DM");
            }
            catch (Exception ex)
            {
                MessageBox.Show("WriteDM() error: " + ex.Message);
            }
        }

        private void WriteClose()
        {
            CloseFlap_1();
            UInt16 dm_position = 5;
            UInt16 dmval = Convert.ToUInt16(2);

            try
            {
                if (MessageBox.Show("This action will write some memory area of your PLC.\n\nContinue anyway?"
                                , "OMRON PLC text"
                                , MessageBoxButtons.OKCancel
                                , MessageBoxIcon.Question
                                , MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }

                if (!cnt.plc.WriteCIO(Convert.ToUInt16(dm_position), dmval))
                {
                    throw new Exception(cnt.plc.LastError);
                }

                messegeListFlap_1.Text = cnt.plc.LastDialog("WRITE DM");
            }
            catch (Exception ex)
            {
                MessageBox.Show("WriteDM() error: " + ex.Message);
            }
        }
        public void ReadDM()
        {
            UInt16 dm_position = 100;
            UInt16 dmval = 0;
            //bool in_2_4;
            //bool in_2_5;
            //bool in_2_6;
            //bool in_2_7;
            //bool in_2_8;

            try
            {
                if (!this.cnt.plc.ReadDM(dm_position, ref dmval))
                {
                    throw new Exception(this.cnt.plc.LastError);
                }

                flapValue_1.Text = dmval.ToString();
                float dmval_f = Convert.ToUInt32(dmval);

                messegeListFlap_1.Text = this.cnt.plc.LastDialog("READ DM");
                messegeListFlap_1.AppendText("DM VALUE: " + dmval.ToString());

                //if (Convert.ToUInt16(dmval.ToString()) == 2.0) OpenFlap_1();
                //if (Convert.ToUInt16(dmval.ToString()) == 2.1) CloseFlap_1();
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(1)) == Convert.ToUInt16(1))  in_2_0 = true;
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(2)) == Convert.ToUInt16(2))  in_2_1 = true;
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(4)) == Convert.ToUInt16(4))  in_2_2 = true;
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(8)) == Convert.ToUInt16(8))  in_2_3 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(16)) == Convert.ToUInt16(16)) in_2_4 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(32)) == Convert.ToUInt16(32)) in_2_5 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(64)) == Convert.ToUInt16(64)) in_2_6 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(128)) == Convert.ToUInt16(128)) in_2_7 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(256)) == Convert.ToUInt16(256)) in_2_8 = true;

                // else MessageBox.Show("Unfound value");

                if(in_2_0 == true)
                {
                    OpenFlap_1();
                }

                if(in_2_1)
                {
                    CloseFlap_1();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ReadDM() Error: " + ex.Message + ex.Source);
            }
        }

       
        public void OpenFlap_1()
        {
            conditionLabel_1.Text = "ОТКРЫТО";
            conditionLabel_1.BackColor = Color.Green;
        }

        public void CloseFlap_1()
        {
            conditionLabel_1.Text = "ЗАКРЫТО";
            conditionLabel_1.BackColor = Color.Red;
        }
        private void openButton_1_Click(object sender, EventArgs e)
        {
            WriteOpen();
        }

        private void closeButton_1_Click(object sender, EventArgs e)
        {
            WriteClose();
        }

        private void autoButton_1_Click(object sender, EventArgs e)
        {
            if (termometr.temperature > termometr.normalTemperature) WriteClose();
            else WriteOpen();
        }

        private void getConditionButton_1_Click(object sender, EventArgs e)
        {
            ReadDM();

        }

        private void flap_1_Load(object sender, EventArgs e)
        {

        }
    }
}
      