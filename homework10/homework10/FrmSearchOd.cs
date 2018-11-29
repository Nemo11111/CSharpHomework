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
    public partial class FrmSearchOd : Form
    {
        private string key;
        ListView orderList = new ListView();
        List<Order> orders = new List<Order>();
        public FrmSearchOd()
        {
            InitializeComponent();
        }

        private void FrmSearchOd_Load(object sender, EventArgs e)
        {
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = SearchBy.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch(key)
            {
                case "全部订单":
                    orders = MainForm1.os.QueryAllOrders();
                    break;
                case "OrderId":
                    Order order = MainForm1.os.GetOrder(txtKeyWord.Text);
                    orders.Clear();
                    orders.Add(order);
                    break;
                case "CustomerName":
                    orders = MainForm1.os.QueryByCustomerName(txtKeyWord.Text);
                    break;
                case "GoodsName":
                    orders = MainForm1.os.QueryByGoodsName(txtKeyWord.Text);
                    break;
            }
            getListMessages();
        }

        public void ShowF4(MainForm1 form)
        {
            this.Show();
            orderList = form.orderList;
        }

        public void getListMessages()
        {
            orderList.Items.Clear();
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
