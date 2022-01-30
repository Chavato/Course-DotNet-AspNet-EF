//  System.Console.WriteLine("Enter the number of products: ");
//             int n = int.Parse(Console.ReadLine());

//             List<Product> products = new List<Product>();

//             for (int i = 0; i < n; i++)
//             {
//                 System.Console.WriteLine("Product #i data:");
//                 System.Console.WriteLine("Common, used or imported (c/u/i)? ");
//                 char typeProduct = char.Parse(Console.ReadLine());

//                 System.Console.WriteLine("Name: ");
//                 string name = Console.ReadLine();

//                 System.Console.WriteLine("Price: ");
//                 double price = double.Parse(Console.ReadLine());

//                 if (typeProduct == 'c')
//                 {
//                     products.Add(new Product(name, price));
//                 }

//                 else if (typeProduct == 'i')
//                 {
//                     System.Console.WriteLine("Customs fee: ");
//                     double customsFee = double.Parse(Console.ReadLine());
//                     products.Add(new ImportedProduct(name, price, customsFee));
//                 }
//                 else if (typeProduct == 'u')
//                 {
//                     System.Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
//                     DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
//                     products.Add(new UsedProduct(name, price, manufactureDate));
//                 }


//             }
//             System.Console.WriteLine("----------------------------------------");
//             System.Console.WriteLine();
//             System.Console.WriteLine("PRICE TAGS:");
//             foreach (Product product in products)
//             {
//                 System.Console.WriteLine(product.priceTag());
//             }