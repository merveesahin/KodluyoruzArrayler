using System;

namespace Arrayler
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY SORT
            int [] sayiDizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("***Sirasiz Dizi***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***Sirali Dizi***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //ARRAY CLEAR
            //sayidizisi elemanlarini kullanrak 2.indexten itibaren 2 tane elemani sifirlar
            Console.WriteLine("***Array clear***");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //ARRAY REVERSE
            Console.WriteLine("***Array reverse***");
            Array.Reverse (sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // ARRAY INDEXOF
            Console.WriteLine("***Array indexof***");
            Console.WriteLine(Array.IndexOf (sayiDizisi,23));

            //ARRAY RESIZE
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi,10);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            
        }
    }
}
