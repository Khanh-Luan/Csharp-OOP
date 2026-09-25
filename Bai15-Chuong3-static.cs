// // Viết chương trình gồm các lớp: Lớp Cấu hình hệ thống . 
// // Sử dụng các biến tĩnh và phương thức tĩnh để lưu trữ và hiển thị các thông tin chung như: 
// // TenPhanMem, PhienBan, NamPhatHanh
// using System;
// class CauHinhHeThong
// {
//     // fields
//     public string sTenPhanMem;
//     public string sPhienBan;
//     public static double dNamPhatHanh = 2018;
//     // properties
//     public string TenPhanMem
//     {
//         get { return this.sTenPhanMem; }
//         set { this.sTenPhanMem = value; }
//     }
//     public string PhienBan
//     {
//         get { return this.sPhienBan; }
//         set { this.sPhienBan = value; }
//     }
//     public CauHinhHeThong(string tenPhanMem, string phienBan)
//     {
//         this.sTenPhanMem = tenPhanMem;
//         this.sPhienBan = phienBan;
//     }

//     public void Input()
//     {
//         Console.WriteLine($"Ten Phan Mem: {this.sTenPhanMem}");
//         Console.WriteLine($"Phien Ban: {this.sPhienBan}");
//     }
//     public static void Main()
//     {
//         CauHinhHeThong word = new CauHinhHeThong("Word", "12.1");
//         Console.WriteLine("===== Cau Hinh He Thong =====");
//         word.Input();
//         Console.WriteLine($"Nam Phat Hanh: {CauHinhHeThong.dNamPhatHanh}");
//     }
// }