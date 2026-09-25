// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Transitive_demo
// {
//     class A
//     {
//         protected int a;
//     }
//     class B : A
//     {
//         protected int b;
//     }
//     class C : B
//     {
//         private int c;
//         public void Nhap()
//         {
//             a = 8;
//             b = 9;
//             c = 10;
//         }
//         public void Xuat()
//         {
//             Console.WriteLine(a + "," + b + "," + c);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             C classC = new C();
//             classC.Nhap();
//             classC.Xuat();
//         }
//     }
// }