// // Lớp tĩnh
// static class ToanHoc
// {
//     // Khai báo hằng số PI
//     public static readonly double PI = 3.141592653589793;

//     // Hàm tìm giá trị lớn nhất trong một dãy số
//     public static int Max(int[] arr)
//     {
//         if (arr == null || arr.Length == 0)
//             throw new ArgumentException("Dãy số không được rỗng");

//         int max = arr[0];
//         for (int i = 1; i < arr.Length; i++)
//         {
//             if (arr[i] > max)
//                 max = arr[i];
//         }
//         return max;
//     }

//     // Hàm tính trị tuyệt đối
//     public static int Abs(int x)
//     {
//         return x < 0 ? -x : x;
//     }
//     // Hàm tính diện tích hình tròn
//     public static double DienTichHinhTron(double bankinh)
//     {
//         if (bankinh < 0)
//             throw new ArgumentException("Bán kính phải không âm");

//         return PI * bankinh * bankinh;
//     }
// }
// internal class Program
// {
//     static void Main(string[] args)
//     {
//         int[] dayso = { -3, 5, 2, 10, -7 };
//         Console.WriteLine(ToanHoc.Max(dayso));
//         Console.WriteLine(ToanHoc.Abs(-25));
//         Console.WriteLine(ToanHoc.DienTichHinhTron(20));
//     }
// }
