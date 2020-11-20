using SalesWeb02.Models;
using SalesWeb02.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb02.Data
{
    public class SeedingService
    {
        private SalesWeb02Context _context;

        public SeedingService(SalesWeb02Context context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any()
                )
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Foods");
            Department d4 = new Department(4, "Engineer");
            Department d5 = new Department(5, "Grocery");
            Department d6 = new Department(6, "Books and Stories");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 25), 500.00, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1978, 2, 15), 3500.00, d2);
            Seller s3 = new Seller(3, "Jose Fernandes", "jose@gmail.com", new DateTime(1998, 4, 25), 1500.00, d3);
            Seller s4 = new Seller(4, "Renata Cerqueira", "renata@gmail.com", new DateTime(1988, 10, 14), 800.00, d1);
            Seller s5 = new Seller(5, "Jessica Silva", "quinha@gmail.com", new DateTime(1987, 7, 14), 900.00, d4);
            Seller s6 = new Seller(6, "Alice Costa", "bob@gmail.com", new DateTime(1988, 12, 11), 700.00, d5);


            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 8, 23), 200.00, SalesStatus.Canceled, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2019, 2, 8), 50.00, SalesStatus.Canceled, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2019, 5, 30), 230.00, SalesStatus.Pedding, s2);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 4, 25), 680.00, SalesStatus.Pedding, s3);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 4, 29), 180.30, SalesStatus.Canceled, s2);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2020, 9, 12), 240.12, SalesStatus.Billed, s3);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2020, 7, 10), 1500.23, SalesStatus.Billed, s2);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2017, 8, 28), 1500.00, SalesStatus.Billed, s2);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2020, 8, 23), 1500.00, SalesStatus.Billed, s2);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 9, 21), 1500.00, SalesStatus.Billed, s4);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 12, 12), 1500.00, SalesStatus.Billed, s4);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 12, 12), 7500.00, SalesStatus.Billed, s4);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2020, 5, 24), 1500.00, SalesStatus.Billed, s4);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2020, 1, 14), 1500.00, SalesStatus.Billed, s4);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2020, 6, 15), 1500.00, SalesStatus.Billed, s4);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 9, 8), 85.00, SalesStatus.Billed, s4);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2020, 7, 26), 1500.00, SalesStatus.Billed, s4);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2020, 3, 23), 1500.00, SalesStatus.Pedding, s1);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s1);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s1);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s3);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s3);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s3);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s3);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s3);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s3);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s3);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s1);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s5);
            SalesRecord sr31 = new SalesRecord(31, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s5);
            SalesRecord sr32 = new SalesRecord(32, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr33 = new SalesRecord(33, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr34 = new SalesRecord(34, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s5);
            SalesRecord sr35 = new SalesRecord(35, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s5);
            SalesRecord sr36 = new SalesRecord(36, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr37 = new SalesRecord(37, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr38 = new SalesRecord(38, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr39 = new SalesRecord(39, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr40 = new SalesRecord(40, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s5);
            SalesRecord sr41 = new SalesRecord(41, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s5);
            SalesRecord sr42 = new SalesRecord(42, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s5);
            SalesRecord sr43 = new SalesRecord(43, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s5);
            SalesRecord sr44 = new SalesRecord(44, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s1);
            SalesRecord sr45 = new SalesRecord(45, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s1);
            SalesRecord sr46 = new SalesRecord(46, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s1);
            SalesRecord sr47 = new SalesRecord(47, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s1);
            SalesRecord sr48 = new SalesRecord(48, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s1);
            SalesRecord sr49 = new SalesRecord(49, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s2);
            SalesRecord sr50 = new SalesRecord(50, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s2);
            SalesRecord sr51 = new SalesRecord(51, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s2);
            SalesRecord sr52 = new SalesRecord(52, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s3);
            SalesRecord sr53 = new SalesRecord(53, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s3);
            SalesRecord sr54 = new SalesRecord(54, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s3);
            SalesRecord sr55 = new SalesRecord(55, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s4);
            SalesRecord sr56 = new SalesRecord(56, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Pedding, s4);
            SalesRecord sr57 = new SalesRecord(57, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s4);
            SalesRecord sr58 = new SalesRecord(58, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Billed, s2);
            SalesRecord sr59 = new SalesRecord(59, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s2);
            SalesRecord sr60 = new SalesRecord(60, new DateTime(2018, 4, 25), 1500.00, SalesStatus.Canceled, s2);

            _context.Department.AddRange(d1, d2, d3, d4, d5, d6);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10,sr10, 
                                         sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20,
                                         sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30,
                                         sr31, sr32, sr33, sr34, sr35, sr36, sr37, sr38, sr39, sr40,
                                         sr41, sr42, sr43, sr44, sr45, sr46, sr47, sr48, sr49, sr50,
                                         sr51, sr52, sr53, sr54, sr55, sr56, sr57, sr58, sr59, sr60

                );

            _context.SaveChanges();
        }
    }
}
