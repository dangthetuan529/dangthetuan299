using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    internal class phanso
    {
        private int tuso;
        private int mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int t, int m)
        {
            tuso = t;
            mauso = m == 0 ? 1 : m;
        }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set
            { mauso = value; }
        }
        public void nhap()
        {
            Console.WriteLine("Nhập tử số");
            tuso = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập mẫu số");
            mauso = Convert.ToInt32(Console.ReadLine());
        }
        public void xuat(int tuso, int mauso)
        {
            Console.WriteLine(" {0}/{1}", tuso, mauso);
        }
        public int ucln(int a, int b)
        {
            int r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        public void rutgon()
        {

            int uc = ucln(tuso, mauso);
            tuso = tuso / uc;
            mauso = mauso / uc;
        }
        public PhanSo congphanso(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = b.tuso * a.mauso + b.mauso * a.tuso;
            kq.mauso = a.mauso * b.mauso;
            kq.rutgon();
            return kq;
        }
        public PhanSo truphanso(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = b.mauso * a.tuso - b.tuso * a.mauso;
            kq.mauso = a.mauso * b.mauso;
            kq.rutgon();
            return kq;
        }
        public PhanSo nhanphanso(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = a.tuso * b.tuso;
            kq.mauso = a.mauso * b.mauso;
            kq.rutgon();
            return kq;
        }
        public PhanSo chiaphanso(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = b.mauso * a.tuso;
            kq.mauso = a.mauso * b.tuso;
            kq.rutgon();
            return kq;
        }
    }
}

