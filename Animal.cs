// using System;
// using System.Reflection.PortableExecutable;
// using System.Security.Cryptography.X509Certificates;
// // 'using System' cho phép dùng các lớp trong namespace System, 
// // ví dụ như Console để in ra màn hình.

// class Dog
// {
//     // Đây là các field (trường dữ liệu) của lớp Animal.
//     // Chúng lưu trữ thông tin về chiều cao và cân nặng.
//     public double Weight;
//     public double Height;

//     public virtual void Input()
//     {
//         Weight = Convert.ToDouble(Console.ReadLine());
//         Height = Convert.ToDouble(Console.ReadLine());
//     }
//     // Phương thức Info() có nhiệm vụ in ra thông tin của đối tượng Animal.
//     public virtual void Info()
//     {
//         // Console.WriteLine in ra màn hình console.
//         // Dùng chuỗi $"..." để chèn giá trị Height và Weight vào trong chuỗi.
//         Console.WriteLine($"Height: {Height}, Weight: {Weight}");
//     }
// }

// class Tu : Dog
// {
//     public override void Input()
//     {
//         Console.WriteLine("===== Input =====");
//         base.Input();
//     }
//     public override void Info()
//     {
//         Console.WriteLine("===== Infor =====");
//         base.Info();
//         Console.WriteLine("GoGoGo!");
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         Tu tu = new Tu();
//         tu.Input();
//         tu.Info();
//     }
// }