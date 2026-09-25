// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Polymophism_demo
// {
//     public class Hinh
//     {
//         protected int x;//tọa độ x của điểm góc trên bên trái
//         protected int y;//tọa độ y của điểm góc trên bên trái
//         protected int iChieudai;
//         protected int iChieurong;
//         public virtual void Ve()
//         {
//             Console.WriteLine("Ve duong vien khung hinh");
//             Console.WriteLine();
//         }
//     }
//     public class DoanThang : Hinh
//     {
//         public override void Ve()
//         {
//             Console.WriteLine("Ve Doan thang");
//             base.Ve();
//         }
//     }
//     public class HinhChuNhat : Hinh
//     {
//         public override void Ve()
//         {
//             Console.WriteLine("Ve hinh chu nhat");
//             base.Ve();
//         }
//     }
//     public class HinhTron : Hinh
//     {
//         public override void Ve()
//         {
//             Console.WriteLine("Ve hinh tron");
//             base.Ve();
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Please, run in debugging mode 5 times
//             DoanThang h1 = new DoanThang();
//             HinhChuNhat h2 = new HinhChuNhat();
//             HinhTron h3 = new HinhTron();
//             List<Hinh> lHinh = new List<Hinh>();
//             lHinh.Add(h1);
//             lHinh.Add(h2);
//             lHinh.Add(h3);
//             foreach (Hinh h in lHinh)
//             {
//                 h.Ve();
//             }
//         }
//     }
// }
