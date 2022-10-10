namespace Proje01_Class_Field_Property_Uygulama
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Product classımız olacak. Name, price. description
            // İstenildigi kadar product bılgısının girilmesını saglayacagız
            // kac adet product bılgısı gırılecegını kullanıcı belırlesın
            // product ekleme ısı bıtınce eklenmıs productlar lıstelensın

            //Console.Write("kac adet urun gıreceksınız?: ");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products= new Product[adet];
            //Product product;
            //for (int i = 0; i < adet; i++)
            //{
            //    product = new Product();
            //    Console.Write("product name: ");
            //    product.Name = Console.ReadLine();

            //    Console.Write("price: ");
            //    product.Price=decimal.Parse(Console.ReadLine());

            //    Console.Write("description: ");
            //    product.Description=Console.ReadLine();
            //    products[i] = product;  
            //}
            //Console.WriteLine("product name\tprice\tdescriptıon");
            //foreach (var prd in products)
            //{
            //    Console.WriteLine($"{prd.Name}\t{prd.Price}\t{prd.Description}");
            //}

            #region RastgeleDegerUreterek
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "galaxy a50", "hp notebook", "macbok air", "ıphone", "lg"};
            string[] descriptionArray = { "iyidir", "sasırtıcıdır", "heyecan verıcıdır", "solugunuzu keser", "tırttır" };
            decimal[] oldPrices = new decimal[5];
            Random random= new Random();
            Console.WriteLine("yapılacak zam oranını gırınız: ");
            decimal oran =decimal.Parse(Console.ReadLine());
             
            for (int i = 0; i < 5; i++)
            {
                product = new Product()
                {
                    Name = nameArray[random.Next(0, 5)],
                    Description = descriptionArray[random.Next(0, 5)],
                    Price = random.Next(100, 1001),
                    
                };
                oldPrices[i]=product.Price;
                product.Price*=(1 + (oran/100));
                products[i] = product;
            }
            Console.WriteLine($"product name".PadRight(30) +"oldPrices".PadLeft(10)+ "price".PadRight(10) + "description");
            int j = 0;
            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.Name.PadRight(30)}{oldPrices[j].ToString().PadRight(10)}{prd.Price.ToString().PadRight(10)}{prd.Description}");
                j++;
            }
            #endregion




        }
    }
}