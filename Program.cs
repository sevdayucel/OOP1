using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName="kalem", UnitPrice = 35 };

            //her iki yazım şekli ile veri veriebilir.
            //Pascal Case kelimelerin ilk harfleri büyük. (class a verilen isim)
            //productManager yazımı camel case
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //diziler ve class lar referans tiptir.

        }
    }
}
