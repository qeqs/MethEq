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
            clock = new Clock(new Point(0,0), Size,this);
            timer.Interval = 100;
            //clock.TimeChanged += new EventHandler(OnTimeChanged);

            clock.Show();

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
                    clock = new Clock(new Point(0, 0), Size, this);
                if ((int)type == 2)
                    clock = new ClockWithArrows(new Point(0, 0), Size, this);
                clock.Offset = utc;
            }
        }

        [Description("Часовой пояс.")]
        [DefaultValue(0)]
        public TimeSpan UTC { get { return utc; } set { utc = value; clock.Offset = utc; } }

        [Description("Время")]
        public DateTime Time { get { return clock.Time; } }



        
        //private void OnTimeChanged(object sender,EventArgs e)
        //{
        //    TimeChanged(sender, e);
        //}
        private void timer_Tick(object sender, EventArgs e)
        {

            clock.Show();
            clock.Update();
            if(TimeChanged!=null)
            TimeChanged(sender, e);
        }
        //если запускать из ClockControl_Load то вижуалка крашится
        public void Start()
        {
            timer.Start();

        }

        private void ClockControl_Load(object sender, EventArgs e)
        {
            // timer.Start();
        }
    }
}
