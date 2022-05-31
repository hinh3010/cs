using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int a, b, c; float x;
            Console.Write("Nhap a : ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap c : ");
            c = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap x : ");
            x = float.Parse(Console.ReadLine());


            float s = (float)(a + b + c) / 3;
            Console.WriteLine($"Trung binh cong cua {a} {b} {c} la : {s}");

            float t = a * x * x + b * x * x * x + c * x;
            Console.WriteLine($"T : {t}");
        }
    }

}

