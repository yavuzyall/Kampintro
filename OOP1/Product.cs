using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //ID --> Primary Key
        public int Id { get; set; }
        //Kategori Numarası --> Foreign Key
        public int CategoryId { get; set; }
        //Ürün İsmi
        public string ProductName { get; set; }
        //Ürün Fiyatı
        public double UnitPrice { get; set; }
        //Birimdeki Stock --> Stok Adedi
        public int UnitsInStock { get; set; }
    }
}
