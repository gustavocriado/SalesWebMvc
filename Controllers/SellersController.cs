using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services.Exceptions;
using System.Diagnostics;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerServices _sellerService;
        private readonly DepartmentServices _departmentServices;

        public SellersController(SellerServices sellerServices, DepartmentServices departmentServices)
        {
            _sellerService = sellerServices;
            _departmentServices = departmentServices;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _sellerService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var departments = await _departmentServices.FindAllAsync();
            var viewmodel = new SellerFormViewModel { Departments = departments };
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var Department = await _departmentServices.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = Department };
                return View(viewModel);
            }
           await _sellerService.insertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Is Null or not provided " });
            }

            var obj = await _sellerService.FindByIdAsync(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Not Found" });
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _sellerService.RemoveAsync(Id);
                return RedirectToAction(nameof(Index));
            }
            catch(IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new {Message = "Can´t to delete the seller because he/she has sales Record active" });
            }
        }
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id is Null or not provided" });
            }

            var obj = await _sellerService.FindByIdAsync(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Not Found" });
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id is Null or not provided" });
            }
            var obj = _sellerService.FindByIdAsync(Id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id Not Found" });
            }
            List<Department> departments = await _departmentServices.FindAllAsync();
            SellerFormViewModel viewModel = new SellerFormViewModel { Seller = await obj, Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var Department = await _departmentServices.FindAllAsync();
                var viewModel = new SellerFormViewModel { Seller = seller, Departments = Department };
                return View(viewModel);
            }

            if (Id != seller.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                 await _sellerService.UpdateAsync(seller);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
