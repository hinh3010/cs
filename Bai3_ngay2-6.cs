using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            Nhập từ ma trận vuông co kích thuoc nxn (2<n<20) chua cac so 0 /1
            dem so lượng số 1 theo từng dòng
            Kiểm tra tính đối xứng của ma trận
            */
            Console.WriteLine("\n\nHo ten       :   Tran Van Hinh");
            Console.WriteLine("Ngay sinh    :   30/10/1999");
            Console.WriteLine("Ma sinh vien :   *******");
            Console.WriteLine("Lop hoc      :   CNTT");
            Console.WriteLine("Mon hoc      :   Kiem tra lap trinh huuong doi tuong c#");


            // nhap so p/tu
            int n;
            do
            {
                Console.Write($"\nNhap so phan tu cho mang : ");
                n = Int32.Parse(Console.ReadLine());
                if (n < 2 || n > 10) Console.Write($"\nNhap lai ... ");
            } while (n <= 2 || n > 10);

            int[,] arr = new int[n, n];

            // nhap el cho arr
            Console.WriteLine($"\nNhap gia tri cho mang ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    do
                    {
                        Console.Write($"Gia tri cot {i} hang {j} : ");
                        arr[i, j] = Int32.Parse(Console.ReadLine());
                        if (arr[i, j] != 0 || arr[i, j] != 1) Console.Write($"Nhap lai : ");
                    } while (arr[i, j] != 0 || arr[i, j] != 1);
                }
            }


        }

    }
}

