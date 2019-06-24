using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{

    /// <summary>
    /// Propriedades
    /// </summary>
    public class Department
    {
        [Key]
        public int Id { get; set;}
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        /// <summary>
        /// Construtores
        /// </summary>
        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Department(string name)
        {
            Name = name;
        }

        /// <summary>
        /// metodos
        /// </summary>
        /// <param name="seller"></param>
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));
        }
    }
}
