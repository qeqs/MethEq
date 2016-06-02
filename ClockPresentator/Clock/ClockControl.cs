using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class ClockControl : UserControl
    {
        public ClockControl()
        {
            InitializeComponent();
            clock = new Clock(picture.Location, picture.Size, picture);
            timer.Interval = 500;
            
        }
        public enum ClockType {[Description("Электронные")] Electronic=1, [Description("Циферблат")]ClockFace=2}
        ClockType type = ClockType.Electronic;
        static IClockBase clock;
        TimeSpan utc = TimeSpan.Zero;

        [Description("Выполняется при изменении времени")]        
        public event EventHandler TimeChanged;
        

        [Description("Тип часов.")]
        [DefaultValue(ClockType.Electronic)]
        public ClockType TypeofClock { get { return type; }
            set
            {
                type = value;
                if ((int)type == 1)
                    clock = new Clock(picture.Location, picture.Size, picture);
                if ((int)type == 2)
                    clock = new ClockWithArrows(picture.Location, picture.Size, picture);
                clock.Offset = utc;
            }
        }

        [Description("Часовой пояс.")]
        [DefaultValue(0)]
        public TimeSpan UTC { get { return utc; } set { utc = value; clock.Offset = utc; } }

        [Description("Время")]
        public DateTime Time { get { return clock.Time; } }



        
        private void picture_Resize(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            clock.Update();
            clock.Show();
            TimeChanged(this, e);
        }

        private void ClockControl_Resize(object sender, EventArgs e)
        {

            picture.Size = Size;
        }

        private void ClockControl_Load(object sender, EventArgs e)
        {
            clock.TimeChanged += TimeChanged;
            timer.Start();
        }
    }
}
