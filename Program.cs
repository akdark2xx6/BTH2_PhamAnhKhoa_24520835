using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("--- IN LICH ---\n");
        while (true)
        {
            //Chọn dừng hoặc tiếp tục chương trình
            Console.WriteLine("0. Dung chuong trinh\n1.Tiep tuc chuong trinh\n");
            int test;
            if (!int.TryParse(Console.ReadLine(), out test) || test != 1 && test != 0)
            {
                Console.WriteLine("\nLua chon khong hop le, vui long chon lai\n");
                continue;
            }
            if (test == 0)
            {
                Console.WriteLine("\n[Ket thuc chuong trinh]");
                return;
            }
            ThangNam tn = new ThangNam();
            tn.Nhap();
            tn.InLich();

        }
    }
}
