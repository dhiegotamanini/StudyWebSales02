﻿using SalesWeb02.Data;
using SalesWeb02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb02.Services
{
    public class SellerService
    {
        private readonly SalesWeb02Context _context;

        public SellerService(SalesWeb02Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void AddSeller(Seller seller)
        {
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }

        public Seller Find(int id)
        {
            return _context.Seller.Where(c => c.ID == id).SingleOrDefault();
        }

        public void Remove(int id)
        {
            _context.Remove(Find(id));
            _context.SaveChanges();
        }

    }
}
