using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Sales
    {
        private int Id { get; set; }
        private double Payment { get; set; }
        private string Status { get; set; }
        private DateTime date { get; set; }
        private double Amount { get; set; }
        public ICollection<SalesRecord> SalesRecords = new List<SalesRecord>();
        public ICollection<Product> Product = new List<Product>();

        public Sales()
        {
        }

    }
}
