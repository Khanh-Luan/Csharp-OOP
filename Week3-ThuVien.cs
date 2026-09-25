// using System;

// namespace ClassDemo_week3
// {
//     // =====================================================
//     // CLASS THUVIEN
//     // =====================================================
//     public class ThuVien
//     {
//         // =====================================================
//         // 1. FIELDS
//         // =====================================================

//         private string sHoTen = "";
//         private string sMSSV = "";
//         private int iSoLuongSachMuon;
//         private string sTraSach = "";


//         // =====================================================
//         // 2. PROPERTIES
//         // =====================================================

//         public string HoTen
//         {
//             get { return this.sHoTen; }
//             set { this.sHoTen = value; }
//         }

//         public string MSSV
//         {
//             get { return this.sMSSV; }
//             set { this.sMSSV = value; }
//         }

//         public int SoLuongSachMuon
//         {
//             get { return this.iSoLuongSachMuon; }

//             set
//             {
//                 // Số lượng sách phải từ 0 đến 5
//                 if (value < 0 || value > 5)
//                 {
//                     throw new ArgumentOutOfRangeException(
//                         nameof(value),
//                         "Số lượng sách mượn phải từ 0 đến 5."
//                     );
//                 }

//                 this.iSoLuongSachMuon = value;
//             }
//         }

//         public string TraSachHayChua
//         {
//             get { return this.sTraSach; }
//             set { this.sTraSach = value; }
//         }


//         // =====================================================
//         // 3. CONSTRUCTORS
//         // =====================================================

//         // Constructor không tham số
//         public ThuVien()
//         {
//         }

//         // Constructor có 1 tham số
//         public ThuVien(string hoTen)
//         {
//             this.HoTen = hoTen;
//         }

//         // Constructor có 2 tham số
//         public ThuVien(string hoTen, string msSV)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//         }

//         // Constructor đầy đủ tham số
//         public ThuVien(
//             string hoTen,
//             string msSV,
//             int soLuongSachMuon,
//             string traSach)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//             this.SoLuongSachMuon = soLuongSachMuon;
//             this.TraSachHayChua = traSach;
//         }


//         // =====================================================
//         // 4. DESTRUCTOR / FINALIZER
//         // =====================================================

//         ~ThuVien()
//         {
//             // Destructor được Garbage Collector gọi
//             // khi Object được thu hồi khỏi bộ nhớ.
//         }


//         // =====================================================
//         // 5. METHOD NHẬP
//         // =====================================================

//         // Nhập thông tin từ bàn phím
//         public void Nhap()
//         {
//             Console.Write("Nhập họ tên: ");
//             this.HoTen = Console.ReadLine() ?? "";

//             Console.Write("Nhập MSSV: ");
//             this.MSSV = Console.ReadLine() ?? "";

//             Console.Write("Nhập số lượng sách mượn: ");
//             this.SoLuongSachMuon =
//                 Convert.ToInt32(Console.ReadLine());

//             Console.Write("Đã trả sách hay chưa (Co/Khong): ");
//             this.TraSachHayChua = Console.ReadLine() ?? "";
//         }


//         // =====================================================
//         // METHOD NHẬP - OVERLOADING
//         // =====================================================

//         // Nhập đầy đủ thông tin bằng tham số
//         public void Nhap(
//             string hoTen,
//             string msSV,
//             int soLuongSachMuon,
//             string traSach)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//             this.SoLuongSachMuon = soLuongSachMuon;
//             this.TraSachHayChua = traSach;
//         }

//         // Nhập 2 thông tin
//         public void Nhap(string hoTen, string msSV)
//         {
//             this.HoTen = hoTen;
//             this.MSSV = msSV;
//         }

//         // Nhập 1 thông tin
//         public void Nhap(string hoTen)
//         {
//             this.HoTen = hoTen;
//         }


//         // =====================================================
//         // 6. METHOD XUẤT
//         // =====================================================

//         public void Xuat()
//         {
//             Console.WriteLine("Họ tên: " + this.HoTen);
//             Console.WriteLine("MSSV: " + this.MSSV);
//             Console.WriteLine(
//                 "Số lượng sách mượn: "
//                 + this.SoLuongSachMuon
//             );
//             Console.WriteLine(
//                 "Đã trả sách hay chưa: "
//                 + this.TraSachHayChua
//             );
//         }
//     }


//     // =====================================================
//     // CLASS PROGRAM
//     // =====================================================

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // =================================================
//             // TẠO OBJECT
//             // =================================================

//             ThuVien tv1 = new ThuVien();


//             // =================================================
//             // GỌI METHOD NHẬP
//             // =================================================

//             tv1.Nhap();


//             // =================================================
//             // GỌI METHOD XUẤT
//             // =================================================

//             Console.WriteLine("\n===== THÔNG TIN =====");

//             tv1.Xuat();


//             // =================================================
//             // DỪNG MÀN HÌNH
//             // =================================================

//             Console.ReadKey();
//         }
//     }
// }