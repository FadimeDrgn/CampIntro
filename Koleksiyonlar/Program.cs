using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//isimler adında yeni bir string oluşturduk.
            //isimler[4] = "İlker";//5. elemana ilkeri atadık ama ilk dört eleman boşta kalır.
            //Console.WriteLine(isimler[4]);//çıktı da ilker yazar
            //Console.WriteLine(isimler[0]);//çıktıda boşa döner çünkü yeni oluşturduğumuz dizide ilk dörde eleman atamadık.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" } ;
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
