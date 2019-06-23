using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _Context;

        public SeedingService(SalesWebMvcContext context)
        {
            _Context = context;
        }
        public void Seed()
        {
            if (_Context.Department.Any() ||
                _Context.Seller.Any() ||
                _Context.SalesRecords.Any())
            {
                ///Database has been seeded
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Fashion");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Eletronics");
            Department d5 = new Department(5, "Toys");
            Department d6 = new Department(6, "Clothes");
            Department d7 = new Department(7, "furniture");
            Department d8 = new Department(8, "Decoration");

            Seller s1 = new Seller(1, "Bob Brown","bob.computers@newstore.com",new DateTime(1998,5,21), 1.500, d1);
            Seller s2 = new Seller(2, "Bruce Batman", "batman.fashion@newstore.com", new DateTime(2000, 8, 30), 1.000, d2);
            Seller s3 = new Seller(3, "Alex Pigman", "pigman.books@newstore.com", new DateTime(1982, 2, 15), 15.000, d3);
            Seller s4 = new Seller(4, "Klark Crente", "klark.Eletronics@newstore.com", new DateTime(1945, 9, 4), 750, d4);
            Seller s5 = new Seller(5, "Jair Thanos", "Thanos.Toys@newstore.com", new DateTime(2015, 10, 19), 2.000, d5);
            Seller s6 = new Seller(6, "Peter SpiderMan", "Spider.Clothes@newstore.com", new DateTime(2007, 7, 20), 2.500, d6);
            Seller s7 = new Seller(7, "Ronald McDonalds", "Donalds.Furniture@newstore.com", new DateTime(2019, 6, 22), 6.000, d7);
            Seller s8 = new Seller(8, "Billie Joe", "Greenday.Decoration@newstore.com", new DateTime(1978, 8, 30), 80.000, d8);

            SalesRecord r1 = new SalesRecord(1,new DateTime(2019, 06, 22),11.000,SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2,new DateTime(2019, 06, 22), 12.000, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3,new DateTime(2019, 06, 22), 13.000, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 06, 22), 14.000, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 06, 22), 15.000, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 06, 22), 16.000, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 06, 22), 17.000, SaleStatus.Billed, s7);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 06, 22), 18.000, SaleStatus.Billed, s8);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 06, 22), 19.000, SaleStatus.Canceled, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 06, 22), 20.000, SaleStatus.Canceled, s2);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 06, 22), 21.000, SaleStatus.Canceled, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 06, 22), 22.000, SaleStatus.Canceled, s4);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 06, 22), 23.000, SaleStatus.Pending, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 06, 22), 24.000, SaleStatus.Pending, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 06, 22), 25.000, SaleStatus.Pending, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 06, 22), 26.000, SaleStatus.Pending, s4);

            _Context.Department.AddRange(d1, d2, d3, d4, d5, d6, d7, d8);
            _Context.Seller.AddRange(s1,s2,s3,s4,s5,s6,s7,s8);
            _Context.SalesRecords.AddRange(r1,r2,r3,r4,r5,
                                           r6,r7,r8,r9,r10,
                                          r11,r12,r13,r14,r15,r16);
            _Context.SaveChanges();
        }   
        }


    }
