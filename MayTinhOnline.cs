// using System; // Nạp thư viện hệ thống cơ bản để dùng các lệnh nhập/xuất như Console

// namespace CalculatorEnum
// {
//     // Định nghĩa Enum (danh sách hằng số) cho các phép toán giúp code dễ hiểu hơn
//     // Thay vì phải nhớ số 1 là cộng, số 2 là trừ... ta dùng tên Cong, Tru...
//     enum PhepToan
//     {
//         Cong = 1,
//         Tru = 2,
//         Nhan = 3,
//         Chia = 4,
//         ChiaDu = 5
//     }

//     class Program
//     {
//         // Hàm Main là điểm bắt đầu (entry point) của mọi chương trình C# Console
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap so thu nhat: ");
//             // Lệnh Console.ReadLine() đọc dữ liệu dưới dạng chuỗi (text).
//             // Convert.ToDouble() ép chuỗi đó thành kiểu số thực để có thể làm toán.
//             double a = Convert.ToDouble(Console.ReadLine());

//             Console.Write("Nhap so thu hai: ");
//             double b = Convert.ToDouble(Console.ReadLine());

//             // In ra menu hướng dẫn cho người dùng
//             Console.WriteLine("\nChon phep toan:");
//             Console.WriteLine("1. Cong (+)");
//             Console.WriteLine("2. Tru (-)");
//             Console.WriteLine("3. Nhan (*)");
//             Console.WriteLine("4. Chia (/)");
//             Console.WriteLine("5. Chia lay phan du (%)");
//             Console.Write("Nhap lua chon cua ban (1-5): ");
            
//             // Đọc số người dùng nhập và ép kiểu sang số nguyên (int)
//             int chon = Convert.ToInt32(Console.ReadLine());
            
//             // Ép kiểu số nguyên vừa nhập sang kiểu Enum 'PhepToan' tương ứng
//             PhepToan phepToan = (PhepToan)chon;

//             Console.WriteLine(); // In ra một dòng trống cho giao diện thoáng hơn

//             // Lệnh switch rẽ nhánh: so sánh biến 'phepToan' xem khớp với trường hợp (case) nào
//             switch (phepToan)
//             {
//                 case PhepToan.Cong:
//                     // Dấu $ ở trước chuỗi giúp nhúng trực tiếp biến {a}, {b} vào câu văn (String Interpolation)
//                     Console.WriteLine($"Ket qua: {a} + {b} = {a + b}");
//                     break; // Lệnh break để dừng và thoát khỏi khối switch ngay lập tức
                
//                 case PhepToan.Tru:
//                     Console.WriteLine($"Ket qua: {a} - {b} = {a - b}");
//                     break;
                
//                 case PhepToan.Nhan:
//                     Console.WriteLine($"Ket qua: {a} * {b} = {a * b}");
//                     break;
                
//                 case PhepToan.Chia:
//                     // Câu lệnh if/else kiểm tra điều kiện b khác 0 để tránh lỗi toán học
//                     if (b != 0)
//                         Console.WriteLine($"Ket qua: {a} / {b} = {a / b}");
//                     else
//                         Console.WriteLine("Loi: Khong the chia cho 0!");
//                     break;
                
//                 case PhepToan.ChiaDu:
//                     if (b != 0)
//                         Console.WriteLine($"Ket qua: {a} % {b} = {a % b}");
//                     else
//                         Console.WriteLine("Loi: Khong the chia cho 0!");
//                     break;
                
//                 default:
//                     // Khối default sẽ chạy nếu người dùng nhập số không có trong danh sách (ví dụ: 6, 7)
//                     Console.WriteLine("Loi: Lua chon khong hop le!");
//                     break;
//             }
            
//             // Dừng chương trình chờ người dùng nhấn Enter, giúp cửa sổ không bị tắt ngay lập tức để kịp đọc kết quả
//             Console.ReadLine();
//         }
//     }
// }