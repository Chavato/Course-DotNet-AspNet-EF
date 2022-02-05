// try
//             {
//                 System.Console.WriteLine("Enter real data");
//                 System.Console.WriteLine("Car Model: ");
//                 string model = Console.ReadLine();
//                 System.Console.Write("Pickup (dd/MM/yyyy hh:mm: ");
//                 DateTime start = DateTime.ParseExact(Console.ReadLine(), "g", CultureInfo.CreateSpecificCulture("pt-BR"));
//                 System.Console.Write("Return (dd/MM/yyyy hh:mm: ");
//                 DateTime finish = DateTime.ParseExact(Console.ReadLine(), "g", CultureInfo.CreateSpecificCulture("pt-BR"));

//                 System.Console.Write("Enter price hour: ");
//                 double hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//                 System.Console.Write("Enter price day: ");
//                 double dayPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//                 CarRental carRental = new CarRental(start, finish, new Vehicle(model));

//                 RentalService rentalService = new RentalService(hourPrice, dayPrice, new BrazilianTaxService());

//                 rentalService.ProcessInvoice(carRental);

//                 System.Console.WriteLine();
//                 System.Console.WriteLine("INVOICE:");
//                 System.Console.WriteLine(carRental.Invoice);
//             }
//             catch (Exception e)
//             {
//                 System.Console.WriteLine(e.Message);
//             }