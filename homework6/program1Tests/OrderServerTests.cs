using Microsoft.VisualStudio.TestTools.UnitTesting;
using myProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Tests
{
    [TestClass()]
    public class OrderServerTests
    {

        [TestMethod()]
        public void addGuestTest()
        {
            OrderServer.addGuest("005", "E", "e", 200000);
            List<Order> Inf2 = new List<Order>()
            {
                new Order("001","A","a",11000),
                new Order("002","B","b",9000),
                new Order("003","C","c",15000),
                new Order("005", "E", "e", 200000)
            };
            Assert.AreEqual(Inf2, Inf2);
        }

        [TestMethod()]
        public void addGuestTest2()
        {
            OrderServer.addGuest("", "", "", 0);
            List<Order> Inf2 = new List<Order>()
            {
                new Order("001","A","a",11000),
                new Order("002","B","b",9000),
                new Order("003","C","c",15000),
                new Order("", "", "", 0)
            };
            Assert.AreEqual(Inf2, Inf2);
        }

        [TestMethod()]
        public void deleteTest()
        {
            Order deleteObj = new Order("001", "A", "a", 11000);
            OrderServer.delete(deleteObj);
            List<Order> Inf2 = new List<Order>()
            {
                new Order("002","B","b",9000),
                new Order("003","C","c",15000),
            };
            Assert.AreEqual(Inf2, Inf2);
        }

        [TestMethod()]
        public void deleteTest2()
        {
            Order deleteObj = new Order("", "", "", 0);
            OrderServer.delete(deleteObj);
            List<Order> Inf2 = new List<Order>()
            {
                new Order("001","A","a",11000),
                new Order("002","B","b",9000),
                new Order("003","C","c",15000),
            };
            Assert.AreEqual(Inf2, Inf2);
        }

        [TestMethod()]
        public void modifyOrderTest()
        {
            Order modifyObj = new Order("001", "A", "a", 11000);
            OrderServer.modifyOrder(modifyObj, "", "", "", 0);
            List<Order> Inf2 = new List<Order>()
            {
                new Order("","","",0),
                new Order("002","B","b",9000),
                new Order("003","C","c",15000),
            };
            Assert.AreEqual(Inf2, Inf2);
        }

        [TestMethod()]
        public void modifyOrderTest2()
        {
            Order modifyObj = new Order("", "", "", 0);
            OrderServer.modifyOrder(modifyObj, "dsg", "fsd", "sdf", 10000000);
            List<Order> Inf2 = new List<Order>()
            {
                new Order("001", "A", "a", 11000),
                new Order("002","B","b",9000),
                new Order("003","C","c",15000),
            };
            Assert.AreEqual(Inf2, Inf2);
        }
    }
}