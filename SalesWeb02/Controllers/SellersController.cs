using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWeb02.Models;
using SalesWeb02.Services;

namespace SalesWeb02.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _context;

        public SellersController(SellerService context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _context.AddSeller(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
