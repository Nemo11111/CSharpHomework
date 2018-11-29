using homework10;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace ordertest {
    /// <summary>
    /// OrderService:provide ordering service,
    /// like add order, remove order, query order and so on
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    /// </summary>
    
    public class OrderService {

        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="order">the order will be added</param>
        private Dictionary<uint, Order> orderDict;
        public List<Order> Orders
        {
            get { return orderDict.Values.ToList<Order>(); }
        }
        public void AddOrder(Order order) {
            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                db.SaveChanges();
            }
        }
        public void Update(Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Attach(order);
                db.Entry(order).State = EntityState.Modified;
                order.Details.ForEach(detail => db.Entry(detail).State = EntityState.Modified);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// cancel order
        /// </summary>
        /// <param name="orderId">id of the order which will be canceled</param> 
        public void RemoveOrder(string orderId)
        {
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("Details").SingleOrDefault(o => o.Id == orderId);
                db.OrderDetail.RemoveRange(order.Details);
                db.Order.Remove(order);
                db.SaveChanges();
            }

        }

        /// <summary>
        /// query all orders
        /// </summary>
        /// <returns>List<Order>:all the orders</returns> 
        public List<Order> QueryAllOrders() {
            using (var db = new OrderDB())
            {
                return db.Order.Include("Details").ToList<Order>();
            }
        }

        /// <summary>
        /// query by goodsName
        /// </summary>
        /// <param name="goodsName">the name of goods in order's orderDetail</param>
        /// <returns></returns> 
        public List<Order> QueryByGoodsName(string goodsName) {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("Details")
                    .Where(o => o.Details.Where(detail => detail.Goods.Name.Equals(goodsName)).Count() > 0);
                return query.ToList<Order>();
            }
        }

        /// <summary>
        /// query by customerName
        /// </summary>
        /// <param name="customerName">customer name</param>
        /// <returns></returns> 
        public List<Order> QueryByCustomerName(string customerName) {
            using (var db = new OrderDB())
            {
                var query = db.Order.Include("Details")
                    .Where(o => o.Customer.Name.Equals(customerName));
                return query.ToList<Order>();
            }
        }
        
        public Order GetOrder(String Id)//通过Id查找订单
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("Details").
                  SingleOrDefault(o => o.Id == Id);
            }
        }

        //public List<Order> QueryByPrice(double price)
        //{
        //        using (var db=new OrderDB())
        //        {
        //            var query = db.Order.Include("Details")
        //            .Where(o => o.Details.Where(detail => detail.Goods.Price.Equals(price)).Count() > 0);
        //            return query.ToList<Order>();
        //        }
        //}

        public void ExportXML()//输出为xml文件
        {
            using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                xmlSerializer.Serialize(stringWriter, Orders);
                FileStream fs = new FileStream("../../orders.xml", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(stringWriter.ToString());
                sw.Close();
                fs.Close();
            }

        }

        public void ExportHTML()
        {
            ExportXML();
            //XPathDocument myXPathDoc = new XPathDocument();
            string xmlContent = File.ReadAllText("../../orders.xml");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);


            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("../../orders.xslt");
            XmlTextWriter myWriter = new XmlTextWriter("../../result.html", null);
            myXslTrans.Transform(xmlDoc, null, myWriter);
            myWriter.Flush();
            myWriter.Close();

        }
        /*other edit function with write in the future.*/

    }
}
