using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            Nhập từ bàn phím dãy số nguyên dương bất kì có n số (2<=n<=10) 
            in ra số chẵn >= 42000
            Tính g/trị tb cộng 
            Tìm số nguyên tố
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

            int[] arr = new int[n];

            // nhap el cho arr
            Console.WriteLine($"\nNhap gia tri cho mang ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu {i} : ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            // in ra số chẵn >= 4
            Console.Write($"\nCac so chan >= 4 trong mang : ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 4 && arr[i] % 2 == 0)
                {
                    Console.Write($"{arr[i]} , ");
                }
            }

            // Tinh tb cong
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
            }
            Console.WriteLine($"\nGia tri TB Cong cua mang : {(float)tong / n}");

            // tim so ng/to
            bool isNguyenTo(int param)
            {
                if (param < 2)
                    return false;
                for (int i = 2; i <= Math.Sqrt(param); i++)
                {
                    if (param % i == 0)
                        return false;
                }
                return true;
            }
            Console.Write($"Cac so nguyen to trong mang la : ");
            for (int i = 0; i < n; i++)
            {
                if (isNguyenTo(arr[i]))
                {
                    Console.Write($"{arr[i]} , ");
                }
            }
        }

    }
}

