// using System;

// class SoNguyen
// {
//     public static void Main()
//     {
//         Console.WriteLine("===== Tao Mang =====");
//         Console.Write("Nhap n: ");
//         int n = int.Parse(Console.ReadLine());
//         int[] a = new int[n];
//         Console.WriteLine("Nhap cac phan tu: ");
//         for(int i = 0; i < n; i++)
//         {
//             Console.Write($"a[{i}] = ");
//             a[i] = int.Parse(Console.ReadLine());
//         }
//         Console.WriteLine("Mang sau khi nhap: ");
//         foreach (int num in a)
//         {
//             Console.Write($"{num} ");
//         }

//         Console.WriteLine("\n===== Tim phan tu lon nhat, phan tu nho nhat =====");
//         int max = a[0];
//         int min = a[0];
//         for (int i = 0; i < n; i++)
//         {
//             if (max < a[i]) max = a[i];
//             if (min > a[i]) min = a[i];
//         }
//         Console.WriteLine($"Phan tu lon nhat la {max}");
//         Console.WriteLine($"Phan tu nho nhat la {min}");
//     }
// }

