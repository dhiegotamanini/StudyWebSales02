using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb02.Models;
using SalesWeb02.Models.ViewModels;
using SalesWeb02.Services;

namespace SalesWeb02.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _context;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService context, DepartmentService departmentService)
        {
            _context = context;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _context.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var listDepartments = _departmentService.FindAll();
            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Departments = listDepartments }; 
            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _context.AddSeller(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var seller = _context.Find(id.Value);
            if(seller == null)
            {
                return NotFound();
            }

            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _context.Remove(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
