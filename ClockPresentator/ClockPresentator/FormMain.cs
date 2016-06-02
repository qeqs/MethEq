using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockPresentator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();           

        }
        DateTime lasttime = DateTime.Now;

        private void FormMain_Load(object sender, EventArgs e)
        {
            clockControl1.Start();
        }

        private void clockControl1_TimeChanged(object sender, EventArgs e)
        {
            if(Math.Abs((lasttime.TimeOfDay-clockControl1.Time.TimeOfDay).Seconds)>=5)
            {
                lasttime = clockControl1.Time;
                MessageBox.Show("ПРОШЛО 5 СЕКУНД!!!", "АХТУНГ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonNotify_Click(object sender, EventArgs e)
        {
            clockControl1.TimeChanged -= clockControl1_TimeChanged;
            buttonNotify.Enabled = !buttonNotify.Enabled;
        }

        private void buttonElectro_Click(object sender, EventArgs e)
        {
            clockControl1.TypeofClock = Clock.ClockControl.ClockType.Electronic;
            buttonMeh.Enabled = !buttonMeh.Enabled;
            buttonElectro.Enabled = !buttonElectro.Enabled;
        }

        private void buttonMeh_Click(object sender, EventArgs e)
        {
            clockControl1.TypeofClock = Clock.ClockControl.ClockType.ClockFace;
            buttonMeh.Enabled = !buttonMeh.Enabled;
            buttonElectro.Enabled = !buttonElectro.Enabled;
        }
    }
}
