using SalesWeb02.Data;
using SalesWeb02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb02.Services
{
    public class DepartmentService
    {
        private readonly SalesWeb02Context _context;

        public DepartmentService(SalesWeb02Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(c => c.Name).ToList();
        }
    }
}
