// // Ví dụ về các cấu trúc lệnh
// using System;
// using System.Collections.Generic; // Nạp thư viện để dùng danh sách (List)

// class Program
// {
//     static void Main()
//     {
//         int soBiMat = 7;
//         bool dangChoi = true;

//         // 1. DO...WHILE: Đảm bảo menu hiển thị ít nhất 1 lần
//         do 
//         {
//             Console.WriteLine("\n--- GAME DOAN SO ---");
//             Console.WriteLine("1. Choi game");
//             Console.WriteLine("0. Thoat");
//             Console.Write("Chon chuc nang: ");
            
//             int luaChon = Convert.ToInt32(Console.ReadLine());

//             // 2. SWITCH: Xử lý menu rẽ nhánh
//             switch (luaChon)
//             {
//                 case 1:
//                     Console.WriteLine("\nBan co 3 luot doan (tu 1 den 10).");
//                     bool chienThang = false;
//                     List<int> lichSuDoan = new List<int>(); // Tạo danh sách rỗng lưu lịch sử

//                     // 3. FOR: Giới hạn chính xác 3 lượt đoán
//                     for (int luot = 1; luot <= 3; luot++)
//                     {
//                         Console.Write($"Luot {luot} - Nhap so cua ban: ");
//                         int soDoan = Convert.ToInt32(Console.ReadLine());
//                         lichSuDoan.Add(soDoan); // Lưu số vừa đoán vào danh sách

//                         // 4. IF...ELSE: Kiểm tra đúng hay sai
//                         if (soDoan == soBiMat)
//                         {
//                             Console.WriteLine("Chuc mung! Ban da doan dung.");
//                             chienThang = true;
//                             // 5. BREAK: Thoát vòng FOR sớm vì đã thắng, không cần đoán lượt còn lại
//                             break; 
//                         }
//                         else
//                         {
//                             Console.WriteLine("Sai roi!");
//                         }
//                     }

//                     // 6. FOREACH: Duyệt lại danh sách để hiển thị các số đã nhập
//                     Console.Write("Lich su cac so ban da doan: ");
//                     foreach (int so in lichSuDoan)
//                     {
//                         Console.Write(so + " ");
//                     }
//                     Console.WriteLine();

//                     if (!chienThang) Console.WriteLine($"Ban da het luot. So bi mat la {soBiMat}.");
//                     break; // Thoát case 1

//                 case 0:
//                     dangChoi = false;
//                     Console.WriteLine("Tam biet!");
//                     break; // Thoát case 0

//                 default:
//                     Console.WriteLine("Lua chon sai, vui long nhap lai.");
//                     break; // Thoát case default
//             }
//         // 7. WHILE (Của Do-while): Kiểm tra điều kiện lặp lại game
//         } while (dangChoi); 
//     }
// }