using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // nhap n
            int n;
            do
            {
                Console.Write($"\nNhap so phan tu cho mang (2 < n < 20) : ");
                n = Int32.Parse(Console.ReadLine());
                if (n <= 2 || n >= 20) Console.Write($"\nNhap lai (2 < n < 20) : ");
            } while (n <= 2 || n >= 20);
            int[] arr = new int[n];

            // nhap el cho arr
            Console.WriteLine($"\nNhap gia tri cho mang ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu {i} : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            // in cac el le > 7
            Console.Write($"\nCac so le > 7 trong mang : ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 7 && arr[i] % 2 == 1)
                {
                    Console.Write($"{arr[i]} , ");
                }
            }

            // dem el chan
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    dem += 1;
                }
            }
            Console.WriteLine($"\n\nCo {dem} so chan trong mang");

            // tong el 
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
            }
            Console.WriteLine($"\nTong cac so trong day la : {tong}");

            // tim el chan max
            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                    if (max < arr[i])
                        max = arr[i];
            }
            Console.WriteLine($"\nSo chan lon nhat trong mang : {max}");

            // in el tang dan
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int sub;
                        sub = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = sub;
                    }
                }
            }
            Console.Write("\nMang tang dan : { ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]}");
                if (i < n - 1) Console.Write(" , ");
            }
            Console.Write(" }\n\n\n");

        }

    }
}

