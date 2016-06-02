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
        private void clockControl_TimeChanged(object sender, EventArgs e)
        {
            if((lasttime.TimeOfDay-clockControl.Time.TimeOfDay).Seconds>5)
            {
                MessageBox.Show("Прошло 5 секунд");
            }
        }
    }
}
