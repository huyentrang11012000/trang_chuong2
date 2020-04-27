using System;
using System.Collections.Generic;
using System.Text;

namespace chuong2_bt1
{
    class TamGiac1
    {
        int a, b, c;
        public bool istamgiac()
        { bool ketqua = false;
            if ((a + b) > c && (a + c) > b && (b + c) > a)
                ketqua = true;
            return ketqua;

        }
        public double chuvi()
        {
            if (istamgiac())
            { 
                return a + b + c;
            }  
         else Console.WriteLine(" day khong phai la tam giac");
            return (-1);
        }
        public double dientich()
        {
            if (istamgiac())
            {double p = 0.5*(a + b + c);
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else Console.WriteLine(" day khong phai la tam giac");
            return (-1);

        }
        public void nhap()
        {
            Console.WriteLine(" hay nhap canh a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" hay nhap canh b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hay nhap canh c");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public TamGiac1()
        {
            a = b = c = 1;
        }
        public TamGiac1( int chieudaicanh)
        {
            a = b = c = chieudaicanh;
        }
        public TamGiac1( int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public TamGiac1 (TamGiac1 tg)
        {
            this.a = tg.a;
            this.b = tg.b;
            this.c = tg.c;
        }

    }
}
