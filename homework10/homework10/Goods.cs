using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest {
    /// <summary>
    /// Goods class:the message of goods
    /// </summary>
    public class Goods {
        [Key]
        public string Id { get; set; }

        private double price;
        public string Name { get; set; }
        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }

        public Goods() { }
        public Goods(string id, string name, double value) {
            Id = id;
            Name = name;
            Price = value;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Goods object</returns>
        public override string ToString() {
            return $"Id:{Id}, Name:{Name}, Value:{Price}";
        }
    }
}
