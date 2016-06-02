﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    //компонент
    public class Clock:IClockBase
    {
        protected Bitmap bm;
        protected Graphics g;
        protected Graphics _g;
        protected Color background = SystemColors.Control;
        protected Brush titlecol = Brushes.Black;
        protected Point location;
        protected DateTime time;
        protected TimeSpan offset;
        protected Control parentControl;
        /// <summary>
        /// Выполняется после того как переменная времени изменилась
        /// </summary>
        public event EventHandler TimeChanged;
        /// <summary>
        /// Выполняется полсе изменения часового пояса
        /// </summary>
        public event EventHandler OffsetChanged;

        #region propreties
        public Graphics Graphic
        {
            get { return g; }
        }
        public Color Background
        {
            get
            {
                return background;
            }

            set
            {
                background = value;
            }
        }

        public Point Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }
        /// <summary>
        /// возвращает время UTC(0) при инициализации, где offset = 0
        /// </summary>
        public DateTime Time
        {
            get
            {
                return time+Offset;
            }

            set
            {
                time = value;
                if (TimeChanged != null)
                    TimeChanged(this, EventArgs.Empty);
            }
        }

        public TimeSpan Offset
        {
            get
            {
                return offset;
            }

            set
            {
                offset = value;
                if (OffsetChanged != null)
                    OffsetChanged(this, EventArgs.Empty);
            }
        }

        public Size DrawingSize
        {
            get
            {
                return bm.Size;
            }

            set
            {
                bm = new Bitmap( value.Width,value.Height);
                _g = Graphics.FromImage(bm);
            }
        }

        public Control ParentControl
        {
            get
            {
                return parentControl;
            }
        }

        public Brush Titlecol
        {
            get
            {
                return titlecol;
            }

            set
            {
                titlecol = value;
            }
        }
        #endregion

        public Clock(Point location,Size size,Control form)
        {

            bm = new Bitmap(size.Width, size.Height);
            g = form.CreateGraphics();
            _g = Graphics.FromImage(bm);
            this.Location = location;
            Time = DateTime.UtcNow;
            Offset = TimeSpan.Zero;
            form.Resize += new EventHandler(OnResize);
            parentControl = form;
        }
        /// <summary>
        /// В таймер наверно, а может и нет
        /// </summary>
        public virtual void Show()
        {
            _g.Clear(background);

            string timestring = Time.ToLongTimeString();//Time.ToShortTimeString();
            float fontsize = (bm.Size.Width<bm.Size.Height?bm.Size.Width:bm.Size.Height) / timestring.Length;
            Font font = new Font("Times New Roman", fontsize);
            _g.DrawString(timestring,font,titlecol, bm.Size.Width / 2 - (fontsize*(timestring.Length-2))/2, bm.Size.Height / 2 - fontsize);

            g.DrawImage(bm as Image, location);
        }
        /// <summary>
        /// это точно в таймер
        /// </summary>
        public void Update()
        {
            Time = DateTime.UtcNow;
        }
        /// <summary>
        /// Маштабирование
        /// </summary
        protected virtual void OnResize(object sender, EventArgs e)
        {
            Control form = (Control)sender;
            Size size = form.Size;
            bm = new Bitmap(size.Width, size.Height);
            g = form.CreateGraphics();
            _g = Graphics.FromImage(bm);

        }

        
    }
}
