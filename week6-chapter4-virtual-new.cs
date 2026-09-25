// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// namespace Test_Inheritance1
// {
//     public class ThietBi
//     {
//         protected string sMaTB;
//         protected string sTenTB;
//         public ThietBi()
//         { }
//         public ThietBi(string maTB, string tenTB)
//         {
//             this.sMaTB = maTB;
//             this.sTenTB = tenTB;
//         }
//         public virtual void Nhap()
//         {
//             Console.WriteLine("Nhap ma thiet bi");
//             this.sMaTB = Console.ReadLine();
//             Console.WriteLine("Nhap ma thiet bi");
//             this.sTenTB = Console.ReadLine();
//         }
//         public void Nhap(string maTB, string tenTB)
//         {
//             this.sMaTB = maTB;
//             this.sTenTB = tenTB;
//         }
//         public virtual void Xuat()
//         {
//             Console.Write(this.sMaTB + ", " + this.sTenTB);
//         }
//         public void Xuat2()
//         {
//             Console.WriteLine("Thong tin thiet bi:");
//             Console.WriteLine("Ma thiet bi: " + this.sMaTB);
//             Console.WriteLine("Ten thiet bi: " + this.sTenTB);
//         }
//     }
//     public class DienThoai : ThietBi
//     {
//         double dungluongluutru;
//         public DienThoai() : base()
//         { }
//         public DienThoai(double dungluonglt, string matb, string tentb) : base(matb,
//         tentb)
//         {
//             this.dungluongluutru = dungluonglt;
//         }
//         public override void Nhap()
//         {
//             base.Nhap();
//             Console.WriteLine("Nhap ma thiet bi");
//             this.dungluongluutru = Convert.ToDouble(Console.ReadLine());
//         }
//         public void Nhap(double dungluonglt, string matb, string tentb)
//         {
//             base.Nhap(matb, tentb);
//             this.dungluongluutru = dungluonglt;
//         }
//         public override void Xuat()
//         {
//             base.Xuat();
//             Console.WriteLine();
//             Console.WriteLine(this.dungluongluutru);
//         }
//         public new void Xuat2()
//         {
//             base.Xuat2();
//             Console.WriteLine("Dung luong: " + this.dungluongluutru);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Hãy thử nhiều cách khởi tạo/nhập/xuất dưới đây
//             //Chạy DEBUG 3 lần mỗi cách để xem hàm nào được gọi
//             //Cách 1
//             // ThietBi tb = new ThietBi("2", "Nokia");
//             // tb.Xuat();
//             // Console.WriteLine();
//             // DienThoai dt = new DienThoai(10, "1", "iphone");
//             // dt.Xuat();
//             //Cách 2
//             DienThoai dt = new DienThoai();
//             dt.Nhap(10, "1", "iphone");
//             dt.Xuat();
//             //Cách 3
//             // DienThoai dt = new DienThoai();
//             // dt.Nhap(10, "1", "iphone");
//             // dt.Xuat2();
//         }
//     }
// }