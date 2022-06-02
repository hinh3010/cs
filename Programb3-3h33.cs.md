using System;

namespace Main
{
    class bai
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // nhap n
            int n;
            do
            {
                Console.Write($"\nNhap so phan tu cho mang (3 < n < 30) : ");
                n = Int32.Parse(Console.ReadLine());
                if (n <= 3 || n >= 30) Console.Write($"\nNhap lai (3 < n < 30) : ");
            } while (n <= 3 || n >= 30);


            string[,] arr = new string[2, n];

            // nhap el cho arr
            Console.WriteLine($"\nNhap sinh vien ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    // if (j == 0)
                    // {
                    //     Console.Write($"Nhap STT cho sinh vien {i + 1}");
                    //     arr[j, i] = Console.ReadLine();
                    // }
                    if (j == 1)
                    {
                        Console.Write($"Nhap ten sinh vien co STT : {i + 1} : ");
                        arr[j, i] = Console.ReadLine();
                    }
                }
            }

            // in arr
            Console.WriteLine($"\nIn sinh vien ");
            Console.WriteLine($"STT        TEN");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 1)
                        Console.WriteLine($"{i + 1}         {arr[j, i]}");
                    // arr[j, i] = Console.ReadLine();
                }
            }

            // tim 'Anh' trong mang
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (arr[j, i] == "Anh") dem += 1;
                }
            }
            Console.WriteLine($"\nCo {dem} sinh vien co ten la 'Anh' \n\n");

        }

    }
}

