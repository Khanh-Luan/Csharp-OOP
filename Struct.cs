// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Chapter6_Othertechnologies
// {
//     struct Point
//     {
//         public int x, y;
//         public Point(int x, int y)
//         {
//             this.x = x;
//             this.y = y;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Point p1 = new Point(4, 5);
//             Console.WriteLine("p1=" + p1.x + ", " + p1.y);
//             Point p2 = p1;
//             p2.x = 40;
//             p2.y = 50;
//             Console.WriteLine("p1=" + p1.x + ", " + p1.y);//giá trị p1 không bị thay đổi
            
//              Console.WriteLine("p2=" + p2.x + ", " + p2.y);
//             Point p3;//không cần dùng từ khóa new
//             p3.x = 12;
//             p3.y = 21;
//             Console.WriteLine("p3=" + p3.x + ", " + p3.y);
//         }
//     }
// }