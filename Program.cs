using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhanvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            private string hoten, diachi;
        private int namsinh;
        private double luongcb, heso, phucap;

        public nhanvien()
        {
            hoten = "";
            diachi = "";
            namsinh = 0;
            luongcb = 0;
            heso = 0;
            phucap = 0;


        }

        public void nhap()
        {
            Console.WriteLine("Nhập tên nhân viên");
            hoten = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ ");
            diachi = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh");
            namsinh = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lương cơ bản của nhân viên");
            luongcb = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập hệ số lương");
            heso = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số phụ cấp");
            phucap = double.Parse(Console.ReadLine());

        }
        public static double tongtien(double luongcb, double heso, double phucap)
        {
            double tongtien;
            tongtien = luongcb * heso + phucap;
            return tongtien;

        }
        public void xuat()
        {
            Console.WriteLine("Họ và tên của nhân viên là: {0}:", hoten);
            Console.WriteLine(" Địa chỉ của {0} là: {1}", hoten, diachi);
            Console.WriteLine("Năm sinh của {0} là : {1}", hoten, namsinh);
            Console.WriteLine("Lương cơ bản của {0} là {1} :", hoten, luongcb);
            Console.WriteLine("Hệ số lương của {0} là : {1}", hoten, heso);
            Console.WriteLine(" Phụ cấp của {0} là : {1}", hoten, phucap);
            Console.WriteLine("Tiền lương được nhận là: {0}", tongtien(luongcb, heso, phucap));

        }
    }
}
