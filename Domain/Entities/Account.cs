using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Domain.Entities
{
    public class Account
    {
        public long Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Balance { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

        //public Customer Customers { get; set; }
        //public ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();
    }
}
