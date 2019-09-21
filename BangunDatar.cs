using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void lpersegi()
        {
            Console.WriteLine("menghitung luas persegi");
            Console.WriteLine("Masukan nilai sisi nya");
            int sisi, luas;
            Console.Write("sisi= ");
            sisi=Convert.ToInt32(Console.ReadLine());
            
            luas=sisi*sisi;
            Console.WriteLine("Luas nya adalah "+luas);
        }
        public void lsegitiga()
        {
            Console.WriteLine("menghitung luas Segitiga");
            Console.WriteLine("Masukan Nilai nilai nya");
            int alas,tinggi,luas;

            Console.Write("Alas= ");
            alas=Convert.ToInt32(Console.ReadLine());
            Console.Write("Tinggi= ");
            tinggi=Convert.ToInt32(Console.ReadLine());
            luas=alas*tinggi/2;
            Console.WriteLine("Luas Segitiganya Adalah "+luas);
        }
        public void llingkaran()
        {
            Console.WriteLine("Menghitung luas lingkaran");
            Console.WriteLine("Masukan Nilai nilai nya");
            double jarijari,luas;
            Console.Write("Jari-Jari= ");
            jarijari=Convert.ToInt32(Console.ReadLine());
            luas=3.14*jarijari*jarijari;
            Console.WriteLine("Luas Lingkarannya Adalah "+luas);
        }
    }
}
