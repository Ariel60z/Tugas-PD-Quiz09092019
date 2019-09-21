using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void vKubus()
        {
            Console.WriteLine("menghitung Volume kubus");
            Console.WriteLine("Masukan nilai sisi nya");
            int sisi, luas;
            Console.Write("sisi= ");
            sisi=Convert.ToInt32(Console.ReadLine());
            
            luas=sisi*sisi*sisi;
            Console.WriteLine("Volume nya adalah "+luas);
        }
            public void vbalok()
        {
            Console.WriteLine("menghitung Volume Balok");
            Console.WriteLine("Masukan nilai sisi nya");
            int panjang,lebar,tinggi,volume;
            Console.Write("panjang= ");
            panjang=Convert.ToInt32(Console.ReadLine());
            Console.Write("lebar= ");
            lebar=Convert.ToInt32(Console.ReadLine());
            Console.Write("tinggi= ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            volume=panjang*lebar*tinggi;
            Console.WriteLine("Luas nya adalah "+volume);

        }
        
    }
}