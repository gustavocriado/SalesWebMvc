using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
                List.Add(new Department { Id = 1, Name = "Eletronics" });
                List.Add(new Department { Id = 2, Name = "Fashion" });
                List.Add(new Department { Id = 3, Name = "Warehouse" });
                List.Add(new Department { Id = 4, Name = "Toys" });
                List.Add(new Department { Id = 5, Name = "Decoration" });
                List.Add(new Department { Id = 6, Name = "Furniture" });

            return View(List);
        }
    }
}