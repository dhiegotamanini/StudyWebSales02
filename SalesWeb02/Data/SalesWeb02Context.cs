using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb02.Models;

namespace SalesWeb02.Data
{
    public class SalesWeb02Context : DbContext
    {
        public SalesWeb02Context (DbContextOptions<SalesWeb02Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb02.Models.Department> Department { get; set; }
    }
}
