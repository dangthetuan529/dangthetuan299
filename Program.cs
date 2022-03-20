using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            PhanSo kq = new PhanSo();
            Console.WriteLine("Nhập phân số thứ nhất");
            a.nhap();
            a.xuat(a.Tuso, a.Mauso);
            Console.WriteLine("Nhập phân số thứ hai");
            b.nhap();
            b.xuat(b.Tuso, b.Mauso);
            Console.WriteLine("Phân số sau khi được rút gọn là");
            a.rutgon();
            a.xuat(a.Tuso, a.Mauso);
            b.rutgon();
            b.xuat(b.Tuso, b.Mauso);
            Console.WriteLine("Tổng hai phân số là");
            kq = kq.congphanso(a, b);
            kq.xuat(kq.Tuso, kq.Mauso);
            Console.WriteLine("Hiệu hai phân số là");
            kq = kq.truphanso(a, b);
            kq.xuat(kq.Tuso, kq.Mauso);
            Console.WriteLine("Tích hai phân số là");
            kq = kq.nhanphanso(a, b);
            kq.xuat(kq.Tuso, kq.Mauso);
            Console.WriteLine("Thương hai phân số là");
            kq = kq.chiaphanso(a, b);
            kq.xuat(kq.Tuso, kq.Mauso);
            Console.ReadLine();
        }
    }
}
