using System;

namespace QuizDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Lenovo Laptop";
            product1.ProductPrice = 4499.99;
            product1.ProductStock = 26;
            product1.WarrantyPeriod = "24 Ay";
            product1.SellerName = "TeknoMarket44";

            Product product2 = new Product();
            product2.ProductName = "Rayban Gözlük";
            product2.ProductPrice = 1129.00;
            product2.ProductStock = 17;
            product2.WarrantyPeriod = "12 Ay";
            product2.SellerName = "Gozlukcum";

            Product product3 = new Product();
            product3.ProductName = "Home Silikon Yastık";
            product3.ProductPrice = 49.90;
            product3.ProductStock = 86;
            product3.WarrantyPeriod = "12 Ay";
            product3.SellerName = "İstikbalYatak";

            Product product4 = new Product();
            product4.ProductName = "Jack & Jones Erkek BEYAZ Sweatshirt";
            product4.ProductPrice = 280.00;
            product4.ProductStock = 145;
            product4.WarrantyPeriod = "24 Ay";
            product4.SellerName = "MarkaStok";

            Product[] products = new Product[] { product1, product2, product3, product4};

            foreach (Product item in products)
            {
                Console.WriteLine(item.ProductName + "\n Ürün Fiyatı: " + item.ProductPrice + "\n Kalan Stok: " + item.ProductStock + "\n Garanti Süresi: " + item.WarrantyPeriod + "\n Satıcı: " + item.SellerName + "\n");
            }

            Console.WriteLine("Foreach Bitti \n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + "\n Ürün Fiyatı: " + products[i].ProductPrice + "\n Kalan Stok: " + products[i].ProductStock + "\n Garanti Süresi: " + products[i].WarrantyPeriod + "\n Satıcı: " + products[i].SellerName + "\n");
            }
            Console.WriteLine("For Bitti \n");

            int kosul = 0;
            while (kosul < products.Length)
            {
                Console.WriteLine(products[kosul].ProductName + "\n Ürün Fiyatı: " + products[kosul].ProductPrice + "\n Kalan Stok: " + products[kosul].ProductStock + "\n Garanti Süresi: " + products[kosul].WarrantyPeriod + "\n Satıcı: " + products[kosul].SellerName + "\n");
                kosul++;
            }


        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public string WarrantyPeriod { get; set; }
        public string SellerName { get; set; }
        public double ProductPrice { get; set; }
    }
}
