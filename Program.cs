using System;

namespace ÜclüDeger
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Console.WriteLine("Başlangıç Sayısını Giriniz:");
            Console.WriteLine("----------------------------");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitiş Sayısını Giriniz");
            Console.WriteLine("----------------------------");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Artış Miktarını Giriniz");
            Console.WriteLine("----------------------------");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
            for (int i = sayi1; i <= sayi2; i += sayi3)
            {
                Console.WriteLine(i);
                sayac += 1;
                
            }
            Console.WriteLine(sayi1  +  " ile " + sayi2 + " arasında " + sayac + " sayı vardır ");


        }
    }
}
