// using System;
// class DangNhap
// {
//     private string sUsername;
//     private string sPassword;
//     public static int iSoLanTruyCap = 5;

//     public string Username
//     {
//         get { return this.sUsername; }
//         set { this.sUsername = value; }
//     }
//     public string Password
//     {
//         get { return this.sPassword; }
//         set { this.sPassword = value; }
//     }
//     public DangNhap(string username, string password)
//     {
//         this.sUsername = username;
//         this.sPassword = password;
//     }
//     ~DangNhap() { }

//     public virtual void Signin()
//     {
//         this.sUsername = Console.ReadLine();
//         this.sPassword = Console.ReadLine();
//     }
// }

// class Program
// {
//     public static void Main()
//     {
//         string a;
//         string b;
//         DangNhap tk = new DangNhap("tkl", "123");
//         Console.WriteLine("=== Dang nhap ===");
//         a = Console.ReadLine();
//         b = Console.ReadLine();
//         if (a == tk.Username && b == tk.Password)
//         {
//             Console.WriteLine("Dang nhap thanh cong");
//         }
//         else
//         {
//             do
//             {
//                 Console.WriteLine("___ Try again ___");
//                 a = Console.ReadLine();
//                 b = Console.ReadLine();
//                 DangNhap.iSoLanTruyCap--;
//                 if (DangNhap.iSoLanTruyCap == 0)
//                 {
//                     Console.WriteLine("____ Dang nhap that bai ____");
//                     break;
//                 }
//             } while (a != tk.Username || b != tk.Password);
//         }
//     }
// }