using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    public class Customer {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public Customer() { }

        public Customer(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// override ToString
        /// </summary>
        /// <returns>string:message of the Customer object</returns>
        public override string ToString()
        {
            return $"customerId:{Id}, CustomerName:{Name}";
        }
    }
}
