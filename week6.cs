// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Static_demo
// {
//     class A
//     {
//         static public int a;
//         public int b;
//         public static void Xuat()
//         {
//             Console.WriteLine(a.ToString());
//         }
//         public void Xuat1()
//         {
//             Console.WriteLine(b.ToString());
//         }
//     }
//     public static class B
//     {
//         public static int x;//bắt buộc phải là static
//         public static void Xuat()//bắt buộc phải là static
//         {
//             Console.WriteLine(x.ToString());
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             A classA = new A();
//             classA.b = 8;
//             classA.Xuat1();
//             A.a = 7; A.Xuat();
//             //B classB = new B();//Không thể chạy được dòng này
//             B.x = 10;
//             B.Xuat();
//         }
//     }
// }