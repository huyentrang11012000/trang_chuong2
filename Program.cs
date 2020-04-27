using System;

namespace chuong2_bt1
{
    class Program
    {
        static void Main(string[] args)
        {
            TamGiac1 tg = new TamGiac1();
            //tg.nhap();
            if(tg.istamgiac())
            {
                Console.WriteLine("ket qua chu vi tg 1: " + tg.chuvi());
                Console.WriteLine("ket qua dien tich tg 1: " + tg.dientich());
            }   
            Console.ReadLine();
            TamGiac1 tg2 = new TamGiac1(2,4,3);
            Console.WriteLine("ket qua chu vi tg 2: " + tg2.chuvi());
            Console.WriteLine("ket qua dien tich tg 2: " + tg2.dientich());
             Console.ReadLine();  
            TamGiac1 tg3 = new TamGiac1(tg2);
            Console.WriteLine("ket qua tg 3: " + tg3.chuvi());
            Console.WriteLine("ket qua tg 3: " + tg3.dientich());
            tg3.nhap();
            //Console.WriteLine
            Console.WriteLine("ket qua 3: " + tg3.chuvi());
            Console.WriteLine("ket qua 3: " + tg3.dientich());
            Console.WriteLine("ket qua chu vi tg 2 sau khi thay doi: " + tg2.chuvi());
            Console.WriteLine("ket qua dien tich sau khi thay doi: " + tg2.dientich());
            Console.Read();
        }
        

        
    }
}

