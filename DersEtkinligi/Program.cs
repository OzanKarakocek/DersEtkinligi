using System;

namespace TemelCSharpProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, dünya!");

            
            Console.Write("Lütfen adınızı girin: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Merhaba, " + isim + "!");

           
            Console.Write("Yaşınızı girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            
            if (yas < 18)
            {
                Console.WriteLine("Gençsiniz!");
            }
            else
            {
                Console.WriteLine("Yetişkinsiniz!");
            }

           
            Console.WriteLine("Görüşmek üzere, " + isim + "!");

          
            Console.WriteLine("Çıkış yapmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}