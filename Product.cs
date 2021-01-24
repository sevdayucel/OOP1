using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //prop çift tab ile public şablonu oluşur 
        public int Id { get; set; } //primary key
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
