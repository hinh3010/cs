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
                Console.Write($"\nNhap so phan tu cho mang (1<n<100) : ");
                n = Int32.Parse(Console.ReadLine());
                if (n <= 1 || n >= 100) Console.Write($"\nNhap lai (1<n<100) : ");
            } while (n <= 1 || n >= 100);
            int[] arr = new int[n];

            // nhap el cho arr
            Console.WriteLine($"\nNhap gia tri cho mang ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu {i} : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            // in cac el % 2 
            Console.Write($"\nCac so chan trong mang : ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write($"{arr[i]} , ");
                }
            }

            // in el max
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"\n\nSo lon nhat trong mang : {max}");

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
            Console.Write(" }");

        }

    }
}

