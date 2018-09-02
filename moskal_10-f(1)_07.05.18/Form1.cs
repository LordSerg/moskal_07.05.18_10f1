using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moskal_10_f_1__07._05._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //n ступенек
            int x=75, y=50;//ступеньки будут подниматься на 50 и продливаться на 75
            this.Refresh();
            int n = Convert.ToInt32(textBox1.Text), h, w;
            g = CreateGraphics();
            Random r = new Random();
            x0 = 10;
            y0 = this.Height *2/ 3;
            for (int i = 0; i < n; i++)
            {
                g.DrawLine(Pens.Black, x0, y0, x0, y0 - y);
                y0 -= y;
                g.DrawLine(Pens.Black, x0, y0, x0 + x, y0);
                x0 += x;
            }

        }

        Graphics g ;
        private void button2_Click(object sender, EventArgs e)
        {
            //движение кругов
            g = CreateGraphics();
            timer1.Interval = 1;
            timer2.Interval = 1;
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = this.Height - 50;
            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;

        }
        int x1, y1, x2, y2, x0, y0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        //эти два таймера можно запихнуть в один
        private void timer1_Tick(object sender, EventArgs e)
        {
            //з лівого верхнього кута            
            Pen p1 = new Pen(Color.Black);
            Pen p2 = new Pen(Color.White);
            g.DrawEllipse(p2, x1, y1, 50, 50);            
            x1++;
            y1++;
            g.DrawEllipse(p1, x1, y1, 50, 50);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //з лівого нижнього кута
            Pen p1 = new Pen(Color.Black);
            Pen p2 = new Pen(Color.White);
            g.DrawEllipse(p2, x2, y2, 50, 50);
            x2++;
            y2--;
            g.DrawEllipse(p1, x2, y2, 50, 50);
        }
        
        
    }
}
