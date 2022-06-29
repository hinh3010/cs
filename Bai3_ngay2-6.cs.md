using System.Text;
using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            Nhập từ ma trận vuông co kích thuoc nxn (2<n<20) chua cac so 0 1
            dem so lượng số 1 theo từng dòng
            Kiểm tra tính đối xứng của ma trận
            */
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n\nHọ tên   :   Trần Văn Hinh");
            Console.WriteLine("Ngày sinh    :   30/10/1999");
            Console.WriteLine("Mã sinh viên :   521210288");
            Console.WriteLine("Lớp học      :   CNTT");
            Console.WriteLine("Môn học      :   Kiểm tra lập trình hướng đối tượng c#");
            Console.WriteLine("Bài test     :   1\n\n");


            // nhap so p/tu
            int n;
            do
            {
                Console.Write($"\nNhap so phan tu cho mang : ");
                n = Int32.Parse(Console.ReadLine());
                if (n <= 2 || n >= 20) Console.Write($"\nNhap lai ... ");
            } while (n <= 2 || n >= 20);

            int[,] arr = new int[n, n];

            // nhap el cho arr
            Console.WriteLine($"\nNhap gia tri cho mang ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    do
                    {
                        Console.Write($"Gia tri [dong {i} cot {j}] : ");
                        arr[i, j] = Int32.Parse(Console.ReadLine());
                        if (arr[i, j] != 0 && arr[i, j] != 1) Console.Write($"Nhap lai : ");
                    } while (arr[i, j] != 0 && arr[i, j] != 1);
                }
            }

            // in ra arr
            Console.WriteLine($"\nIn gia tri cho mang ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]}     ");
                }
                Console.Write($"\n\n");
            }

            // dem so 1 theo tung dong
            for (int i = 0; i < n; i++)
            {
                int dem = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == 1) dem += 1;
                }
                Console.WriteLine($"Dong {i} co {dem} so 1 ");
            }

            // Kiem tra tính doi xung cua ma trận
            bool dx()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (arr[i, j] != arr[j, i])
                            return false;
                    }
                }
                return true;
            }

            if (dx()) Console.WriteLine($"Ma tran doi xung");
            else Console.WriteLine($"Ma tran khong doi xung");

            Console.WriteLine($"\n\n");
        }

    }
}

