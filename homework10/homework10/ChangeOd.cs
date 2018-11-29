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
    public partial class FrmChangeOdMsg : Form
    {
        ListView orderList = new ListView();
        private string odId = "";
        private string detailId = "";
        public FrmChangeOdMsg()
        {
            InitializeComponent();
        }

        public void ShowF3(string customerName,string goodName,string quantity,string odId,string detailId,MainForm1 form)
        {
            this.txtCustomer.Text = customerName;
            this.txtGoods.Text = goodName;
            this.txtNums.Text = quantity;
            this.odId = odId;
            this.detailId = detailId;
            this.orderList = form.orderList;
            this.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtCustomer != null && txtGoods != null && txtNums.Text != null)
            {
                Order changedOd = MainForm1.os.GetOrder(odId);
                changedOd.Customer.Name = txtCustomer.Text;


                foreach(OrderDetail odDetail in changedOd.Details)
                {
                    if(odDetail.Id == detailId)
                    {
                        odDetail.Goods.Name = txtGoods.Text;
                        odDetail.Quantity = Convert.ToUInt32(txtNums.Text);
                        break;
                    }
                }
                getListMessages();
            }
        }

        private void FrmChangeOdMsg_Load(object sender, EventArgs e)
        {

        }

        public void getListMessages()
        {
            orderList.Items.Clear();
            List<Order> orders = MainForm1.os.QueryAllOrders();
            foreach (Order od in orders)
            {
                foreach (OrderDetail odDetails in od.Details)
                {
                    ListViewItem item = new ListViewItem(od.Id.ToString());
                    item.SubItems.Add(od.Customer.Name);
                    item.SubItems.Add(od.Amount.ToString());
                    item.SubItems.Add(odDetails.Id.ToString());
                    item.SubItems.Add(odDetails.Goods.Id.ToString());
                    item.SubItems.Add(odDetails.Goods.Name);
                    item.SubItems.Add(odDetails.Goods.Price.ToString());
                    item.SubItems.Add(odDetails.Quantity.ToString());
                    orderList.Items.Add(item);
                }
            }
        }
    }
}
