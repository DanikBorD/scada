using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_test
{
    public partial class termometrForm_1 : Form
    {
        public termometrForm_1()
        {
            InitializeComponent();
        }

        private void Температура_Load(object sender, EventArgs e)
        {

        }

        private void First_Click(object sender, EventArgs e)
        {
            termometrValue_1.Text = "15";
            levelOfNormalize_1.Text = "OOK";
            differenceValue_1.Text = "1";
        }

        private void Second_Click(object sender, EventArgs e)
        {
            termometrValue_1.Text = "17";
            levelOfNormalize_1.Text = "K";
            differenceValue_1.Text = "2";
        }

        private void Third_Click(object sender, EventArgs e)
        {
            
        }

        private void Fours_Click(object sender, EventArgs e)
        {

        }
    }
}
