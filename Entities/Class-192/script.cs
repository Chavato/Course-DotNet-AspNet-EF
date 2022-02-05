// using System;
// using System.IO;
// using Entities.Class192;
// using System.Collections.Generic;
// using System.Globalization;



// namespace Course_DotNet_AspNet_EF
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             System.Console.WriteLine("Enter file full path: ");
//             string sourceFilePath = Console.ReadLine();

//             try
//             {
//                 string[] lines = File.ReadAllLines(sourceFilePath);

//                 string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
//                 string targetFolderPath = sourceFolderPath + @"\out";
//                 string targetFilePath = targetFolderPath + @"\summary.csv";

//                 Directory.CreateDirectory(targetFolderPath);

//                 using (StreamWriter sw = File.AppendText(targetFilePath))
//                 {
//                     foreach (string line in lines)
//                     {
//                         string[] fields = line.Split(',');
//                         string name = fields[0];
//                         double priceUnit = double.Parse(fields[1], CultureInfo.InvariantCulture);
//                         int quant = int.Parse(fields[2]);

//                         Product product = new Product(name, quant, priceUnit);

//                         sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));


//                     }


//                 }

//             }
//             catch (IOException e)
//             {
//                 System.Console.WriteLine("An error occurred");
//                 System.Console.WriteLine(e.Message);
//             }

//         }
//     }
// }
