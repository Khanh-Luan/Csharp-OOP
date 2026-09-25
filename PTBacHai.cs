// using System;

// class PTBacHai
// {
//     static void Main()
//     {
//         Console.Write("NhAp a: ");
//         double a = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Nhap b: ");
//         double b = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Nhap c: ");
//         double c = Convert.ToDouble(Console.ReadLine());

//         if (a == 0)
//         {
//             // Nếu a = 0 thì trở thành phương trình bậc nhất
//             if (b == 0)
//             {
//                 if (c == 0)
//                     Console.WriteLine("Phuong trinh co vo so nghiem.");
//                 else
//                     Console.WriteLine("Phuong trinh vo nghiem.");
//             }
//             else
//             {
//                 double x = -c / b;
//                 Console.WriteLine("Phuong trinh bac nhat, nghiem x = " + x);
//             }
//         }
//         else
//         {
//             double delta = b * b - 4 * a * c;

//             if (delta < 0)
//                 Console.WriteLine("Phuong trinh vo nghiem.");
//             else if (delta == 0)
//             {
//                 double x = -b / (2 * a);
//                 Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
//             }
//             else
//             {
//                 double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//                 double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
//                 Console.WriteLine("Phuong trinh co hai nghiem phan biet:");
//                 Console.WriteLine("x1 = " + x1);
//                 Console.WriteLine("x2 = " + x2);
//             }
//         }
//     }
// }
