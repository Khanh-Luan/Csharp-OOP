// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Chapter_5___Date
// {
//     public class Date
//     {
//         public int iDay{get; set;}
//         public int iMonth{get; set;}
//         public int iYear{get; set;}
//         public Date(){}
//         public Date(int day, int month,int year)
//         {
//             iDay = day;
//             iMonth = month;
//             iYear = year;
//         }
//         private long TinhGiaTri()
//         {
//             return iYear * 10000 + iMonth * 100 + iDay;
//         }
//         public static bool operator ==(Date a, Date b)
//         {
//             return a.TinhGiaTri() == b.TinhGiaTri();
//         }
//         public static bool operator !=(Date a, Date b)
//         {
//             return a.TinhGiaTri() != b.TinhGiaTri();
//         }
//         public static bool operator >(Date a, Date b)
//         {
//             return a.TinhGiaTri() > b .TinhGiaTri();
//         }
//         public static bool operator >=(Date a, Date b)
//         {
//             return a.TinhGiaTri() >= b.TinhGiaTri();
//         }
//         public static bool operator <(Date a, Date b)
//         {
//             return a.TinhGiaTri() < b.TinhGiaTri();
//         }
//         public static bool operator <=(Date a, Date b)
//         {
//             return a.TinhGiaTri() <= b.TinhGiaTri();
//         }
//         public static Date operator ++(Date a)
//         {
//             a.iDay = a.iDay + 1;
//             return a;
//         }
//         public static Date operator --(Date a)
//         {
//             a.iDay = a.iDay - 1;
//             return a;
//         }
//         public void Xuat()
//         {
//             Console.Write($"{iDay}/{iMonth}/{iYear}");
//         }
//     }
// class Program
//     {
//         public static void Main()
//         {
//             Date a = new Date(30,7,2007);
//             Date b = new Date(8,4,2007);
//             a++;
//             b++;
//             a--;
//             b--;
//             if (a > b)
//             {
//                 Console.WriteLine("a lon hon b");
//             }
//             else
//             {
//                 Console.WriteLine("a nho hon hoac bang b");
//             }
//             if (a == b)
//             {
//                 Console.WriteLine("a bang b");
//             }
//             else
//             {
//                 Console.WriteLine("a khong bang b");
//             }
//             a.Xuat();
//             b.Xuat();
//         }
//     }
// }