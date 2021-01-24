using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //ekle,sil,listele gibi operasyonlar burada gerçekleşiyor
        public void Add(Product product) //product için verilen değer Product class ına atansın
        {
            //program.cs den verileri add ile almak için kullanılan alan
            Console.WriteLine(product.ProductName + "eklendi");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi");

        }
        
    }
}
