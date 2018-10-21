using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace myProgram
{
    [Serializable]
    public class Order
    {
            public string orderNum { get; set; }
            public string goodsName { get; set; }
            public string guestName { get; set; }
            public int goodsMoney { get; set; }
            public Order() { }
            public Order(string num, string goodsname, string guestname, int goodsmoney)
            {
                this.orderNum = num;
                this.goodsName = goodsname;
                this.guestName = guestname;
                this.goodsMoney = goodsmoney;
            }
            public override string ToString()
            {
                return orderNum + " " + goodsName + " " + guestName + " " + goodsMoney;
            }
    }

    [Serializable]
    public class OrderDetails : OrderServer
    {
        public OrderDetails() { }
        static public void searchByNum(string num)
        {
            var Search = from n in Inf
                         where n.orderNum == num
                         select n;
            foreach (var m in Search)
            {
                Console.WriteLine("存在该订单，详细信息为：");
                Console.WriteLine("订单编号：" + m.orderNum + " 商品名称：" + m.goodsName + " 客户名称：" + m.guestName + " 商品价格：" + m.goodsMoney);
            }
        }
        static public void searchByGoodsName(string goodsname)
        {
            var Search = from n in Inf
                         where n.goodsName == goodsname
                         select n;
            foreach (var m in Search)
            {
                Console.WriteLine("存在该订单，详细信息为：");
                Console.WriteLine("订单编号：" + m.orderNum + " 商品名称：" + m.goodsName + " 客户名称：" + m.guestName + " 商品价格：" + m.goodsMoney);
            }
        }
        static public void searchByguestName(string guestname)
        {
            var Search = from n in Inf
                         where n.guestName == guestname
                         select n;
            foreach (var m in Search)
            {
                Console.WriteLine("存在该订单，详细信息为：");
                Console.WriteLine("订单编号：" + m.orderNum + " 商品名称：" + m.goodsName + " 客户名称：" + m.guestName + " 商品价格：" + m.goodsMoney);
            }
        }
        static public void money()
        {
            var Search = from n in Inf
                         where n.goodsMoney > 10000
                         select n;
            foreach (var m in Search)
            {
                Console.WriteLine("存在该订单，详细信息为：");
                Console.WriteLine("订单编号：" + m.orderNum + " 商品名称：" + m.goodsName + " 客户名称：" + m.guestName + " 商品价格：" + m.goodsMoney);
            }
        }
    }

    [Serializable]
    public class OrderServer : Order
    {
        public OrderServer() { }
        //初始化一部分订单
        static public List<Order> Inf = new List<Order>() {
            new Order("001","A","a",11000),
            new Order("002","B","b",9000),
            new Order("003","C","c",15000)
        };

        //添加订单
        static public void addGuest(string num, string goodsname, string guestname, int goodsmoney)
        {
            Inf.Add(new Order(num, goodsname, guestname, goodsmoney));
            Console.WriteLine("订单添加成功！");
        }

        //删除订单
        static public void delete(Order deleteOrder)
        {
            foreach (Order delete in Inf)
            {
                if (delete.orderNum == deleteOrder.orderNum && delete.goodsName == deleteOrder.goodsName && delete.guestName == deleteOrder.guestName)
                {
                    Inf.Remove(delete);
                    Console.WriteLine("订单删除成功！");
                    break;
                }
                else
                {
                    Console.WriteLine("订单删除失败，请核对信息！");
                    Console.WriteLine("订单号是否相同：" + delete.orderNum == deleteOrder.orderNum);
                    Console.WriteLine("商品名称是否相同：" + delete.goodsName == deleteOrder.goodsName);
                    Console.WriteLine("客户名称是否相同：" + delete.guestName == deleteOrder.guestName);
                }
            }
        }

        //修改订单
        static public void modifyOrder(Order modifyOrder, string num, string goodsname, string guestname, int goodsmoney)
        {
            var tempMyOrder = new Order("", "", "", 0);
            foreach (Order modify in Inf)
            {
                if (modifyOrder.orderNum == modify.orderNum && modify.goodsName == modifyOrder.goodsName && modify.guestName == modifyOrder.guestName)
                {
                    tempMyOrder = modify;
                }

            }
            if (num != null)
            {
                tempMyOrder.orderNum = num;
            }
            if (goodsname != null)
            {
                tempMyOrder.goodsName = goodsname;
            }
            if (guestname != null)
            {
                tempMyOrder.guestName = guestname;
            }
            if (goodsmoney >= 0)
            {
                tempMyOrder.goodsMoney = goodsmoney;
            }
        }

    }

    public class Program : OrderDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("目前已存在的订单：");
            foreach (Order my in Inf)
            {
                Console.WriteLine("订单编号：" + my.orderNum + " 商品名称：" + my.goodsName + " 客户名称：" + my.guestName + " 商品价格：" + my.goodsMoney);
            }

            Console.WriteLine("添加订单：");
            String name, goodsName, guestName;
            int goodsmoney;
            Console.WriteLine("添加订单的单号：");
            name = Console.ReadLine();
            Console.WriteLine("添加订单的商品名称：");
            goodsName = Console.ReadLine();
            Console.WriteLine("添加订单的客户名称：");
            guestName = Console.ReadLine();
            Console.WriteLine("添加订单的商品价格：");
            goodsmoney = Convert.ToInt32(Console.ReadLine());
            addGuest(name, goodsName, guestName, goodsmoney);
            Console.WriteLine("目前已存在的订单：");
            foreach (Order my in Inf)
            {
                Console.WriteLine("订单编号：" + my.orderNum + " 商品名称：" + my.goodsName + " 客户名称：" + my.guestName);
            }

            Console.WriteLine("删除订单：");
            Console.WriteLine("将要删除的订单为：\"001\",\"A\",\"a\",\"11000\"");
            var del = new Order("001", "A", "a", 11000);
            delete(del);
            foreach (Order my in Inf)
            {
                Console.WriteLine("订单编号：" + my.orderNum + " 商品名称：" + my.goodsName + " 客户名称：" + my.guestName + " 商品价格：" + my.goodsMoney);
            }

            Console.WriteLine("修改订单：");
            Console.WriteLine("将要修改的订单为：\"002\",\"B\",\"b\",\"9000\"");
            var del2 = new Order("002", "B", "b", 9000);
            modifyOrder(del2, "", "", "mine", 8000);
            foreach (Order my in Inf)
            {
                Console.WriteLine("订单编号：" + my.orderNum + " 商品名称：" + my.goodsName + " 客户名称：" + my.guestName + " 商品价格：" + my.goodsMoney);
            }

            Console.WriteLine("查询订单：");
            Console.WriteLine("按订单编号查询 1，按订单商品名称查询 2，按订单客户名称查询 3");
            String s;
            s = Console.ReadLine();
            if (s == "1")
            {
                String sNum;
                Console.WriteLine("输入查询订单的单号：");
                sNum = Console.ReadLine();
                searchByNum(sNum);
            }
            if (s == "2")
            {
                String sGoodsNam;
                Console.WriteLine("输入查询订单的商品名称：");
                sGoodsNam = Console.ReadLine();
                searchByGoodsName(sGoodsNam);
            }
            if (s == "3")
            {
                String sGuestName;
                Console.WriteLine("输入查询订单的客户名称：");
                sGuestName = Console.ReadLine();
                searchByguestName(sGuestName);
            }

            //用Linq查出订单金额大于一万的订单信息
            Console.WriteLine("以下输出订单金额大于一万的订单信息：\n");
            money();

            ////XML序列化
            //XmlSerializer xmlser = new XmlSerializer(typeof(Order));
            //String xmlFileName = "myXmlFile.xml";
            //XmlSerialize(xmlser, xmlFileName, Inf);

            ////显示XML文件
            //string xml = File.ReadAllText(xmlFileName);
            //Console.WriteLine(xml);

            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("myXmlFile.xml", FileMode.Create))
            {
                xmlser.Serialize(fs, Inf);
            }

            Console.WriteLine(File.ReadAllText("myXmlFile.xml"));
            //从XML文件中载入文件
            using (FileStream fs = new FileStream("myXmlFile.xml", FileMode.Open))
            {
                List<Order> persons3 = (List<Order>)xmlser.Deserialize(fs);
                foreach(Order mine in persons3)
                {
                    Console.WriteLine(mine);
                }
            }
        }
    }
}
