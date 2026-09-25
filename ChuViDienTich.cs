// using System;

// namespace TinhChuViDienTich
// {
//     class Program
//     {
//         // ENTRY POINT: Cửa chính của chương trình
//         static void Main(string[] args)
//         {
//             bool dangChay = true;

//             while (dangChay)
//             {
//                 Console.WriteLine("\n=== CHUONG TRINH TINH CHU VI & DIEN TICH ===");
//                 Console.WriteLine("1. Duong tron");
//                 Console.WriteLine("2. Hinh chu nhat");
//                 Console.WriteLine("3. Hinh thang");
//                 Console.WriteLine("4. Tam giac");
//                 Console.WriteLine("0. Thoat");
                
//                 int luaChon = Convert.ToInt32(NhapSo("Moi ban chon hinh can tinh (0-4): "));
//                 Console.WriteLine("--------------------------------------------");

//                 switch (luaChon)
//                 {
//                     case 1: TinhDuongTron(); break;
//                     case 2: TinhHinhChuNhat(); break;
//                     case 3: TinhHinhThang(); break;
//                     case 4: TinhTamGiac(); break;
//                     case 0: 
//                         dangChay = false; 
//                         Console.WriteLine("Tam biet!"); 
//                         break;
//                     default: 
//                         Console.WriteLine("Loi: Lua chon khong hop le!"); 
//                         break;
//                 }
//             }
//         }

//         // ==========================================
//         // CÁC HÀM XỬ LÝ TOÁN HỌC
//         // ==========================================

//         static void TinhDuongTron()
//         {
//             double r = NhapSo("Nhap ban kinh (r): ");
            
//             double chuVi = 2 * Math.PI * r;
//             double dienTich = Math.PI * r * r;

//             InKetQua("Duong tron", chuVi, dienTich);
//         }

//         static void TinhHinhChuNhat()
//         {
//             double dai = NhapSo("Nhap chieu dai: ");
//             double rong = NhapSo("Nhap chieu rong: ");

//             double chuVi = 2 * (dai + rong);
//             double dienTich = dai * rong;

//             InKetQua("Hinh chu nhat", chuVi, dienTich);
//         }

//         static void TinhHinhThang()
//         {
//             double dayLon = NhapSo("Nhap day lon: ");
//             double dayNho = NhapSo("Nhap day nho: ");
//             double canhBen1 = NhapSo("Nhap canh ben thu 1: ");
//             double canhBen2 = NhapSo("Nhap canh ben thu 2: ");
//             double chieuCao = NhapSo("Nhap chieu cao: ");

//             double chuVi = dayLon + dayNho + canhBen1 + canhBen2;
//             double dienTich = ((dayLon + dayNho) * chieuCao) / 2;

//             InKetQua("Hinh thang", chuVi, dienTich);
//         }

//         static void TinhTamGiac()
//         {
//             double a = NhapSo("Nhap canh a: ");
//             double b = NhapSo("Nhap canh b: ");
//             double c = NhapSo("Nhap canh c: ");

//             // Kiểm tra điều kiện tạo thành tam giác (Tổng 2 cạnh luôn lớn hơn cạnh còn lại)
//             if (a + b > c && a + c > b && b + c > a)
//             {
//                 double chuVi = a + b + c;
//                 double p = chuVi / 2; // Nửa chu vi
                
//                 // Tính diện tích bằng công thức Heron
//                 double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

//                 InKetQua("Tam giac", chuVi, dienTich);
//             }
//             else
//             {
//                 Console.WriteLine("Loi: Ba canh vua nhap khong tao thanh mot tam giac hop le!");
//             }
//         }

//         // ==========================================
//         // CÁC HÀM HỖ TRỢ (HELPER FUNCTIONS)
//         // ==========================================

//         // Hàm này giúp gom gọn lệnh in câu hỏi và đọc dữ liệu, tránh lặp code (DRY)
//         static double NhapSo(string thongBao)
//         {
//             Console.Write(thongBao); // In lời nhắc đang được truyền vào
//             return Convert.ToDouble(Console.ReadLine()); // Chờ người dùng nhập số
//         }

//         // Hàm này giúp in kết quả theo một format chuẩn nhất quán
//         static void InKetQua(string tenHinh, double chuVi, double dienTich)
//         {
//             // Math.Round(value, 2) giúp làm tròn số thập phân đến 2 chữ số
//             Console.WriteLine($"\n=> Chu vi {tenHinh}: {Math.Round(chuVi, 2)}");
//             Console.WriteLine($"=> Dien tich {tenHinh}: {Math.Round(dienTich, 2)}\n");
//         }
//     }
// }