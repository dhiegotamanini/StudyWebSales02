using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb02.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }
        public Department(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public void AddSeler(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime inicial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(inicial, final));
        }
    }
}
