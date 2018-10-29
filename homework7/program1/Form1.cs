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

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = OrderServer.Inf;
            bs.Add(OrderServer.Inf[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Order> Inf2 = new List<Order>();
            string findGoodsNum;
            string findGuestName;
            string findGoodsName;
            if(textBox1.Text != ""|| textBox2.Text != ""|| textBox3.Text != "")
            {
                if (textBox1.Text != "")
                {
                    findGoodsNum = textBox1.Text;
                    var search = from n in OrderServer.Inf
                                 where n.orderNum == findGoodsNum
                                 select n;
                    if(search!=null)
                    {
                        foreach (var m in search)
                        {
                            Inf2.Add(new Order(m.orderNum, m.goodsName, m.guestName, m.goodsMoney));
                        }
                    }
                }
                if (textBox2.Text != "")
                {
                    findGuestName = textBox2.Text;
                    var search = from n in OrderServer.Inf
                                 where n.guestName == findGuestName
                                 select n;
                    if(search!=null)
                    {
                        foreach (var m in search)
                        {
                            Inf2.Add(new Order(m.orderNum, m.goodsName, m.guestName, m.goodsMoney));
                        }
                    }
                }
                if (textBox3.Text != "")
                {
                    findGoodsName = textBox3.Text;
                    var search = from n in OrderServer.Inf
                                 where n.goodsName == findGoodsName
                                 select n;
                    if(search!=null)
                    {
                        foreach (var m in search)
                        {
                            Inf2.Add(new Order(m.orderNum, m.goodsName, m.guestName, m.goodsMoney));
                        }
                    }
                }
                if(Inf2.Count!=0)
                {
                    label5.Text = "";
                    dataGridView1.DataSource = Inf2;
                    bs.Add(Inf2[0]);
                }
                else
                {
                    label5.Text = "Not Found!";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addOrderNameSpace.addOrder addOrderForm = new addOrderNameSpace.addOrder();
            addOrderForm.Show();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderServer.Inf;
            bs.Add(OrderServer.Inf[0]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
