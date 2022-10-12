namespace Proje11_Collections_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //List<int> sayilar = new List<int>();
            //sayilar.Add(12);
            //sayilar.Add(120);
            //sayilar.Add(1200);
            //sayilar.Add(12000);
            //sayilar.Add(120000);

            //List<string> Isimler = new List<string>();
            //Isimler.Add("ali");
            //Isimler.Add("begum");
            //Isimler.Add("kemal");
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //foreach (var isim in Isimler)
            //{
            //    Console.WriteLine(isim);
            //}


            //Product product1 = new Product() { Id = 1, Name = "bılgısayar", Prıce = 10000 };
            //Product product2 = new Product() { Id = 1, Name = "bılgısayar", Prıce = 10000 };
            //Product product3 = new Product() { Id = 1, Name = "bılgısayar", Prıce = 10000 };

            //List<Product> products = new List<Product>() { product1, product2, product3 };



            //List<Product> products2 = new List<Product>();
            //products.Add(product1);
            //products.Add(product2);
            //products.Add(product3);



            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=1, Name="telefon",Price=10000},
            //    new Product(){Id=2, Name="bılgısayar",Price=20000},
            //    new Product(){Id=3, Name="masa sandalye",Price=3000}

            //};
            //// yenı bır product yaratın Adı da newProducts olsun.ıcıne tıpkı yukarıdakı gıbı 3 yenı urun bılgısı gırsın

            //List<Product> newProducts = new List<Product>()
            //{
            //    new newProduct(){Id=4, Name=Mouse,Price=100},
            //    new newProduct(){Id=4, Name=Mouse,Price=100},
            //    new newProduct(){Id=4, Name=Mouse,Price=100},


            //};
            ////newProducts ıcındekı productları product ıcıne ekleyecegız
            //products.AddRange(newProducts);

            //products.ForEach(product =>{
            //    Console.WriteLine($"{product.name}");
            //    Console.WriteLine();
            //});

            //int elemanSayisi=products.Count();
            //products.Insert(0,new Product() { Id=21,Name="gozluk",Price=10});



            //Console.ReadLine();



            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=1, Name="telefon",Price=10000},
            //    new Product(){Id=2, Name="bılgısayar",Price=20000},
            //    new Product(){Id=3, Name="masa sandalye",Price=3000}

            //};
            //ProductModel model = new ProductModel()
            //{
            //    Id=1,
            //    CategoryName="First Category",
            //    Products=
            //}
            #endregion
            // ıcınde 3 adet ProductModel tıpınde veri barındıran bir list olusturun.
            // Her bir ProductModel içinde ise Products ozelıgıne 3er adet product koyun
            


            foreach (var productModel in ProductModels)
            {
                Console.WriteLine($"Product Model Id: {productModel.Id}-Category Name: {productModel.CategoryName}");
                foreach (var product in productModel.Products)
                {
                    Console.WriteLine($"\tProduct Id: {product.Id}-Product Name: {product.Name}-Product Prıce: {product.Price}");
                }
                Console.WriteLine("*************************************");
            }




        }

    }
}