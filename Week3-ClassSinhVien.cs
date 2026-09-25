// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace ClassDemo_week3
// {
//     public class SinhVien
//     {
//         // Các fields
//         private string sHoten;
//         private string sMSSV;
//         private double dDiemToan;
//         private double dDiemTin;
//         private double dDiemTB;

//         // Các properties
//         public string HoTen
//         {
//             get { return this.sHoten; }
//             set { this.sHoten = value; }
//         }

//         public string MSSV
//         {
//             get { return this.sMSSV; }
//             set { this.sMSSV = value; }
//         }

//         public double DiemToan
//         {
//             get { return this.dDiemToan; }
//             set
//             {
//                 if (value < 0 || value > 10)
//                     throw new ArgumentException($"{nameof(value)} must be between 0 and 10.");
//                 this.dDiemToan = value;
//             }
//         }

//         public double DiemTin
//         {
//             get { return this.dDiemTin; }
//             set
//             {
//                 if (value < 0 || value > 10)
//                     throw new ArgumentException($"{nameof(value)} must be between 0 and 10.");
//                 this.dDiemTin = value;
//             }
//         }

//         public double DiemTB
//         {
//             get { return this.dDiemTB; }
//         }
//         // Các constructors
//         // Không có tham số
//         public SinhVien()
//         {
//         }
//         // Có đủ tham số
//         public SinhVien(string hoTen, string msSV, double diemToan, double diemTin)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//             this.DiemToan = diemToan;
//             this.DiemTin = diemTin;
//         }
//         // Có một phần tham số
//         public SinhVien(string hoTen, string msSV)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//         }
//         public SinhVien(string hoTen)
//         {
//             this.HoTen = hoTen;
//         }
//         // Finalizer, destructors
//         ~SinhVien()
//         {

//         }
//         // Các method
//         // Hàm nhập
//         public void Nhap()
//         {
//             Console.WriteLine("Nhap ho ten: ");
//             this.HoTen = Console.ReadLine();
//             Console.WriteLine("Nhap mssv: ");
//             this.MSSV = Console.ReadLine();
//             Console.WriteLine("Nhap diem toan: ");
//             this.DiemToan = Convert.ToDouble(Console.ReadLine());
//             Console.WriteLine("Nhap diem tin: ");
//             this.DiemTin = Convert.ToDouble(Console.ReadLine());
//         }
//         public void Nhap(string hoTen, string msSV, double diemToan, double diemTin)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//             this.DiemToan = diemToan;
//             this.DiemTin = diemTin;
//         }
//         //Có một phần tham số
//         public void Nhap(string hoTen, string msSV)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//         }
//         public void Nhap(string hoTen)
//         {
//             this.HoTen = hoTen;
//         }
//         //Hàm xuất
//         public void Xuat()
//         {
//             Console.WriteLine("Ho ten: " + this.sHoten);
//             Console.WriteLine("MSSV: " + this.sMSSV);
//             Console.WriteLine("Diem toan: " + this.dDiemToan);
//             Console.WriteLine("Diem tin: " + this.DiemTin);
//             Console.WriteLine("Diem trung binh: " + this.dDiemTB);
//         }
//         //Hàm tính toán
//         public void TinhDiemTrungBinh()
//         {
//             this.dDiemTB = (this.dDiemToan + this.dDiemTin) / 2;
//         }

//         class Program
//         {
//             static void Main(string[] args)
//             {
//                 SinhVien sv = new SinhVien();
//                 sv.Nhap("Khanh Luan", "1234", 8.5, 9.9);
//                 sv.TinhDiemTrungBinh();
//                 sv.Xuat();
//                 Console.ReadKey();
//             }
//         }
//     }
// }
