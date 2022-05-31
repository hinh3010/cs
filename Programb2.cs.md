using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int luaChon;
            do
            {
                Console.Write("\n\nNhap bai muon lam : ");
                luaChon = Int32.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        int a, b, c, d;
                        Console.Write("Nhap a : ");
                        a = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap b : ");
                        b = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap c : ");
                        c = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap d : ");
                        d = Int32.Parse(Console.ReadLine());

                        // tim so max min
                        int max = a;
                        if (max < b) max = b;
                        if (max < c) max = c;
                        if (max < d) max = d;
                        Console.WriteLine($"So lon nhat la : {max}");

                        int min = a;
                        if (min > b) min = b;
                        if (min > c) min = c;
                        if (min > d) min = d;
                        Console.WriteLine($"So lon nhat la : {min}");


                        // tính giá trị trung bình
                        float s = (float)(a + b + c + d) / 4;
                        Console.WriteLine($"Trung binh cong cua {a} {b} {c} {d} la : {s}");
                        break;

                    case 2:
                        float af, bf;
                        Console.Write("Nhap a : ");
                        af = float.Parse(Console.ReadLine());
                        Console.Write("Nhap b : ");
                        bf = float.Parse(Console.ReadLine());

                        // tinh ax+b = 0
                        if (af == 0)
                        {
                            if (bf == 0)
                                Console.WriteLine($"Phuong trinh co vo so nghiem");
                            else Console.WriteLine($"Phuong trinh co 1 nghiem = -{bf}");
                        }
                        else if (af != 0)
                        {
                            if (bf == 0)
                                Console.WriteLine($"Phuong trinh co nghiem x = 0");
                            else Console.WriteLine($"Phuong trinh co 1 nghiem = {-bf / af}");
                        }
                        break;
                    case 3:
                        float a3, b3, c3;
                        Console.Write("Nhap a : ");
                        a3 = float.Parse(Console.ReadLine());
                        Console.Write("Nhap b : ");
                        b3 = float.Parse(Console.ReadLine());
                        Console.Write("Nhap c : ");
                        c3 = float.Parse(Console.ReadLine());

                        // tinh ax+b = 0
                        if (a3 == 0)
                        {
                            if (b3 == 0)
                            {
                                if (c3 == 0)
                                    Console.WriteLine($"Phuong trinh co vo so nghiem");
                                else Console.WriteLine($"Phuong trinh vo nghiem");
                            }
                            else
                            {
                                if (c3 == 0)
                                    Console.WriteLine($"Phuong trinh mot nghiem x = 0");
                                else Console.WriteLine($"Phuong trinh co nghiem {-c3 / b3}");
                            }
                        }
                        else if (a3 != 0)
                        {
                            float delta = b3 * b3 - 4 * a3 * c3;
                            if (delta < 0)
                            {
                                Console.WriteLine($"Phuong trinh vo nghiem");
                            }
                            else if (delta == 0)
                            {
                                Console.WriteLine($"Phuong trinh mot nghiem x = {-b3 / (2 * a3)}");
                            }
                            else
                            {
                                Console.WriteLine($"Phuong trinh co hai nghiem ");
                                Console.WriteLine($"x1 = {(float)(-b3 + Math.Sqrt(delta)) / (2 * a3)} ");
                                Console.WriteLine($"x2 = {(float)(-b3 - Math.Sqrt(delta)) / (2 * a3)} ");
                            }
                        }
                        break;
                    case 4:
                        int n;
                        Console.Write("Nhap n : ");
                        n = Int32.Parse(Console.ReadLine());

                        // in ra so le < n
                        Console.WriteLine($"Cac so le < n la :");
                        for (int i = 1; i < n; i++)
                        {
                            if (i % 2 != 0) Console.Write($"{i} , ");
                        }

                        // dem so chan < n
                        int dem = 0;
                        for (int i = 1; i < n; i++)
                        {
                            if (i % 2 == 0) dem += 1;
                        }
                        Console.WriteLine($"Co {dem} so chan < n");

                        // hàm kiểm tra số nguyên tố
                        int NguyenToMax = 2;
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
                        for (int i = n - 1; i <= 2; i--)
                        {
                            if (isNguyenTo(i) == true) break;
                        }
                        Console.WriteLine($"So nguyen to lon nhat < n : {NguyenToMax}");
                        break;
                    case 0 : break;
                    default:
                        Console.WriteLine("Bai ban vua chon khong ton tai");
                        break;
                }

            } while (luaChon != 0);
            Console.WriteLine("Thoat");
        }
    }

}

