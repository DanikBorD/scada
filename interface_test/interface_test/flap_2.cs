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
    public partial class flap_2 : Form
    {
        public termometr_1 termometr = new termometr_1();
        MainWindow cnt = new MainWindow();
        // mcOMRON.OmronPLC plc;

        bool in_x_0;
        bool in_x_1;
        bool in_x_2;
        bool in_x_3;

        public flap_2()
        {
            InitializeComponent();
           // this.plc = new mcOMRON.OmronPLC(mcOMRON.TransportType.Tcp);
        }

        private void WriteOpen()
        {
            OpenFlap_2();
            UInt16 dm_position = 5;
            UInt16 dmval = Convert.ToUInt16(4);

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

                if (!cnt.plc.WriteDM(Convert.ToUInt16(dm_position), dmval))
                {
                    throw new Exception(cnt.plc.LastError);
                }

                messegeListFlap_2.Text = cnt.plc.LastDialog("WRITE DM");
            }
            catch (Exception ex)
            {
                MessageBox.Show("WriteDM() error: " + ex.Message);
            }
        }

        private void WriteClose()
        {
            CloseFlap_2();
            UInt16 dm_position = 5;
            UInt16 dmval = Convert.ToUInt16(8); ;

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

                if (!cnt.plc.WriteDM(Convert.ToUInt16(dm_position), dmval))
                {
                    throw new Exception(cnt.plc.LastError);
                }

                messegeListFlap_2.Text = cnt.plc.LastDialog("WRITE DM");
            }
            catch (Exception ex)
            {
                MessageBox.Show("WriteDM() error: " + ex.Message);
            }
        }
        private void ReadDM()
        {
            UInt16 dm_position = 102;
            UInt16 dmval = 0;
           
            try
            {
                if (!cnt.plc.ReadDM(dm_position, ref dmval))
                {
                    throw new Exception(cnt.plc.LastError);
                }

                flapValue_2.Text = dmval.ToString();
                float dmval_f = Convert.ToUInt32(dmval);

                messegeListFlap_2.Text = cnt.plc.LastDialog("READ DM");
                messegeListFlap_2.AppendText("DM VALUE: " + dmval.ToString());

                //if (Convert.ToUInt16(dmval.ToString()) == 2.0) OpenFlap_2();
                //if (Convert.ToUInt16(dmval.ToString()) == 2.1) CloseFlap_2();
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(1)) == Convert.ToUInt16(1)) in_x_0 = true;
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(2)) == Convert.ToUInt16(2)) in_x_1 = true;
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(4)) == Convert.ToUInt16(4)) in_x_2 = true;
                if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(8)) == Convert.ToUInt16(8)) in_x_3 = true;
                //else MessageBox.Show("Unfound value");

                if(in_x_2 == true)
                {
                    OpenFlap_2();
                }

                if(in_x_3 == true)
                {
                    CloseFlap_2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ReadDM() Error: " + ex.Message);
            }
        }
        public void OpenFlap_2()
        {
            conditionLabel_2.Text = "ОТКРЫТО";
            conditionLabel_2.BackColor = Color.Green;
        }

        public void CloseFlap_2()
        {
            conditionLabel_2.Text = "ЗАКРЫТО";
            conditionLabel_2.BackColor = Color.Red;
        }

        private void openButton_2_Click(object sender, EventArgs e)
        {
            WriteOpen();
        }

        private void closeButton_2_Click(object sender, EventArgs e)
        {
            WriteClose();
        }

        private void getConditionButton_2_Click(object sender, EventArgs e)
        {
            ReadDM();
        }

        private void autoButton_2_Click(object sender, EventArgs e)
        {
            if (termometr.temperature > termometr.normalTemperature) WriteClose();
            else WriteOpen();
        }
    }
}
