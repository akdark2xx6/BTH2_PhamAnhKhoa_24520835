using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ThangNam
{
    public int Thang;
    public int Nam;
    static bool KiemTraHopLe(int thang, int nam)
    {
        //Kiểm tra ngày tháng hợp lệ
        if (thang > 0 && thang <= 12 && nam > 0)
            return true;
        return false;
    }
    public void Nhap()
    {
        //Hàm nhập 
        do
        {
            Console.Write("\nNhap thang: ");
            if (!int.TryParse(Console.ReadLine(), out Thang))
            {
                //Kiểm tra định dạng nhập vào của tháng
                Console.WriteLine("\nDinh dang khong hop le, vui long nhap lai\n");
                continue;
            }
            Console.Write("\nNhap nam: ");
            if (!int.TryParse(Console.ReadLine(), out Nam))
            {
                //Kiểm tra định dạng nhập vào của năm
                Console.WriteLine("\nDinh dang khong hop le, vui long nhap lai\n");
                continue;
            }
            if (KiemTraHopLe(Thang, Nam) == false)
            {
                //Kiểm tra tháng năm có hợp lệ không
                Console.WriteLine("\nNgay thang khong hop le, vui long nhap lai\n");
                continue;
            }
            break;
        }
        while (true);
    }
    static int NgayTrongThang(int thang, int nam)
    {
        //Hàm trả về số ngày trong tháng đó
        int x;
        switch (thang)
        {
            case 2:
                if (nam % 400 == 0 || (nam % 100 != 0 && nam % 4 == 0))
                {
                    x = 29;
                }
                else
                    x = 28;
                break;
            case 4:
                x = 30;
                break;
            case 6:
                x = 30;
                break;
            case 9:
                x = 30;
                break;
            case 11:
                x = 30;
                break;
            default:
                x = 31;
                break;
        }
        return x;
    }

    public void InLich()
    {
        //Hàm in lịch của tháng 
        Console.WriteLine("\nLich thang " + Thang + "/" + Nam + "\n");
        Console.WriteLine("Sun Mon Tue Wed Thu Fir Sat");
        DateTime dt = new DateTime(Nam, Thang, 1);
        int Bien = (int)dt.DayOfWeek;
        for (int x = 0; x < Bien; x++)
        {
            Console.Write("    ");
        }
        for (int x = 1; x <= NgayTrongThang(Thang, Nam); x++)
        {
            if (Bien > 6)
            {
                Bien = 0;
                Console.WriteLine();
            }
            if (x < 10)
                Console.Write(" " + x + "  ");
            else
                Console.Write(" " + x + " ");

            Bien++;
        }
        Console.WriteLine("\n");
    }
}