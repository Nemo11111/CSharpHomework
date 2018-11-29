using ordertest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework10
{
    public partial class MainForm1 : Form
    {
        public static OrderService os = new OrderService();
        
        public MainForm1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddOdMsg frm = new FrmAddOdMsg();
            frm.ShowF2(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currentIndex = 0;
            if (this.orderList.SelectedItems.Count > 0)//判断listview有被选中项
            {
                currentIndex = this.orderList.SelectedItems[0].Index;//取当前选中项的index

                string odId = orderList.Items[currentIndex].SubItems[0].Text;
                //uint.TryParse(odId.Remove(0, odId.Length - 3), out uint a);
                //uint id = Convert.ToUInt16(odId.Remove(0, odId.Length - 3));
                os.RemoveOrder(odId);

                orderList.Items[currentIndex].Remove();
            }

            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int currentIndex = 0;
            if (this.orderList.SelectedItems.Count == 1)
            {
                FrmChangeOdMsg frm = new FrmChangeOdMsg();
                currentIndex = this.orderList.SelectedItems[0].Index;//取当前选中项的index
                //uint odId = Convert.ToUInt32(orderList.Items[currentIndex].SubItems[0].Text);
                string odId = orderList.Items[currentIndex].SubItems[0].Text;
                string detailId = orderList.Items[currentIndex].SubItems[3].Text;

                string txtCustomerName = orderList.Items[currentIndex].SubItems[1].Text;
                string txtGoodName = orderList.Items[currentIndex].SubItems[5].Text;
                string txtQuantity = orderList.Items[currentIndex].SubItems[7].Text;
                
                frm.ShowF3(txtCustomerName,txtGoodName,txtQuantity,odId,detailId,this);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearchOd frm = new FrmSearchOd();
            frm.ShowF4(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        
    }
}
