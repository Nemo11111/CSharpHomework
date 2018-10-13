using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //用户选择的颜色
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //用户输入的角度
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //用户输入的长度
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        double pre11;
        double pre22;
        double th11;
        double th22;
        String color;
        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户选择的颜色
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.SelectedItems.Contains(listBox1.Items[i]))
                {
                    color = Convert.ToString(listBox1.Items[i]);
                }
            }

            //获取用户输入的角度
            String th1 = textBox1.Text;
            String th2 = textBox3.Text;
            th11 = Convert.ToDouble(th1) * Math.PI / 180;
            th22 = Convert.ToDouble(th2) * Math.PI / 180;

            //获取用户输入的长度
            String pre1 = textBox2.Text;
            String pre2 = textBox4.Text;
            pre11 = Double.Parse(pre1);
            pre22 = Double.Parse(pre2);

            if (graphics == null) graphics = this.CreateGraphics();
            drawCayTree(10, 200, 310, 100, -Math.PI / 2);
        }
        
        private Graphics graphics;       

        void drawCayTree(int n,double x0,double y0,double len,double th)
        {
            if (n == 0) return;

            double x1 = x0 + len * Math.Cos(th);
            double y1 = y0 + len * Math.Sin(th);
            double x2 = x0 + len * Math.Cos(th);
            double y2 = y0 + len * Math.Sin(th);

            drawLine(x0, y0, x1, y1, x2, y2);

            drawCayTree(n - 1, x1, y1, pre11 * len, th + th11);
            drawCayTree(n - 1, x2, y2, pre22 * len, th - th22);
        }

        void drawLine(double x0, double y0,double x1,double y1,double x2,double y2)
        {            
            switch(color)
            {
                case "Red":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x2, (int)y2);
                    break;
                case "Blue":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x2, (int)y2);
                    break;
                case "White":
                    graphics.DrawLine(Pens.White, (int)x0, (int)y0, (int)x1, (int)y1);
                    graphics.DrawLine(Pens.White, (int)x0, (int)y0, (int)x2, (int)y2);
                    break;
                case "Black":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x2, (int)y2);
                    break;
                case "Brown":
                    graphics.DrawLine(Pens.Brown, (int)x0, (int)y0, (int)x1, (int)y1);
                    graphics.DrawLine(Pens.Brown, (int)x0, (int)y0, (int)x2, (int)y2);
                    break;
            }

        }
    }
}
