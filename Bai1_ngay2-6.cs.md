using System;

namespace Main
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /*
            Nhập vào điểm toán lý hóa ( 0<= điểm <= 10)
            Tính trung bình 3 điểm
            In ra danh hiệu hs (giỏi >= 8 , 8>khá >=7 , 7>tb >=5 , yeu+kém <5)
            */
            
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\n\nHọ tên   :   Trần Văn Hinh");
            Console.WriteLine("Ngày sinh    :   30/10/1999");
            Console.WriteLine("Mã sinh viên :   521210288");
            Console.WriteLine("Lớp học      :   CNTT");
            Console.WriteLine("Môn học      :   Kiểm tra lập trình hướng đối tượng c#");
            Console.WriteLine("Bài test     :   1\n\n");

            // Nhập điểm 
            float toan, ly, hoa;
            do
            {
                Console.Write("Nhap diem Toan : ");
                toan = float.Parse(Console.ReadLine());
                if (toan < 0 || toan > 10)
                    Console.Write("Nhap lai diem : ");
            } while (toan < 0 || toan > 10);
            do
            {
                Console.Write("Nhap diem Ly : ");
                ly = float.Parse(Console.ReadLine());
                if (ly < 0 || ly > 10)
                    Console.Write("Nhap lai diem : ");
            } while (ly < 0 || ly > 10);
            do
            {
                Console.Write("Nhap diem Hoa : ");
                hoa = float.Parse(Console.ReadLine());
                if (hoa < 0 || hoa > 10)
                    Console.Write("Nhap lai diem : ");
            } while (hoa < 0 || hoa > 10);

            // Tinh tbCong
            float tbCong = (toan + ly + hoa) / 3;
            Console.WriteLine($"Diem trung binh cong là : {tbCong}");

            // Xep hang
            Console.Write($"Xep hang hoc sinh : ");
            if (tbCong < 5) Console.Write($"Kem");
            else if (tbCong < 7) Console.Write($"Trung binh");
            else if (tbCong < 8) Console.Write($"Kha");
            else if (tbCong <= 10) Console.Write($"Gioi");

            Console.WriteLine("\n\n");

        }

    }
}

