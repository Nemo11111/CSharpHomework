using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    /// <summary>
    /// OrderDetail class : a entry of an order object
    /// to record the goods and its quantity
    /// </summary>
    public class OrderDetail {
        [Key]
        public string Id { get; set; }

        public Goods Goods { get; set; }
        public uint Quantity { get; set; }

        public OrderDetail() { }
        public OrderDetail(string id, Goods goods, uint quantity)
        {
            this.Id = id;
            this.Goods = goods;
            this.Quantity = quantity;
        }
        //public override bool Equals(object obj)
        //{
        //    var detail = obj as OrderDetail;
        //    return detail != null &&
        //        Goods.Id==detail.Goods.Id&&
        //        Quantity == detail.Quantity;
        //}

        //public override int GetHashCode()
        //{
        //    var hashCode = 1522631281;
        //    hashCode = hashCode * -1521134295 + Goods.Name.GetHashCode();
        //    hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
        //    return hashCode;
        //}

        //public override string ToString() {
        //    string result = "";
        //    result += $"orderDetailId:{Id}:  ";
        //    result += Goods + $", quantity:{Quantity}"; 
        //    return result;
        //}

    }
}
