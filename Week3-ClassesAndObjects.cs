// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// // Example 1
// namespace DemoClasses
// {
//     class Program
//     {
//         static void Main()
//         {
//             TimePeriod t = new TimePeriod();
//             // The property assignment causes the 'set' accessor to be called.
//             try
//             {
//                 t.Hours = 25;
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//             // Retrieving the property causes the 'get' accessor to be called.
//             Console.WriteLine($"Time in hours: {t.Hours}");
//         }
//     }
//     class TimePeriod
//     {
//         private double seconds;
//         private double hours;
//         public double Hours
//         {
//             get { return hours; }
//             set
//             {
//                 if (value < 0 || value > 24)
//                     throw new ArgumentOutOfRangeException(
//                     $"{nameof(value)} must be between 0 and 24.");
//                 hours = value;
//                 seconds = value * 3600;
//             }
//         }
//     }
// }
// // Example 2
// namespace DemoClasses
// {
//     public class SaleItem
//     {
//         public string Name 
//         {get; set;}
//         public decimal Price 
//         {get; set;}
//     }
//     class Program
//     {
//         static void Main()
//         {
//             var item = new SaleItem {Name = "Shoe", Price = 19.95m};
//             Console.WriteLine($"{item.Name}: Sell for {item.Price:C2}");
//         }
//     }
// }