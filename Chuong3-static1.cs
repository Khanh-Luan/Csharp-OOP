// // Thành viên tĩnh trong lớp 
// using System;
// class SanPham
// {
//     public static double dThueVAT = 0.1;
//     public string sTenSP { get; set; }
//     public double dGiaSP { get; set; }

//     public SanPham(string tenSP, double giaSP)
//     {
//         this.sTenSP = tenSP;
//         this.dGiaSP = giaSP;
//     }

//     public double TinhGiaSauThue()
//     {
//         return this.dGiaSP * (1 + SanPham.dThueVAT);
//     }

//     // Hàm tĩnh
//     public static bool CapNhatThueVAT(double thueVATMoi)
//     {
//         if (thueVATMoi < 0 || thueVATMoi > 1)
//             return false; //Giá trị không hợp lệ

//         SanPham.dThueVAT = thueVATMoi;
//         return true;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         SanPham mt = new SanPham("Máy tính DELL", 12000);
//         SanPham dt = new SanPham("Điện thoại SAMSUNG", 20000);

//         Console.WriteLine("Giá máy tính sau thuế: " + mt.TinhGiaSauThue().ToString());
//         Console.WriteLine("Giá điện thoại sau thuế: " + dt.TinhGiaSauThue().ToString());

//         SanPham.CapNhatThueVAT(0.15); // tăng thuế VAT

//         Console.WriteLine("\nSau khi cập nhật thuế VAT:");
//         Console.WriteLine("Giá máy tính DELL sau thuế: " + mt.TinhGiaSauThue().ToString());
//         Console.WriteLine("Giá điện thoại SAMSUNG sau thuế: " + dt.TinhGiaSauThue().ToString());

//         //Xem thông tin thuế VAT
//         Console.WriteLine("\nThuế VAT hiện tại là: " + SanPham.dThueVAT);
//     }
// }
