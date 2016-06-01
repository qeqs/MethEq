using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethEq
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MaximumSize = Size;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void ShowResult(double[] x)
        {
            Graphics g = panellinear.CreateGraphics();
            g.Clear(Panel.DefaultBackColor);
            for (int i = 0; i < x.Length; i++)
                g.DrawString(x[i].ToString(), Font, Brushes.Black, new Point(5, (int)(5 + i * 2 * Font.Size)));
        }
        private void buttonGaus_Click(object sender, EventArgs e)
        {
            double[] b = Linear.GetMatrix(textBoxBlinear.Text);
            double[] x = Linear.GaussSystem(Linear.GetMatrix(textBoxAlinear.Lines),b,b.Length);
            if (x == null)
                return;
            ShowResult(x);
          
        }

        private void buttonZeiv_Click(object sender, EventArgs e)
        {
            double[] b = Linear.GetMatrix(textBoxBlinear.Text);
            double[] x0 = new double[b.Length];
            for (int i = 0; i < x0.Length; i++)
                x0[i] = 0;
            double[] x = Linear.Zeidel(Linear.GetMatrix(textBoxAlinear.Lines), b, x0, b.Length, 0.01);
            if (x == null)
                return;
            ShowResult(x);
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            foreach(Control c in Controls)
            {
                if(!(c is VScrollBar))
                c.Top = -vScrollBar.Value*10+10;
            }
        }
    }
}
