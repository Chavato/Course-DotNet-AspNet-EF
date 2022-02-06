
//    System.Console.WriteLine("Enter contract data!");

//             System.Console.WriteLine("Number: ");
//             int number = int.Parse(Console.ReadLine());

//             System.Console.WriteLine("Date (dd/MM/yyyy): ");
//             DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-br"));

//             System.Console.WriteLine("Contract Value: ");
//             double totalValue = double.Parse(Console.ReadLine());

//             System.Console.WriteLine("Enter number os installments:");
//             int months = int.Parse(Console.ReadLine());

//             Contract contract = new Contract(number, date, totalValue);

//             ContractService contractService = new ContractService(new PaypalService());
//             contractService.ProcessContract(contract, months);

//             System.Console.WriteLine();
//             System.Console.WriteLine("Installements");
//             foreach (Installment installment in contract.Installments)
//             {
//                 System.Console.WriteLine(installment);
//             }

