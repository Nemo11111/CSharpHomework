using ordertest;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    public class OrderDB : DbContext//继承DbContext类
    {
        public OrderDB() : base("OrderDataBase") { }//指定contextString
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}