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
    public partial class termometr_3 : Form
    {
        //mcOMRON.OmronPLC plc;
        MainWindow cnt = new MainWindow();

        public int temperature;
        public int normalTemperature = 15;
        public int maxDifference = 5;
        public int difference;

        public termometr_3()
        {
            InitializeComponent();
          //  this.plc = new mcOMRON.OmronPLC(mcOMRON.TransportType.Tcp);
        }

        private void ReadDM()
        {
            UInt16 dm_position = 108;
            UInt16 dmval = 0;
            //bool in_x_0;
            //bool in_x_1;
            //bool in_x_2;
            //bool in_x_3;
            try
            {
                if (!cnt.plc.ReadDM(dm_position, ref dmval))
                {
                    throw new Exception(cnt.plc.LastError);
                }

                temperatureValue_3.Text = dmval.ToString();

                messegeList_3.Text = cnt.plc.LastDialog("READ DM");
                messegeList_3.AppendText("DM VALUE: " + dmval.ToString());
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(1)) == Convert.ToUInt16(1)) in_x_0 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(2)) == Convert.ToUInt16(2)) in_x_1 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(4)) == Convert.ToUInt16(4)) in_x_2 = true;
                //if ((Convert.ToUInt16(dmval) & Convert.ToUInt16(8)) == Convert.ToUInt16(8)) in_x_3 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ReadDM() Error: " + ex.Message);
            }
        }

        public void TermometrValue(int temperature)
        {
            temperatureValue_3.Text = temperature.ToString();
        }

        public void DangerLabel(int temperature)
        {
            if ((temperature < 10) || (temperature > 20))
            {
                levelOfNormalize_3.Text = "BED";
                levelOfNormalize_3.BackColor = Color.Red;
            }
            else
            {
                levelOfNormalize_3.Text = "OK";
                levelOfNormalize_3.BackColor = Color.LawnGreen;
            }
        }

        public void Difference(int temperature)
        {
            differenceValue_3.Text = (temperature - normalTemperature).ToString();
        }

        public void NormalTemperature(int temperature)
        {
            normal_3.Text = normalTemperature.ToString();
        }

        private void getValueButton_3_Click(object sender, EventArgs e)
        {
            TermometrValue(temperature);
            DangerLabel(temperature);
            Difference(temperature);
            NormalTemperature(temperature);
            ReadDM();
        }
    }
}

