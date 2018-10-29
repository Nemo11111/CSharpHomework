using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myProgram;

namespace addOrderNameSpace
{
    public partial class addOrder : Form
    {
        public addOrder()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string addGoodsName = textBox2.Text;
            string addGoodsNum = textBox1.Text;
            int addGoodsMoney = int.Parse(textBox4.Text);
            string addGuestName = textBox3.Text;
            OrderServer.Inf.Add(new Order(addGoodsNum, addGoodsName, addGuestName, addGoodsMoney));
            Dispose();
            
        }
    }
}
