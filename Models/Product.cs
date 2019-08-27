using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Product
    {
        private int id { get; set; }
        private string Name { get; set; }
        private int Quantity { get; set; }
        private string Description { get; set; }
        public ModelProduct Model { get; set; }
        public CategoryProduct Category { get; set; }
        public Sales Sales { get; set; }
    }
}
